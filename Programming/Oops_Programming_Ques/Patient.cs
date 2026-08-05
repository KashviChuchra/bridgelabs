using System;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface IMedicalRecord
    {
        void AddRecord(int id, string name, int age);
        void ViewRecord();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    name = "Unknown";
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    age = 0;
            }
        }

        public Patient(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Patient ID : {PatientId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Age        : {Age}");
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        public InPatient(int id, string name, int age)
            : base(id, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 1000;
        }

        public void AddRecord(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public void ViewRecord()
        {
            GetPatientDetails();
            Console.WriteLine($"Bill Amount: {CalculateBill()}");
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        public OutPatient(int id, string name, int age)
            : base(id, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 2000;
        }

        public void AddRecord(int id, string name, int age)
        {
            PatientId = id;
            Name = name;
            Age = age;
        }

        public void ViewRecord()
        {
            GetPatientDetails();
            Console.WriteLine($"Bill Amount: {CalculateBill()}");
        }
    }

}