
// Level 3 

//int num= Convert.ToInt32(Console.ReadLine());
//if(num% 5 == 0)
//{
//    Console.WriteLine($"Is the number {num} divisible by 5? Yes");
//}
//else
//{
//    Console.WriteLine($"Is the number {num} divisible by 5? No");
//}

//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());
// if(num1<num2 && num1<num3)
//{
//    Console.WriteLine($"Is the first number the smallest? Yes");
//}
//else
//{
//    Console.WriteLine($"Is the first number the smallest? No");
//}


//int num1 = Convert.ToInt32(Console.ReadLine());
//int num2 = Convert.ToInt32(Console.ReadLine());
//int num3 = Convert.ToInt32(Console.ReadLine());

//if(num1>=num2 && num1 >=num3){
//    Console.WriteLine($"{num1} is the largest number.");
//}
//else if(num2 >= num1 && num2 >= num3){
//    Console.WriteLine($"{num2} is the largest number.");
//}
//else{
//    Console.WriteLine($"{num3} is the largest number.");
//}




//int num= Convert.ToInt32(Console.ReadLine());
//int sum = num * (num + 1) / 2;
//Console.WriteLine(sum);



//int age = Convert.ToInt32(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("The person's age is " + age + " and can vote.");
//}
//else
//{
//    Console.WriteLine("The person's age is " + age + " and cannot vote.");
//}


//int num = Convert.ToInt32(Console.ReadLine());
//if (num > 0){
//    Console.WriteLine("The number is positive.");
//}
//else if (num < 0)
//{
//    Console.WriteLine("The number is negative.");
//}
//else
//{
//    Console.WriteLine("The number is zero.");
//}



//int month = Convert.ToInt32(Console.ReadLine());
//int date = Convert.ToInt32(Console.ReadLine());

//if (month >= 0 && month <= 12 && date >= 1 && date <= 31)
//{
//    if ((month == 3 && date >= 20) || (month == 4) || (month == 5) || (month == 6 && date <= 20))
//    {
//        Console.WriteLine("It's a Spring Season");
//    }
//    else
//    {
//        Console.WriteLine("Not a Spring Season");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid month or date");
//}


//int num = Convert.ToInt32(Console.ReadLine());
//while (num != 0)
//{
//    Console.Write(num+" ");
//    num--;
//}





//9. Rewrite program 8 to do the countdown using the for-loop

int num = Convert.ToInt32(Console.ReadLine());
for(int i = num; i > 0; i--)
{
    Console.Write(i+" ");
}


//double input = double.Parse(Console.ReadLine());
//double total = 0.0;
//while (input != 0)
//{
//    total += input;
//    input = double.Parse(Console.ReadLine());
//}
//Console.WriteLine(total);




//double input = double.Parse(Console.ReadLine());
//double total = 0.0;
//while (input>0)
//{
//    total += input;
//    input = double.Parse(Console.ReadLine());
//}
//Console.WriteLine(total);


//int num = Convert.ToInt32(Console.ReadLine());
//if (num <= 0) Console.WriteLine("Not Natural Number");
//else
//{
//    int sum_using_formula = num * (num + 1) / 2;
//    int sum_using_loop = 0;
//    int temp = num;
//    while (temp != 0)
//    {
//        sum_using_loop += temp;
//        temp--;
//    }
//    Console.WriteLine(sum_using_loop);
//    Console.WriteLine(sum_using_formula);
//}


//int num = Convert.ToInt32(Console.ReadLine());
//if (num <= 0) Console.WriteLine("Not Natural Number");
//else
//{
//    int sum_using_formula = num * (num + 1) / 2;
//    int sum_using_loop = 0;
//    for (int i=1;i<=num;i++)
//    {
//        sum_using_loop += i;
//    }
//    Console.WriteLine(sum_using_loop);
//    Console.WriteLine(sum_using_formula);
//}


//int num = Convert.ToInt32(Console.ReadLine());
//int temp = num;
//int res = 1;
//while (temp != 0)
//{
//    res = res * temp;
//    temp--;
//}
//Console.WriteLine(res);



//int num = Convert.ToInt32(Console.ReadLine());
//int res = 1;
//for(int i = 1; i <= num; i++)
//{
//    res = res * i;
//}
//Console.WriteLine(res);



//int num = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= num; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"{i} is an even number.");

//    }
//    else
//    {
//        Console.WriteLine($"{i} is an odd number.");

//    }
//}
//int year= Convert.ToInt32(Console.ReadLine());
//int salary = Convert.ToInt32(Console.ReadLine());
//if (year > 5)
//{
//    double bonus = salary * 0.05;
//    Console.WriteLine($"The bonus amount is: {bonus}");
//}

//int num=Convert.ToInt32(Console.ReadLine());
//for(int i=6; i <= 9; i++)
//{
//    Console.WriteLine($"{num} * {i} = {num * i}");
//}