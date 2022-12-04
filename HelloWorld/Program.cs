namespace HW_1_3
{
    using System.Collections.Generic;
    using System.Runtime.ExceptionServices;
    using System.Text;

    /// <summary>
    /// the main program class.
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            int[] array = new int[n];
            Random random = new ();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 27);
            }

            List<int> intList1 = new ();
            List<int> intList2 = new ();

            Array.ForEach(array, (el) =>
            {
                if (el % 2 == 0)
                {
                    intList1.Add(el);
                }
                else
                {
                    intList2.Add(el);
                }
            });

            List<char> charList1 = new ();
            List<char> charList2 = new ();

            string upperChar = "aeidhj";

            int upperCharFiff = 0;

            intList1.ForEach((el) =>
            {
                char letter = (char)((int)'a' + el - 1);
                if (upperChar.Contains(letter))
                {
                    charList1.Add(char.ToUpper(letter));
                    upperCharFiff++;
                }
                else
                {
                    charList1.Add(letter);
                }
            });

            intList2.ForEach((el) =>
            {
                char letter = (char)((int)'a' + el - 1);
                if (upperChar.Contains(letter))
                {
                    charList2.Add(char.ToUpper(letter));
                    upperCharFiff--;
                }
                else
                {
                    charList2.Add(letter);
                }
            });

            Console.WriteLine("-------------------------");
            Console.WriteLine("Array:" + (upperCharFiff >= 0 ? "1" : 2));
            Console.WriteLine("-------------------------");

            charList1.ForEach((el) => Console.Write(el + " "));
            Console.WriteLine();
            charList2.ForEach((el) => Console.Write(el + " "));
        }
    }
}