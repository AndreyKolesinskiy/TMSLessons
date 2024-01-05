internal class Program
{
    private static void Main(string[] args)
    {
        function8();
    }

    static void function1()
    {
        int[] arr = createArray(20);
        printArray(arr);

        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        Console.WriteLine("\n" + min);
    }

    static void function2()
    {
        int[] arr = createArray(20);
        printArray(arr);

        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine("\n" + max);
    }

    static void function3()
    {
        int[] arr = createArray(20);
        printArray(arr);

        int minNumberIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < arr[minNumberIndex])
                minNumberIndex = i;
        }
        Console.WriteLine("\n" + minNumberIndex);
    }

    static void function4()
    {
        int[] arr = createArray(20);
        printArray(arr);

        int maxNumberIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > arr[maxNumberIndex])
                maxNumberIndex = i;
        }
        Console.WriteLine("\n" + maxNumberIndex);
    }

    static void function5()
    {
        int[] arr = createArray(6);
        printArray(arr);

        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        Console.WriteLine("\n" + sum);
    }

    static void function6()
    {
        int[] arr = createArray(8);
        printArray(arr);

        int centerOfArray = arr.Length / 2;
        int c = 0;
        for (int i = 0; i < centerOfArray; i++)
        {
            c = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = c;
        }
        Console.WriteLine();
        printArray(arr);
    }

    static void function7()
    {
        int[] arr = createArray(7);
        printArray(arr);

        int numberOfOddElements = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
                numberOfOddElements++;
        }
        Console.WriteLine("\n" + numberOfOddElements);
    }

    static void function8()
    {
        int[] arr = createArray(8);
        printArray(arr);
        int middleOfArray = arr.Length % 2 == 0 ? arr.Length / 2 : arr.Length / 2 + 1;

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int c = arr[i];
            arr[i] = arr[middleOfArray + i];
            arr[middleOfArray + i] = c;
        }
        Console.WriteLine();
        printArray(arr);
    }


    //Help methods
    static int[] createArray(int arraySize)
    {
        int[] arr = new int[arraySize];
        Random random = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(50);
        }

        return arr;
    }

    static void printArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
    }
}