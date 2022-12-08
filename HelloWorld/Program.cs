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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    intList1.Add(array[i]);
                }
                else
                {
                    intList2.Add(array[i]);
                }
            }

            List<char> charList1 = new ();
            List<char> charList2 = new ();

            string upperChars = "aeidhj";

            int upperCharsFiff = 0;

            for (int i = 0; i < intList1.Count; i++)
            {
                char letter = (char)((int)'a' + intList1[i] - 1);
                if (upperChars.Contains(letter))
                {
                    charList1.Add(char.ToUpper(letter));
                    upperCharsFiff++;
                }
                else
                {
                    charList1.Add(letter);
                }
            }

            for (int i = 0; i < intList2.Count; i++)
            {
                char letter = (char)((int)'a' + intList2[i] - 1);
                if (upperChars.Contains(letter))
                {
                    charList2.Add(char.ToUpper(letter));
                    upperCharsFiff--;
                }
                else
                {
                    charList2.Add(letter);
                }
            }

            Console.WriteLine("-------------------------");

            Console.WriteLine("Array: " + (upperCharsFiff >= 0 ? "1" : "2"));
            Console.WriteLine("-------------------------");

            for (int i = 0; i < charList1.Count; i++)
            {
                Console.Write(charList1[i] + " ");
            }

            Console.WriteLine();
            for (int i = 0; i < charList2.Count; i++)
            {
                Console.Write(charList2[i] + " ");
            }

            Console.ReadLine();
        }
    }
}