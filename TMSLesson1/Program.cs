using System.Buffers;

internal class Program
{
    private static void Main(string[] args)
    {
        twoDFunction6();
    }

    //One-Dimensional arrays

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

    //Two-Dimensional arrays

    static void twoDFunction1()
    {
        int[,] arr = create2DArray(4, 4);
        print2DArray(arr);

        int min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                    min = arr[i, j];
            }
        }
        Console.WriteLine("\n" + min);
    }

    static void twoDFunction2()
    {
        int[,] arr = create2DArray(3, 4);
        print2DArray(arr);

        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                    max = arr[i, j];
            }
        }
        Console.WriteLine("\n" + max);
    }

    static void twoDFunction3()
    {
        int[,] arr = create2DArray(3, 4);
        print2DArray(arr);

        int minIndexY = 0;
        int minIndexX = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < arr[minIndexY, minIndexX])
                {
                    minIndexY = i;
                    minIndexX = j;
                }
            }
        }
        Console.WriteLine("Min element index is " + $"[{minIndexY},{minIndexX}]");
    }

    static void twoDFunction4()
    {
        int[,] arr = create2DArray(4, 4);
        print2DArray(arr);

        int maxIndexY = 0;
        int maxIndexX = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > arr[maxIndexY, maxIndexX])
                {
                    maxIndexY = i;
                    maxIndexX = j;
                }
            }
        }
        Console.WriteLine("Max element index is " + $"[{maxIndexY},{maxIndexX}]");
    }

    static void twoDFunction5() // Counts only cases when element has both: right and left neighbours
    {
        int[,] arr = create2DArray(3, 4);
        print2DArray(arr);
        int numberOfElements = 0;

        for(int i = 0;i < arr.GetLength(0); i++)
        {
            for(int j = 1;j < arr.GetLength(1) - 1; j++)
            {
                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1])
                {
                    numberOfElements++;
                }
            }
        }
        Console.WriteLine("Number of elements that are bigger than their neighbours: " + numberOfElements);
    }

    static void twoDFunction6() // Works only if array has same number of rows and columns (is a square)
    {
        int[,] arr = create2DArray(4, 4);
        print2DArray(arr);

        int c = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                c = arr[i, j];
                arr[i, j] = arr[j,i];
                arr[j, i] = c;
            }
        }
        Console.WriteLine("Mirrored array");
        print2DArray(arr);
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

    static void print2DArray(int[,] arr)
    {
        int height = arr.GetLength(0);
        int width = arr.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] create2DArray(int arrayHeight, int arrayWidth)
    {
        int[,] arr = new int[arrayHeight, arrayWidth];
        Random random = new Random();

        for (int i = 0; i < arrayHeight; i++)
        {
            for (int j = 0; j < arrayWidth; j++)
            {
                arr[i, j] = random.Next(50);
            }
        }

        return arr;
    }
}