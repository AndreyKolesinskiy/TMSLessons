using System.Text;
using TMSLesson1;

internal class Program
{
    private static void Main(string[] args)
    {
        function5();
    }

    static void function1()
    {
        Console.WriteLine("Enter a sentence containinf 'test' and some numbers"); // Smoke test 1a, test 2b should be done as soon as possible.
        string initialSentence = Console.ReadLine();
        initialSentence = initialSentence.Replace("test", "testing");
        StringBuilder sentenceWithountDigits = new StringBuilder();

        foreach (char value in initialSentence)
        {
            if (!char.IsDigit(value))
            {
                sentenceWithountDigits.Append(value);
            }
        }
        Console.WriteLine(sentenceWithountDigits);
    }

    static void function2()
    {
        string phrase = "Welcome to the TMS lessons";
        string[] arr = phrase.Split(new char[] { ' ' });
        string newPhrase = "";
        foreach (string value in arr)
        {
            newPhrase += "\"" + value + "\" ";
        }
        Console.WriteLine(newPhrase);
    }

    static void function3()
    {
        string initialString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
        string searchElement = "abc";
        string partBeforeAbc = initialString.Remove(initialString.IndexOf(searchElement));
        string partAfterAbc = initialString.Substring(initialString.IndexOf(searchElement) + searchElement.Length);

        Console.WriteLine(partBeforeAbc);
        Console.WriteLine(partAfterAbc);
    }

    static void function4()
    {
        string initialString = "Bad day";
        string removedBad = initialString.Substring(4);
        string addedNice = removedBad.Insert(0, "Nice ") + "!!!!!!!!!";
        string replacedLastExclamationMark = addedNice.Remove(addedNice.LastIndexOf("!"));
        replacedLastExclamationMark += "?";

        Console.WriteLine(removedBad);
        Console.WriteLine(addedNice);
        Console.WriteLine(replacedLastExclamationMark);
    }

    static void function5()
    {
        Console.WriteLine("Enter document number in next format: xxxx-yyy-xxxx-yyy-xyxy where x is digit and y is character");
        string documentNumber = Console.ReadLine(); // Example: "1234-abc-5678-def-1a2b"
        Task5Methods.function5_1(documentNumber);
        Task5Methods.function5_2(documentNumber);
        Task5Methods.function5_3(documentNumber);
        Task5Methods.function5_4(documentNumber);
        Task5Methods.function5_5(documentNumber);
        Task5Methods.function5_6(documentNumber);
        Task5Methods.function5_7(documentNumber);
    }
}