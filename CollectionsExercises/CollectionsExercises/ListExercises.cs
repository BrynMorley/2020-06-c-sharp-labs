﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> fiveList = new List<int>();

            for (int i = 1; i <= max; i++)
            {
                if(i%5==0)
                {
                    fiveList.Add(i);
                }
            }
          return fiveList;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            if(argList.Count ==0)
            {
                return 0;
            }
            return argList.Average();
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> beginsWithA = new List<string>();
            foreach (var item in sourceList)
            {
                if (item[0] =='a' ||item[0] == 'A')
                {
                    beginsWithA.Add(item);
                }
            }
            return beginsWithA;
        }
    }
}