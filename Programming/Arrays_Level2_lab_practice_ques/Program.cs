
// q-01

// Console.WriteLine("Enter no of employees");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] salary = new double[n];
// int[] year = new int[n];
// Console.WriteLine("Enter salary:");
// for (int i = 0; i < n; i++)
// {
//    salary[i] = double.Parse(Console.ReadLine());
//    while (salary[i] <= 0)
//    {
//        Console.WriteLine("Input cant be negative or zero. Please re enter");
//        salary[i] = double.Parse(Console.ReadLine());
//    }
// }
// Console.WriteLine("Enter year of experience:");
// for (int i = 0; i < n; i++)
// {
//    year[i] = Convert.ToInt32(Console.ReadLine());
//    while (year[i] <= 0)
//    {
//        Console.WriteLine("Input cant be negative or zero. Please re enter");
//        year[i] = Convert.ToInt32(Console.ReadLine());
//    }
// }
// double[] new_salary = new double[n];
// double[] bonus = new double[n];
// double total_bonus = 0;
// double total_old_salary = 0;
// double total_new_salary = 0;
// for(int i = 0; i < n; i++)
// {
//    total_old_salary += salary[i];
//    if (year[i] > 5)
//    {
//        bonus[i] = 5 * salary[i] / 100;
//        new_salary[i] = 105 * salary[i] / 100;
//    }
//    else
//    {
//        bonus[i] = 2 * salary[i] / 100;
//        new_salary[i] = 102 * salary[i] / 100;
//    }
//    total_bonus += bonus[i];
//    total_new_salary += new_salary[i];
// }
// Console.WriteLine($"Total Bonus Payout\t{total_bonus}\nTotal Old Salary\t{total_old_salary}");
// Console.Write("New Salary of all employees ");
// for(int i = 0; i < n; i++)
// {
//    Console.Write(new_salary[i] +" ");
// }


// q-02

// string[] people = new string[] { "Amar", "Akbar", "Anthony" };
// int[] height = new int[3];
// int[] age = new int[3];
// for (int i = 0; i < 3; i++)
// {
//    Console.WriteLine($"Enter height and age for {people[i]}");
//    height[i] = Convert.ToInt32(Console.ReadLine());
//    age[i] = Convert.ToInt32(Console.ReadLine());
// }
// int youngest = 0;
// int tallest = 0;
// for(int i = 1; i < 3; i++)
// {
//    if (height[i] > height[tallest])
//    {
//        tallest = i;
//    }
//    if (age[i] < age[youngest])
//    {
//        youngest = i;
//    }

// }
// Console.WriteLine($"The youngest person:\t{people[youngest]}\nThe tallest person:\t{people[tallest]}");


// q-03

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for(int i = 0; i < n; i++)
// {
//    arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int largest = arr[0];
// int second_largest = 0;
// for(int i = 1; i < n; i++)
// {
//    if (arr[i] > largest)
//    {
//        second_largest = largest;
//        largest = arr[i];
//    }
//    if (largest > arr[i] && arr[i] > second_largest)
//    {
//        second_largest = arr[i];
//    }
// }
// Console.WriteLine($"Largest: {largest}\nSecond Largest{second_largest}");






// q-05

// int num=Convert.ToInt32(Console.ReadLine());
// if (num == 0)
// {
//    Console.WriteLine("0-->1");
//    return;
// }
// int count = 0;
// int temp= num;
// while (temp>0)
// {
//    count++;
//    temp = temp / 10;

// }
// temp = num;
// int[] digits = new int[count];
// for(int i = 0; i < count; i++)
// {

//    digits[i] = temp % 10;
//    temp = temp / 10;
// }
// int[] freq = new int[10];
// for(int i = 0; i < count; i++)
// {
//    freq[digits[i]]++;
// }
// for(int i=0;i<freq.Length; i++)
// {
//    if (freq[i] > 0)
//    {
//        Console.WriteLine($"{i}-->{freq[i]}");
//    }
// }



// int n = Convert.ToInt32(Console.ReadLine());
// int[] marks = new int[n];
// double[] percentages=new double[n];
// string[] grades = new string[n];


