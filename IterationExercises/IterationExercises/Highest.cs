using System;
using System.Linq;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            int highestNum = 0;
            int i = 0;
            while (i<nums.Length)
            {
                if (nums[i] > highestNum)
                {
                    highestNum = nums[i];
                }
                i++;
            }

            return highestNum;
        }

        public static int HighestForLoop(int[] nums)
        {
            int highestNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]> highestNum)
                {
                    highestNum = nums[i];
                }
            }
            return highestNum;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int highestNum = 0;
            foreach (var item in nums)
            {
                if (item> highestNum)
                {
                    highestNum = item;
                }
            }
            return highestNum;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int highestNum = 0;
            int i = 0;
            do
            {
                if (nums[i] > highestNum)
                {
                    highestNum = nums[i];
                   
                }
                i++;
            } while (i < nums.Length);

            return highestNum;
        }
    }
}