using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates; // Include this for basic functionalities like Console, DateTime

internal class Program
{
    const int MaxScore = 100;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!!!");

        int numberOfDays = 1;
        Console.WriteLine(numberOfDays);

        var favoriteNumber = 9;
        System.Console.WriteLine("My Favorite Number: " + favoriteNumber);

        int a = 1;
        int b = 2;

        int c = AddNumbers(a, b);
        Console.WriteLine(c);

        int myNumb = 6;
        bool d = IsEven(myNumb);
        Console.WriteLine(d);

        // Snapshot of the time - UtcNow is better!!!!
        Console.WriteLine(DateTime.UtcNow);

        // Follow up
        DateTime e = DateTime.Parse("10/9/2024 4:43:48");
        Console.WriteLine(e);

        // Enum usage (moved enum declaration outside the method)
        EmployeeType employeeType = EmployeeType.Manager;
        Console.WriteLine("My Role is: " + employeeType); // Correct usage

        foreach (var f in Enum.GetValues(typeof(EmployeeType))){
            Console.WriteLine(f);
        }


        var personInfo = (Age: 31, Name: "Steve", IsEmployed: true);
        Console.WriteLine("***** Person Info: ******");
        Console.WriteLine(personInfo.Age); 
        Console.WriteLine(personInfo.Name); 
        Console.WriteLine(personInfo.IsEmployed); 

        // STRINGS
        string name = 
        """
        STEEEEEEEEEEEVE
        """;

        string greeting = $"Hello, {name}!";

        if (string.Equals(name, greeting, StringComparison.OrdinalIgnoreCase))
        {

        }

        Console.WriteLine(name);
        Console.WriteLine(greeting);

        Console.WriteLine(greeting.Length + 19);

        // IF
        int age = 21;
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }


    // SWITCH

    int day = 3;
    switch (day)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break; 
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid day.");
            break;
    }

    // FOR LOOP
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine(i);
    }

    // WHILE Statement //! Take a look at this
    int g = 1;

    while (true)
    {
        // code block to be executed
        if (g == 1)
        {

            break;  // Exit the loop
            // Console.WriteLine("This won't display");
        }

        // Continue skips to the next iteration, so nothing after it will execute
        Console.WriteLine("This should Display.");
        continue;
    }

    // TRY/CATCH 
    // EXCEPTIONS

    // Pattern Matching
    object value = "Hmmm, Am I a string?";
    if (value is string str)
    {
        Console.WriteLine($"The value is a string: {str}");
    }
    else
    {
        Console.WriteLine("The value is not a string.");
    }

    //Relational Patters
    int number = 42;
    if (number is >= 0 and <= 50)
    {
        Console.WriteLine("The number is between 0 and 100.");
    }

    // Positional Patterns - Tuple
    (int, string, bool) tuple = (1, "Hello", true);
    if (tuple is (1, string stri, true))
    {
        Console.WriteLine("The tuple matches the pattern.");
    }
    else
    {
        Console.WriteLine("The tuple does not match the pattern.");
    }

    // Arithmetic Operators
    int aa = 5;
    int bb = a++; // bb is 5, aa is 6
    int cc = ++a; // cc is 7, a is 7
    Console.WriteLine($"aa: {aa}");
    Console.WriteLine($"bb: {bb}");
    Console.WriteLine($"cc: {cc}");


    // Parse
    int alphaA = int.Parse("5"); // Converts "5" to 5
        Console.WriteLine(alphaA);
    int alphaB = Convert.ToInt32("5"); // Converts "5" to 5
        Console.WriteLine(alphaB);




    }

    // Enum must be declared outside of the Main method
    public enum EmployeeType
    {
        Manager,
        Supervisor,
        Boss,
    }

    // void does not return a value. It simply executes logic without providing output directly.
    public static void PrintMessage()
    {
        Console.WriteLine("This is a void method.");
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }









}
