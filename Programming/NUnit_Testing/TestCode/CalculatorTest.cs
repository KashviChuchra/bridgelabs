using ProductionCode;
using System.Runtime.ExceptionServices;

namespace TestCode
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(12,15,27)]
        [TestCase(100, -15, 85)]
        [TestCase(20,35,55)]

        public void Add_TwoNumbers_ReturnsCorrectSum(int a, int b, int expected)
        {
            int result= calculator.Add(a, b);
            Assert.That(result,Is.EqualTo(expected));
        }

        [TestCase(12, 15, -3)]
        [TestCase(100, -15, 115)]
        [TestCase(20, 35, -15)]
        public void Subtract_TwoNumbers_ReturnsCorrectValue(int a, int b, int expected)
        {
            int result = calculator.Subtract(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(13,3,39)]
        [TestCase(12, 5, 60)]
        [TestCase(9, 9, 81)]

        public void Multiply_TwoNumbers_ReturnsCorrectValue(int a, int b, int expected)
        {
            int result = calculator.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }


        [TestCase(15, 5, 3)]
        [TestCase(10,0,0)] // Throws Exception
        [TestCase(81, 4, 20.25)]
        public void Divide_TwoNumbers_ReturnsCorrectValue(int a, int b, double expected)
        {
            if (b == 0)
            {
                Assert.Throws <DivideByZeroException>(() =>
                {
                    int result = a / b;
                });
            }
            else
            {
                double result = calculator.Divide(a, b);
                Assert.That(result, Is.EqualTo(expected));
            }
            

        }

        
    }
}