// for(int i = 0; i < n; i++)
// {
//    int maths= Convert.ToInt32(Console.ReadLine());
//    int physics= Convert.ToInt32(Console.ReadLine());
//    int chemistry= Convert.ToInt32(Console.ReadLine());
//    marks[i] = maths + physics + chemistry;
//    percentages[i] = marks[i] * 100 / 300;
//    if (percentages[i] >= 80)
//    {
//        grades[i] = "Level 4";
//    }
//    else if(percentages[i] >= 70)
//    {
//        grades[i] = "Level 3";
//    }
//    else if (percentages[i] >= 60)
//    {
//        grades[i] = "Level 2";
//    }
//    else if (percentages[i] >= 50)
//    {
//        grades[i] = "Level 1";
//    }
//    else if (percentages[i] >= 40)
//    {
//        grades[i] = "Level 1";
//    }
//    else
//    {
//        grades[i] = "Remedial Class";
//    }

//    Console.WriteLine($"Marks\t{marks[i]}\nPercentage\t{percentages[i]}\nGrade\t{grades[i]}");
// }






// int n = Convert.ToInt32(Console.ReadLine());
// int[,] studentMarks = new int[n, 3];
// double[] percentages = new double[n];
// string[] grades = new string[n];

// for (int i = 0; i < n; i++)
// {
//    int marks = 0;
//    for (int j = 0; j < 3; j++)
//    {
//        if (j == 0) Console.WriteLine("Enter Maths Marks: ");
//        else if (j == 1) Console.WriteLine("Enter Physics Marks: ");
//        else if (j == 2) Console.WriteLine("Enter Chemistry Marks: ");
//        studentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
//        marks += studentMarks[i, j];
//    }
//    percentages[i] = marks * 100 / 300.0;
//    if (percentages[i] >= 80)
//    {
//        grades[i] = "Level 4";
//    }
//    else if (percentages[i] >= 70)
//    {
//        grades[i] = "Level 3";
//    }
//    else if (percentages[i] >= 60)
//    {
//        grades[i] = "Level 2";
//    }
//    else if (percentages[i] >= 50)
//    {
//        grades[i] = "Level 1";
//    }
//    else if (percentages[i] >= 40)
//    {
//        grades[i] = "Level 1";
//    }
//    else
//    {
//        grades[i] = "Remedial Class";
//    }
//    Console.WriteLine($"Marks\t{marks}\nPercentage\t{percentages[i]}\nGrade\t{grades[i]}");
// }




// int n=Convert.ToInt32(Console.ReadLine());
// double[] height = new double[n];
// int[] weight = new int[n];
// double[] bmi = new double[n];
// string[] weight_status= new string[n];

// for(int i=0; i<n; i++)
// {
//    height[i] = double.Parse(Console.ReadLine());
//    weight[i]=Convert.ToInt32(Console.ReadLine());
//    bmi[i]= weight[i] / (height[i] * height[i]);
//    if (bmi[i] >= 40)
//    {
//        weight_status[i] ="Obese";
//    }
//    else if(bmi[i] >= 25)
//    {
//        weight_status[i] = "Overweight";
//    }
//    else if (bmi[i] >= 18.5)
//    {
//        weight_status[i] = "Normal";
//    }
//    else
//    {
//        weight_status[i] = "Underweight";
//    }
//    Console.WriteLine($"Height\t{height[i]}\nWeight\t{weight[i]}\nBMI\t{bmi[i]}\nWeight Status\t{weight_status[i]}");
// }


// int n = Convert.ToInt32(Console.ReadLine());
// double[,] personData = new double[n,3];
// string[] weight_status = new string[n];


// for (int i = 0; i < n; i++)
// {
//    int j = 0;
//    for(int k = 0; k < 3; k++)
//    {
//        if (k == 0) Console.WriteLine("Enter height: ");
//        if (k == 1) Console.WriteLine("Enter weight: ");
//        if (k == 2) Console.WriteLine("BMI calculated ");
//        if(k!=2)    personData[i, k] = double.Parse(Console.ReadLine());
//        else
//        {
//            personData[i, k] = personData[i, k- 1] / (personData[i, k - 2] * personData[i, k - 2]);
//        }
//        j = k;
//    }
//    if (personData[i, j] >= 40)
//    {
//        weight_status[i] = "Obese";
//    }
//    else if (personData[i, j] >= 25)
//    {
//        weight_status[i] = "Overweight";
//    }
//    else if (personData[i, j] >= 18.5)
//    {
//        weight_status[i] = "Normal";
//    }
//    else
//    {
//        weight_status[i] = "Underweight";
//    }
//    Console.WriteLine($"Height\t{personData[i, j - 2]}\nWeight\t{personData[i, j - 1]}\nBMI\t{personData[i, j]}\nWeight Status\t{weight_status[i]}");
// }
