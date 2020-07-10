using System;
using System.Collections.Generic;
using System.Text;

namespace lab_17_strings_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //    char[] bryn = new char[4];
            //    bryn[0] = 'b';
            //    bryn[1] = 'r';
            //    bryn[2] = 'y';
            //    bryn[3] = 'n';

            //    char[] sparta = { 's', 'p', 'a', 'r', 't', 'a' };

            //int[] newArray = { 2, 3, 4 };
            //var result = Array.ArraySum(newArray);

            //int[,] grid = new int[2, 4];    

            //int[,,,] grid4d = new int[3, 4, 20, 30];

            //int[,] grid2d = { { 4, 7, 8, 9 },{ 6, 1, 7, 10 } };
            ////4,6
            ////7,1
            ////8,7
            ////9,10
            //int val = grid2d[0, 1];
            //Console.WriteLine(val);

            //string[][] animalGrid = new string[2][];
            //animalGrid[0] = new string[4];
            //animalGrid[1] = new string[2];

            //string[][] animalGrid2 = new string[][]
            //{
            //    new string[]{"llama","puma", "horse","steve"},
            //    new string[] { "haddock", "tuna" }
            //}

            //var names = new List<string> { "Barbara","Susan"};

            //names.Add("Ian");

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //string name = "Phil";

            //var allChars = name.ToCharArray();
            //var initials = name.ToCharArray(1, 3);
            //Console.WriteLine(initials);

            //     string firstName = "Harry";
            //     string lastName = "Derbyshire";
            //     int age = 19;

            //     var string1 = firstName + " " + lastName + " " + age;
            //     var string2 = $"{firstName} {lastName} Age: {age}";
            //

            //string input = "33";
            //int input2 = Int32.Parse(input);

            //int sum = 1 + input2;

            //bool success = Int32.TryParse(input, out int input3);
            //Console.WriteLine($"{success} & {input3}");

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" Engineering 66\n Especially Nish");

            Console.WriteLine(sb);
        }

    }
    class Array
    {
        public static int ArraySum(int[] sum)
        {
            int arraySum = sum[0] + sum[1] + sum[2];
            return arraySum;
        }
    }
}
