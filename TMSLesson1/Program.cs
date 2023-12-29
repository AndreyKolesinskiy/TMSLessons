using System.CodeDom.Compiler;

internal class Program
{
    private static void Main(string[] args)
    {
        function10();
    }
    static void function1()
    {
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = a;

        for (int i = 1; i < b; i++)
        {
            result *= a;
        }

        Console.WriteLine("a^b=" + result);
    }

    static void function2()
    {
        Console.WriteLine("Enter number A");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = a; i <= 1000; i += a)
        {
            if (i % a == 0)
                Console.WriteLine(i);
        }
    }

    static void function3()
    {
        Console.WriteLine("Enter number A");
        int a = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 1; Math.Pow(i, 2) < a; i++)
        {
            result++;
        }

        Console.WriteLine(result);
    }

    static void function4()
    {
        Console.WriteLine("Enter A number");
        int a = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        for (int i = 1; i < a; i++)
        {
            if (a % i == 0)
                result = i;
        }
        Console.WriteLine(result);
    }

    static void function5()
    {
        Console.WriteLine("Enter A and B numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 0;

        if (a <= b)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0) result+=i;
            }
        }
        else
        {
            for (int i = b; i <= a; i++)
            {
                if (i % 7 == 0) result += i;
            }
        }

        Console.WriteLine(result);
    }

    static void function6()
    {
        Console.WriteLine("Enter positive number");
        int a = Convert.ToInt32(Console.ReadLine());
        int previousNumber = 1;
        int currentNumber = 1;
        int numberBeforePrevious = 1;

        for(int i = 3; i <= a; i++)
        {
            currentNumber = previousNumber +numberBeforePrevious;
            numberBeforePrevious = previousNumber;
            previousNumber = currentNumber;
        }

        Console.WriteLine(currentNumber);
    }

    static void function7()
    {
        Console.WriteLine("Enter A and B numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }
        Console.WriteLine(a + b);
    }

    static void function9()
    {
        Console.WriteLine("Enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        int numberOfOddDigits = 0;

        while(a /1 >=1)
        {
            if(a %2 != 0)
            {
                numberOfOddDigits++;
            }
            a /= 10;
        }
        Console.WriteLine(numberOfOddDigits);
    }

    static void function10()
    {
        Console.WriteLine("Enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        string number = "";

        while (a >= 10)
        {
            number += a % 10;
            a /= 10;
        }

        number += a;
        Console.WriteLine(number);
    }
}