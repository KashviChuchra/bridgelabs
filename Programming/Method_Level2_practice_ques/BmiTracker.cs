using System;

namespace Method_Level1_Practice_Ques
{
    internal class BmiTracker
    {
        public void solve()
        {
            double[,] teamData = new double[10, 3];

            PopulateBmiData(teamData);
            string[] statuses = DetermineBmiStatuses(teamData);
            DisplayReport(teamData, statuses);
        }

        public void PopulateBmiData(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[i, 0] = Convert.ToDouble(Console.ReadLine());
                data[i, 1] = Convert.ToDouble(Console.ReadLine());

                double heightInMeters = data[i, 1] / 100.0;
                data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters);
            }
        }

        public string[] DetermineBmiStatuses(double[,] data)
        {
            string[] statuses = new string[data.GetLength(0)];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                double bmi = data[i, 2];

                if (bmi < 18.5)
                    statuses[i] = "Underweight";
                else if (bmi >= 18.5 && bmi < 25.0)
                    statuses[i] = "Normal";
                else if (bmi >= 25.0 && bmi < 30.0)
                    statuses[i] = "Overweight";
                else
                    statuses[i] = "Obese";
            }
            return statuses;
        }

        public void DisplayReport(double[,] data, string[] statuses)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine(data[i, 1] + " " + data[i, 0] + " " + data[i, 2] + " " + statuses[i]);
            }
        }
    }
}
