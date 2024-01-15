using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMSLesson1
{
    internal class Task5Methods
    {
        public static void function5_1(string documentNumber)
        {
            string[] arr = documentNumber.Split(new char[] { '-' });
            Console.WriteLine(arr[0] + arr[2]);
        }

        public static void function5_2(string documentNumber)
        {
            string[] arr = documentNumber.Split(new char[] { '-' });
            Console.WriteLine(arr[0] + "-***" + "-" + arr[2] + "-***" + "-" + arr[4]);
        }

        public static void function5_3(string documentNumber)
        {
            documentNumber = documentNumber.Replace("-", "");
            StringBuilder sb = new StringBuilder();

            foreach (char value in documentNumber)
            {
                if (!char.IsDigit(value))
                {
                    sb.Append(value);
                }
            }
            string result = sb.ToString().ToLower();

            Console.WriteLine(result.Substring(0, 3) + "/" + result.Substring(3, 3)
                + "/" + result.Substring(6, 1) + "/" + result.Substring(7, 1));
        }

        public static void function5_4(string documentNumber)
        {
            documentNumber = documentNumber.Replace("-", "");
            StringBuilder sb = new StringBuilder();

            foreach (char value in documentNumber)
            {
                if (!char.IsDigit(value))
                {
                    sb.Append(value);
                }
            }
            string result = sb.ToString().ToUpper();

            Console.WriteLine(result.Substring(0, 3) + "/" + result.Substring(3, 3)
                + "/" + result.Substring(6, 1) + "/" + result.Substring(7, 1));
        }

        public static void function5_5(string documentNumber)
        {
            string element = "abc";
            string result = documentNumber.ToLower().Contains(element) ? "Document conains abc or ABC" : "Document doesn't contain abc and ABC";
            Console.Write(result);
        }

        public static void function5_6(string documentNumber)
        {
            string element = "555";
            string result = documentNumber.StartsWith(element) ? "Document starts with " + element : "Document doesn't start with " + element;
            Console.Write(result);
        }

        public static void function5_7(string documentNumber)
        {
            string element = "1a2b";
            string result = documentNumber.EndsWith(element) ? "Document ends with " + element : "Document doesn't end with " + element;
            Console.Write(result);
        }
    }
}
