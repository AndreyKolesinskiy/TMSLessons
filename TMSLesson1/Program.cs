internal class Program
{
    private static void Main(string[] args)
    {
        function6();
    }

    static void function1()
    {
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());
        int result;

        if (a > b)
        {
            result = a + b;
        }
        else if (a == b)
        {
            result = a * b;
        }
        else
        {
            result = a - b;
        }
        Console.WriteLine(result);
    }

    static void function2()
    {
        Console.WriteLine("Enter X (do not enter 0 value)");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y (do not enter 0 value)");
        int y = Convert.ToInt32(Console.ReadLine());
        string quarter;

        if (x > 0 & y > 0)
        {
            quarter = "Top right quarter";
        }
        else if (x > 0 & y < 0)
        {
            quarter = "Bottom right quarter";
        }
        else if (x < 0 & y < 0)
        {
            quarter = "Bottom left quarter";
        }
        else
        {
            quarter = "Top left quarter";
        }
        Console.WriteLine(quarter);
    }

    static void function3()
    {
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b & b > c)
        {
            Console.WriteLine(c + " " + b + " " + a);
        }
        else if (a > c & c > b)
        {
            Console.WriteLine(b + " " + c + " " + a);
        }
        else if (b > a & a > c)
        {
            Console.WriteLine(c + " " + a + " " + b);
        }
        else if (b > c & c > a)
        {
            Console.WriteLine(a + " " + c + " " + b);
        }
        else if (c > a & a > b)
        {
            Console.WriteLine(b + " " + a + " " + c);
        }
        else if (c > b & b > a)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
    }

    static void function5()
    {
        Console.WriteLine("Enter number with two digits");
        int number = Convert.ToInt32(Console.ReadLine());
        string firstWord = "";
        string secondWord = "";

        if (number / 10 == 1)
        {
            switch (number % 10)
            {
                case 1:
                    firstWord = "eleven";
                    break;
                case 2:
                    firstWord = "twelwe";
                    break;
                case 3:
                    firstWord = "thirteen";
                    break;
                case 4:
                    firstWord = "fourteen";
                    break;
                case 5:
                    firstWord = "fifteen";
                    break;
                case 6:
                    firstWord = "sixteen";
                    break;
                case 7:
                    firstWord = "seventeen";
                    break;
                case 8:
                    firstWord = "eightteen";
                    break;
                case 9:
                    firstWord = "nineteen";
                    break;
                default:
                    firstWord = "Incorrect number";
                    break;
            }
        }
        else
        {
            switch (number / 10)
            {
                case 2:
                    firstWord = "twenty";
                    break;
                case 3:
                    firstWord = "thirty";
                    break;
                case 4:
                    firstWord = "fourty";
                    break;
                case 5:
                    firstWord = "fithty";
                    break;
                case 6:
                    firstWord = "sixty";
                    break;
                case 7:
                    firstWord = "seventy";
                    break;
                case 8:
                    firstWord = "eighty";
                    break;
                case 9:
                    firstWord = "ninety";
                    break;
                default:
                    firstWord = "Incorrect number";
                    break;
            }

            switch (number % 10)
            {
                case 0:
                    secondWord = "";
                    break;
                case 1:
                    secondWord = "one";
                    break;
                case 2:
                    secondWord = "two";
                    break;
                case 3:
                    secondWord = "three";
                    break;
                case 4:
                    secondWord = "four";
                    break;
                case 5:
                    secondWord = "five";
                    break;
                case 6:
                    secondWord = "six";
                    break;
                case 7:
                    secondWord = "seven";
                    break;
                case 8:
                    secondWord = "eight";
                    break;
                case 9:
                    secondWord = "nine";
                    break;
                default:
                    secondWord = "Incorrect number";
                    break;
            }
        }
        Console.WriteLine(firstWord + " " + secondWord);
    }

    static void function6()
    {
        Console.WriteLine("Enter enter X for point M");
        double xM = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter enter Y for point M");
        double yM = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Enter X of the center of the circle");
        double x0 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y of the center of the circle");
        double y0 = Convert.ToInt32(Console.ReadLine());        
        Console.WriteLine("Enter radius of the circle");
        double r = Convert.ToInt32(Console.ReadLine());

        double hypotenuse = Math.Sqrt(Math.Pow(xM-x0, 2) + Math.Pow(yM - y0, 2));
        
        string result = r > hypotenuse ? "Point M is inside the circle" : "Point M is outside the circle";
        Console.WriteLine(result);
    }
}