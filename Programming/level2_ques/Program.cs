

//Level 2 Practice Programs

//1. Write a program to take 2 numbers and print their quotient and remainder
//Hint: Use division operator (/) for quotient and modulus operator (%) for
//remainder
//I / P => number1, number2
//O / P => The Quotient is ___ and Remainder is ___ of two numbers ___ and
//___


double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine($"The Quotient is {num1 / num2} and Remainder is {num1 % num2} of two numbers {num1} and {num2}");

//2.Write an IntOperation program by taking a, b, and c as input values and
//print the following integer operations: a + b * c, a * b + c, c + a / b, and a % b +
//c.Please also understand the precedence of the operators.
//Hint:
//Create variables a, b, and c of int data type.
//Take user input for a, b, and c.
//Compute the 3 integer operations and assign results to variables.
//Finally, print the results and understand operator precedence.
//I / P => a, b, c
//O / P => The results of Int Operations are ___, ___, and ___

//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"The results of Int Operations are {a + b * c}, {a * b + c}, {c + a / b}, and {a % b + c}");

//3.Similarly, write the DoubleOpt program by taking double values and doing
//the same operations.
//I / P => a, b, c
//O / P => The results of Double Operations are ___, ___, and ___

double a= double.Parse(Console.ReadLine());
double b= double.Parse(Console.ReadLine());
double c= double.Parse(Console.ReadLine());
Console.WriteLine($"The results of Double Operations are {a + b * c}, {a * b + c}, {c + a / b}, and {a % b + c}");

//4.Write a TemperatureConversion program, given the temperature in Celsius
//as input that outputs the temperature in Fahrenheit
//Hint:
//Create a celsius variable and take the temperature as user input.
//Use the formula: Celsius to Fahrenheit: (°C × 9 / 5) +32 = °F
//Assign the result to fahrenheitResult and print the result.
//I/P => celsius
//O/P => The ___ Celsius is ___ Fahrenheit


double tempInCelsius = double.Parse(Console.ReadLine());
double F= (tempInCelsius * 9 / 5) + 32;
Console.WriteLine($"The {tempInCelsius} Celsius is {F} Fahrenheit");

//5. Write a TemperatureConversion program, given the temperature in
//Fahrenheit as input that outputs the temperature in Celsius
//Hint:
//Create a fahrenheit variable and take the user's input.
//Use the formula: Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
//Assign the result to celsiusResult and print the result.
//I/P => fahrenheit
//O/P => The ___ Fahrenheit is ___ Celsius

double tempInFahrenheit = double.Parse(Console.ReadLine());
double C = (tempInFahrenheit - 32) * 5 / 9;
Console.WriteLine($"The {tempInFahrenheit} Fahrenheit is {C} Celsius");

//6. Create a program to find the total income of a person by taking salary and
//bonus from the user
//Hint:
//Create a variable named salary and take user input.
//Create another variable bonus and take user input.
//Compute income by adding salary and bonus and print the result.
//I/P => salary, bonus
//O/P => The salary is INR ___ and bonus is INR ___. Hence Total Income is INR
//___

//7. Create a program to swap two numbers
//Hint:
//Create a variable number1 and take user input.
//Create a variable number2 and take user input.
//Swap number1 and number2 and print the swapped output.
//I/P => number1, number2
//O/P => The swapped numbers are ___ and ___

//8. Rewrite the Sample Program 2 with user inputs
//Hint:
//Create variables and take user inputs for name, fromCity, viaCity, toCity.
//Create variables and take user inputs for distances: fromToVia and
//viaToFinalCity in miles.
//Create variables and take the time taken for the journey.
//Finally, print the results and try to understand operator precedence.
//I/P => name, fromCity, viaCity, toCity, fromToVia, viaToFinalCity, timeTaken
//O/P => The results of the trip are: ___, ___, and ___

//9. An athlete runs in a triangular park with sides provided as input by the
//user in meters. If the athlete wants to complete a 5 km run, then how many
//rounds must the athlete complete?
//Hint:
//The perimeter of a triangle is the addition of all sides.

//Rounds = distance / perimeter
//I/P => side1, side2, side3
//O/P => The total number of rounds the athlete will run is ___ to complete 5
//km

//10. Create a program to divide N number of chocolates among M children.
//Hint:
//Get an integer value from the user for numberOfChocolates and
//numberOfChildren.
//Find the number of chocolates each child gets and the number of remaining
//chocolates.
//Display the results.
//I/P => numberOfChocolates, numberOfChildren
//O/P => The number of chocolates each child gets is ___ and the number of
//remaining chocolates is ___

//11. Write a program to input the Principal, Rate, and Time values and
//calculate Simple Interest.
//Hint:
//Simple Interest = (Principal * Rate * Time) / 100
//I/P => principal, rate, time
//O/P => The Simple Interest is ___ for Principal ___, Rate of Interest ___ and
//Time ___

//12. Create a program to convert weight in pounds to kilograms.
//Hint:
//1 pound = 2.2 kg
//I/P => weight (in pounds)
//O/P => The weight of the person in pounds is ___ and in kg is ___