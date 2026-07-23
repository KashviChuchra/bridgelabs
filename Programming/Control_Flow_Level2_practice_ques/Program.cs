
// Leap Year Program
//int year = Convert.ToInt32(Console.ReadLine());
//if (year >= 1582)
//{
//    if( (year%4==0 && year%100!=0) || year % 400 == 0)
//    {
//        Console.WriteLine($"{year} is Leap Year");
//    }
//    else
//    {
//        Console.WriteLine($"{year} is not Leap Year");
//    }
//}
//else
//{
//    Console.WriteLine("Leap Year program only works for year greater than or equal to 1582");
//}


//int maths= Convert.ToInt32(Console.ReadLine());
//int physics = Convert.ToInt32(Console.ReadLine());
//int chemistry = Convert.ToInt32(Console.ReadLine());
//double percentage = (maths + physics + chemistry) / 300 * 100;

//double avg_maks = (maths + physics + chemistry) / 3;

//if (percentage >= 80)
//{
//    Console.WriteLine("Grade:\tLevel4\nRemarks:\tabove agency-normalized standards");
//}
//else if (percentage >= 70)
//{
//    Console.WriteLine("Grade:\tLevel3\nRemarks:\tat agency-normalized standards");
//}
//else if (percentage >= 60)
//{
//    Console.WriteLine("Grade:\tLevel2\nRemarks:\tbelow, but approaching agency-normalized standards");
//}
//else if (percentage >= 50)
//{
//    Console.WriteLine("Grade:\tLevel1\nRemarks:\twell below, agency-normalized standards");
//}
//else if(percentage >= 40)
//{
//    Console.WriteLine("Grade:\tLevel1\nRemarks:\ttoo below, agency-normalized standards");
//}
//else
//{
//    Console.WriteLine("Remedial Standards");
//}
//Console.WriteLine($"Average Marks: {avg_maks}");




// Number is Prime or Not

//int num=Convert.ToInt32(Console.ReadLine());
//Boolean isPrime = true;
//if (num <= 1)
//{
//    Console.WriteLine($"{num} is not prime");
//}
//else
//{
//    for(int i = 2; i < num; i++)
//    {
//        if (num % i == 0)
//        {
//            Console.WriteLine($"{num} is not prime");
//            isPrime = false;
//            break;
//        }
//    }
//    if(isPrime) Console.WriteLine($"{num} is prime");
//}


//int num = Convert.ToInt32(Console.ReadLine());
//if (num >= 0)
//{
//    for (int i = 0; i <= num; i++)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            Console.WriteLine("FizzBuzz");
//        }
//        else if (i % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (i % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        {
//            Console.WriteLine(num);
//        }
//    }
//}


//int num = Convert.ToInt32(Console.ReadLine());
//if (num >= 0)
//{
//    int i = 0;
//    while (i <=num)
//    {
//        if (i % 3 == 0 && i % 5 == 0)
//        {
//            Console.WriteLine("FizzBuzz");
//        }
//        else if (i % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (i % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//        else
//        {
//            Console.WriteLine(num);
//        }
//        i++;
//    }

//}


//double weight = double.Parse(Console.ReadLine());
//double height = double.Parse(Console.ReadLine());
//double cmTom = 1 / 100.0;
//double bmi = weight / (height*cmTom * height*cmTom);

//if (bmi >= 40)
//{
//    Console.WriteLine("Obese");

//}
//else if (bmi >= 39.9)
//{
//    Console.WriteLine("Overweight");
//}

//else if (bmi >= 24.9)
//{
//    Console.WriteLine("Normal");
//}

//else
//{
//    Console.WriteLine("Underweight");
//}


//int aman_age= Convert.ToInt32(Console.ReadLine());
//int akbar_age = Convert.ToInt32(Console.ReadLine());
//int anthony_age = Convert.ToInt32(Console.ReadLine());

//int aman_height = Convert.ToInt32(Console.ReadLine());
//int akbar_height = Convert.ToInt32(Console.ReadLine());
//int anthony_height = Convert.ToInt32(Console.ReadLine());

//if (aman_age <= akbar_age && aman_age <= anthony_age)
//{
//    Console.WriteLine("Aman is the youngest");
//}
//else if (akbar_age <= aman_age && akbar_age <= anthony_age)
//{
//    Console.WriteLine("Akbar is the youngest");
//}
//else
//{
//    Console.WriteLine("Anthony is the youngest");
//}

//if (aman_height > akbar_height && aman_height > anthony_height)
//{
//    Console.WriteLine("Aman is the tallest");
//}
//else if(akbar_height > aman_height && akbar_height > anthony_height)
//{
//    Console.WriteLine("Akbar is the tallest");
//}
//else
//{
//    Console.WriteLine("Anthony is the tallest");
//}


// Power of a Number

//int number = Convert.ToInt32(Console.ReadLine());
//int power = Convert.ToInt32(Console.ReadLine());
//int res = 1;

//for(int i = 1; i <= power; i++)
//{
//    res = res * number;
//}

//Console.WriteLine(res);


// Factors of a Number

//int num= Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Factors of {num} are: ");
//for (int i = 1; i <= num; i++)
//{
//    if (num % i == 0)
//    {
//        Console.Write(i+" ");
//    }
//}


// Multiples of a number

//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Multiples of {num} from 100 to 1 are: ");
//for(int i = 100; i >= 1; i--)
//{
//    if (i % num == 0)
//    {
//        Console.Write(i+" ");
//    }
//}


// Greatest factor of a number

//int num = Convert.ToInt32(Console.ReadLine());
//int greatestFactor = 1;
//for(int i = 1; i < num; i++)
//{
//    if(num % i == 0)
//    {
//        greatestFactor = i;
//    }
//}
//Console.WriteLine(greatestFactor);
