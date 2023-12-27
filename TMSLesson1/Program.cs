internal class Program
{
    private static void Main(string[] args)
    {
        function1();
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
}