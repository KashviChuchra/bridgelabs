using System;

namespace keywods_this_static_sealed
{
    internal class Patient
    {
        public static string HospitalName = "City Hospital";
        public static int totalPatients;

        public string name;
        public int age;
        public string ailment;
        public readonly int patientID;

        public Patient(string name, int age, string ailment, int patientID)
        {
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            this.patientID = patientID;
            totalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients: {totalPatients}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Hospital : {HospitalName}");
            Console.WriteLine($"Patient ID : {patientID}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Ailment : {ailment}");
        }
    }
}