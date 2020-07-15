using System.Collections;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class CollectionsExercises
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string entries = "";
            if (num !=0 )
            {
                entries = queue.Dequeue();
                for (int i = 0; i < num - 1; i++)
                {
                    if (i>3)
                    {
                        return entries;
                    }
                    entries += $", {queue.Dequeue()}";
                    
                }
            }

            return entries;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var reverseStack = new Stack<int>();

            //for (int i = 0; i < original.Length; i++)
            //{
            //    reverseStack.Push(original[i]);
            //}
            foreach (int item in original)
            {
                reverseStack.Push(item);
            }

            int[] reversed = new int[original.Length];
            
            for(int i = 0 ; i < original.Length;i++)
            {
                reversed[i] = reverseStack.Pop();
            }

           return reversed;
            
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            Dictionary<char, int> numCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {char num = input[i];
                
                if (char.IsDigit(num))
                {
                    if (numCount.ContainsKey(num))
                    {
                        numCount[num] = numCount[num] + 1;
                    }
                    else
                    {
                        numCount.Add(num, 1);
                    }
                }
            }
            string output = "";
            foreach (var item in numCount)
            {
                output += $"[{item.Key}, {item.Value}]";
            }
            
            return output;
        }
    }
}