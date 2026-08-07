using System;
using System.Collections.Generic;
using System.Text;
using ProductionCode;

namespace TestCode
{
    internal class TemperatureConverterTest
    {
        private TemperatureConverter temp;
        [SetUp]
        public void SetUp()
        {
            temp= new TemperatureConverter();
        }

        [TestCase(100,212)]
        [TestCase(90,194)]
        public void CelsiusToFahrenheit(double celsius, double expected)
        {
            double result = temp.CelsiusToFahrenheit(celsius);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(212, 100)]
        [TestCase(194, 90)]
        public void FahrenheitToCelsius(double fahrenheit, double expected)
        {
            double result = temp.FahrenheitToCelsius(fahrenheit);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
