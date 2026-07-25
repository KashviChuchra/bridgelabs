using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace control_flow_level3;

public class Calculator
{
    public void CheckCalculator()
    {
        //        Create two double variables named first and second and a String variable named op.
        //Get input values for all variables.
        //The input for the operator can only be one of the four values: "+", "-", "*" or "/".
        //Run a for loop from i = 1 to i < number.
        //Based on the input value of the op, perform specific operations using the switch...case statement and print the result.
        //If op is +, perform addition between first and second; if it is -, perform subtraction and so on.
        //If op is neither of those 4 values, print Invalid Operator.

        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        double res = 0;

        string op = Console.ReadLine();
        switch (op) {
            case "+":
                res = first + second;
                break;
            case "-":
                res = first - second;
                break;
            case "*":
                res = first * second;
                break;
            case "/":
                if (second == 0)
                {
                    Console.WriteLine("Cant divide by zero");
                    return;
                }
                res = first / second;
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;

        }
        Console.WriteLine($"Output: {res}");

    }
    }
