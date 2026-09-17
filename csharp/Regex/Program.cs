using System;
namespace RegexPractice;


class Program
{
    public static void Main(string[] args)
    {
        Class1 obj = new Class1();
        Console.WriteLine(obj.OnlyDigits("Kashvi123"));
        Console.WriteLine(obj.OnlyDigits("123Kashvi123"));
        Console.WriteLine(obj.OnlyDigits("123"));

        Console.WriteLine();

        Console.WriteLine(obj.OnlyAlphabets("Kashvi123"));
        Console.WriteLine(obj.OnlyAlphabets("123Kashvi123"));
        Console.WriteLine(obj.OnlyAlphabets("KashviChuchra"));

        Console.WriteLine();

        Console.WriteLine(obj.AlphaNumeric("Kashvi123"));
        Console.WriteLine(obj.AlphaNumeric("Kashvi"));
        Console.WriteLine(obj.AlphaNumeric("1234"));

        Console.WriteLine();

        Console.WriteLine(obj.IsUsername("Kashvi"));
        Console.WriteLine(obj.IsUsername("Kashvi Chuchra"));
        Console.WriteLine(obj.IsUsername("Kashvi123"));
        Console.WriteLine(obj.IsUsername("123"));
        Console.WriteLine(obj.IsUsername("Kashvi_123"));

        Console.WriteLine();

        Console.WriteLine(obj.PasswordValidation("Kashvi"));
        Console.WriteLine(obj.PasswordValidation("Kashvi Chuchra"));
        Console.WriteLine(obj.PasswordValidation("Kashvi123"));
        Console.WriteLine(obj.PasswordValidation("123"));
        Console.WriteLine(obj.PasswordValidation("Kashvi_123"));

        Console.WriteLine();

        Console.WriteLine(obj.StrongPassword("Kashvi"));
        Console.WriteLine(obj.StrongPassword("Kashvi Chuchra"));
        Console.WriteLine(obj.StrongPassword("Kashvi123"));
        Console.WriteLine(obj.StrongPassword("123"));
        Console.WriteLine(obj.StrongPassword("Kashvi$_123"));



        Console.WriteLine("BridgeLabz Assessment Answers: ");
        RegexBridgeLabzAssesment obj1= new RegexBridgeLabzAssesment();
        Console.WriteLine(obj1.ValidateUsername("user_123"));
        Console.WriteLine(obj1.ValidateUsername("123user"));
        Console.WriteLine(obj1.ValidateUsername("us"));

        Console.WriteLine();

        Console.WriteLine(obj1.ValidateLicensePlateNumber("AB1234"));
        Console.WriteLine(obj1.ValidateLicensePlateNumber("A12345"));

        Console.WriteLine();

        Console.WriteLine(obj1.ValidateHexCode("#FFA500"));
        Console.WriteLine(obj1.ValidateHexCode("#ff4500"));
        Console.WriteLine(obj1.ValidateHexCode("#123"));

        Console.WriteLine();

        obj1.ExtractEmailAddress("Contact us at support@example.com and info@company.org");
        obj1.CapatalizeWords("The Eiffel Tower is in Paris and the Statue of Liberty is in New York.");
        obj1.ExtractLink("Visit https://www.google.com and http://example.org for more info.");

            RegexQuestions rq = new RegexQuestions();

            string text5 = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            rq.ExtractCapitalizedWords(text5);

            string text6 = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";
            rq.ExtractDate(text6);

            string text7 = "Visit https://google.com and http://example.org for more info.";
            rq.ExtractLinks(text7);

            string text8 = "This is   an   example  with   multiple      spaces.";
            Console.WriteLine(rq.ReplaceString(text8));

            string text9 = "This is a damn bad example with some stupid words.";
            Console.WriteLine(rq.CensorBadWords(text9));

            string ip1 = "192.168.1.1";
            string ip2 = "256.100.0.50";
            Console.WriteLine(rq.ValidateIpAddress(ip1));
            Console.WriteLine(rq.ValidateIpAddress(ip2));

            string cc1 = "4123456789012345";
            string cc2 = "3123456789012345";
            Console.WriteLine(rq.ValidateCreditCard(cc1));
            Console.WriteLine(rq.ValidateCreditCard(cc2));

            string text12 = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            rq.ExtractProgrammingLanguageName(text12);

            string text13 = "The price is $45.99, and the discount is $ 10.50.";
            rq.ExtractCurrency(text13);

            string text14 = "This is is a repeated repeated word test.";
            Console.WriteLine(rq.FindRepeatingWord(text14));

            string ssn1 = "123-45-6789";
            string ssn2 = "123456789";
            Console.WriteLine(rq.ValidateSocialSecurityNumber(ssn1));
            Console.WriteLine(rq.ValidateSocialSecurityNumber(ssn2));

            Console.ReadKey();
        }
    }

