using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Npgsql;

namespace IO_Programming
{
    internal class JsonData
    {
        public void CreateStudentJSON(string filePath)
        {
            Student student = new Student { Name = "Kashvi", Age = 21, Subjects = new List<string> { "Java", "C#", "SQL" } };
            string json = JsonSerializer.Serialize(student, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine(json);
        }

        public void ConvertCarToJSON()
        {
            Car car = new Car { Brand = "Toyota", Model = "Camry", Year = 2025 };
            string json = JsonSerializer.Serialize(car, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);
        }

        public void ExtractSpecificFields(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (User user in users)
                Console.WriteLine($"Name: {user.Name}, Email: {user.Email}");
        }

        public void MergeJSONObjects(string file1, string file2, string outputFile)
        {
            JObject object1 = JObject.Parse(File.ReadAllText(file1));
            JObject object2 = JObject.Parse(File.ReadAllText(file2));
            object1.Merge(object2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
            File.WriteAllText(outputFile, object1.ToString());
            Console.WriteLine(object1);
        }

        public void ValidateJSONSchema(string jsonFilePath, string schemaFilePath)
        {
            JObject json = JObject.Parse(File.ReadAllText(jsonFilePath));
            JSchema schema = JSchema.Parse(File.ReadAllText(schemaFilePath));
            bool valid = json.IsValid(schema, out IList<string> errors);

            if (valid)
                Console.WriteLine("JSON is valid.");
            else
            {
                Console.WriteLine("JSON validation failed.");

                foreach (string error in errors)
                    Console.WriteLine(error);
            }
        }

        public void ConvertListToJSONArray()
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Kashvi", Age = 21, Subjects = new List<string> { "Java", "C#" } },
                new Student { Name = "Ananya", Age = 22, Subjects = new List<string> { "SQL", "C#" } }
            };

            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine(json);
        }

        public void FilterJSONByAge(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (User user in users.Where(x => x.Age > 25))
                Console.WriteLine($"{user.Name} - {user.Age}");
        }

        public void PrintJSONKeysAndValues(string filePath)
        {
            JObject json = JObject.Parse(File.ReadAllText(filePath));

            foreach (JProperty property in json.Properties())
                Console.WriteLine($"{property.Name}: {property.Value}");
        }

        public void ValidateEmail(string email)
        {
            bool valid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Console.WriteLine(valid ? "Email is valid." : "Invalid email.");
        }

        public void ConvertJSONToXML(string jsonFilePath, string xmlFilePath)
        {
            JObject json = JObject.Parse(File.ReadAllText(jsonFilePath));
            XElement root = new XElement("Student");

            foreach (JProperty property in json.Properties())
                root.Add(new XElement(property.Name, property.Value.ToString()));

            root.Save(xmlFilePath);
            Console.WriteLine(root);
        }

        public void ConvertCSVToJSON(string csvFilePath, string jsonFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);
            List<StudentCSV> students = new List<StudentCSV>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                students.Add(new StudentCSV { Id = int.Parse(columns[0]), Name = columns[1], Age = int.Parse(columns[2]) });
            }

            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, json);
            Console.WriteLine(json);
        }

        public void GenerateJSONFromDatabase(string connectionString, string outputFilePath)
        {
            List<Employee> employees = new List<Employee>();

            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            using NpgsqlCommand command = new NpgsqlCommand("SELECT employee_id, name, department, salary FROM employees", connection);
            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                employees.Add(new Employee { EmployeeId = Convert.ToInt32(reader["employee_id"]), Name = reader["name"].ToString(), Department = reader["department"].ToString(), Salary = Convert.ToDouble(reader["salary"]) });

            string json = JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(outputFilePath, json);
            Console.WriteLine(json);
        }

        public void IPLCensorshipAnalyzer(string jsonInput, string csvInput, string jsonOutput, string csvOutput)
        {
            List<IPLMatch> jsonMatches = ReadIPLFromJSON(jsonInput);
            List<IPLMatch> csvMatches = ReadIPLFromCSV(csvInput);

            CensorMatches(jsonMatches);
            CensorMatches(csvMatches);

            WriteIPLToJSON(jsonMatches, jsonOutput);
            WriteIPLToCSV(csvMatches, csvOutput);

            Console.WriteLine("Censored JSON:");
            Console.WriteLine(File.ReadAllText(jsonOutput));

            Console.WriteLine("Censored CSV:");
            Console.WriteLine(File.ReadAllText(csvOutput));
        }

        private List<IPLMatch> ReadIPLFromJSON(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<IPLMatch>>(json);
        }

        private List<IPLMatch> ReadIPLFromCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<IPLMatch> matches = new List<IPLMatch>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                matches.Add(new IPLMatch { MatchId = int.Parse(columns[0]), Team1 = columns[1], Team2 = columns[2], ScoreTeam1 = int.Parse(columns[3]), ScoreTeam2 = int.Parse(columns[4]), Winner = columns[5], PlayerOfMatch = columns[6] });
            }

            return matches;
        }

        private void CensorMatches(List<IPLMatch> matches)
        {
            foreach (IPLMatch match in matches)
            {
                string originalTeam1 = match.Team1;
                string originalTeam2 = match.Team2;

                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                match.Score = new Dictionary<string, int>
                {
                    { MaskTeamName(originalTeam1), match.ScoreTeam1 },
                    { MaskTeamName(originalTeam2), match.ScoreTeam2 }
                };
            }
        }

        private string MaskTeamName(string teamName)
        {
            string[] words = teamName.Split(' ');

            if (words.Length == 2)
                return $"{words[0]} ***";

            if (words.Length >= 3)
                return $"{words[0]} *** {string.Join(" ", words.Skip(2))}";

            return "***";
        }

        private void WriteIPLToJSON(List<IPLMatch> matches, string filePath)
        {
            string json = JsonSerializer.Serialize(matches, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void WriteIPLToCSV(List<IPLMatch> matches, string filePath)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("match_id,team1,team2,score_team1,score_team2,winner,player_of_match");

            foreach (IPLMatch match in matches)
                writer.WriteLine($"{match.MatchId},{match.Team1},{match.Team2},{match.ScoreTeam1},{match.ScoreTeam2},{match.Winner},{match.PlayerOfMatch}");
        }
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }

    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    internal class StudentCSV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    internal class IPLMatch
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
}

