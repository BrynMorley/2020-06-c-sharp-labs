using System;
using System.Collections.Generic;

namespace Lab_21_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Queue
            /*
            var myQueue = new Queue<string>();
            myQueue.Enqueue("First Item");
            myQueue.Enqueue("Second Item");
            myQueue.Enqueue("Third Item");
            myQueue.Enqueue("Fourth Item");

            Console.WriteLine(myQueue.Peek());

            myQueue.Dequeue();
            Console.WriteLine(myQueue.Peek());

            Console.WriteLine(myQueue.Contains("Third Item"));
            */
            #endregion

            #region Stack
            /*
            var myStack = new Stack<string>();
            myStack.Push("First Item");
            myStack.Push("Second Item");
            myStack.Push("Third Item");
            myStack.Push("Fourth Item");

            foreach(var item in myStack)
            {
                Console.WriteLine(item);
            }

            myStack.Pop();

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region dictionary
            /*
            var personDict = new Dictionary<int, string>();

            personDict.Add(1, "Nish");
            personDict.Add(2, "Phil");
            personDict.Add(3, "Cathy");
            #endregion

            var personDict2 = new Dictionary<int, string>()
            {
                {1, "Nish" },
                {2, "Phil" },
                {3, "Cathy" }
            };

            Console.WriteLine(   personDict2.TryAdd(1, "Bryn"));
            */
            #endregion
            string input = "We are SPARTA!";

            input = input.Trim().ToLower();

            var countD = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (countD.ContainsKey(c))
                {
                    countD[c]++;
                }
                else
                {
                    countD.Add(c, 1);
                }
            }
        }
    }
}
