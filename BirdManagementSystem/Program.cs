using System;
using System.Xml.Linq;
namespace BirdManagementSystem
{
    class Program 
    {
        public static void Main(string[] args)
        {

            Bird eagle1 = new Eagle(1, Gender.FEMALE)
            {
                Name = "E-01",
                Species = "Golden Eagle"
            };

            Bird eagle2 = new Eagle(2, Gender.MALE)
            {
                Name = "E-02",
                Species = "Golden Eagle"
            };

            Bird eagle3 = new Eagle()
            {
                Id = 3,
                Name="E-03", 
                Gender=Gender.MALE,
                Species = "Golden Eagle"
            };

            Bird duck1 = new Duck(4, Gender.MALE)
            {
                Name = "D-01",
                Species = "Dabbling Duck"
            };

            Bird duck2 = new Duck(5, Gender.MALE)
            {
                Name = "D-02",
                Species = "Sea Duck"
            };

            Bird duck3 = new Duck()
            {
                Id = 6,
                Name = "D-03",
                Gender = Gender.MALE,
                Species = "Dabbling Duck"
            };

            Bird ostrich1 = new Ostrich(7, Gender.MALE)
            {
                Name = "O-01",
                Species = "Land Ostrich"
            };

            Bird ostrich2 = new Ostrich(8, Gender.MALE)
            {
                Name = "O-02",
                Species = "Land Ostrich"
            };

            Bird ostrich3 = new Ostrich()
            {
                Id = 9,
                Name = "O-03",
                Gender = Gender.MALE,
                Species = "Ostrich"
            };

            BirdManager manager = new BirdManager();
            manager.AddBirds(eagle1);
            manager.AddBirds(eagle2);
            manager.AddBirds(eagle3);
            manager.AddBirds(duck1);
            manager.AddBirds(duck2);
            manager.AddBirds(duck3);
            manager.AddBirds(ostrich1);
            manager.AddBirds(ostrich2);
            manager.AddBirds(ostrich3);
            Console.WriteLine("Total birds: " + manager.CountTotalBirds());


            manager.AddBirds(new Eagle(1, Gender.MALE));
            manager.AddBirds(new Duck(4, Gender.MALE)
            {
                Name = "D-01",
                Species = "Dabbling Duck"
            });
            // duck1 and (new Duck(4, Gender.MALE){ Name = "D-01",Species = "Dabbling Duck"});
            // Both are different objects  inspite of having same values - as they have different memory address
            // To consider them equal, override the Equals() and GetHashCode()


            Console.WriteLine("Total birds: " + manager.CountTotalBirds());
            Console.WriteLine("Eagles: " + manager.CountBirdsEachType(typeof(Eagle)));
            Console.WriteLine("Ducks: " + manager.CountBirdsEachType(typeof(Duck)));
            Console.WriteLine("Ostriches: " + manager.CountBirdsEachType(typeof(Ostrich)));

            manager.RemoveBirds(duck1);
            Console.WriteLine("Total birds after removing:" + manager.CountTotalBirds());
        }
    }

}