using System;
using System.Net.Http.Headers;

namespace lab_16_selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            var result = x > y ? "x greater than y" : "x less than y";
            Console.WriteLine(result);
        }

    }
    public class Selection
    {
        public static string PassFail(int mark)
        {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";
            }
            return grade;
        }
        public static string Grade(int mark)
        {
            var grade = "";



            if (mark >= 40)
            {
                grade = "Pass";



                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark > -60)
                {
                    grade += " with Merit";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }
        public static string AlertLevel(int level)
        {
            string priority = "Code";



            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:



                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "error";
                    break;
            }



            return priority;
        }

        public static string PassFailTernary(int mark)
        {
            return mark >= 40 ? "Pass" : "Fail";
        }
    }

    /* Grade - my version
    public static string Grade(int mark)
    {
        var grade = " ";
        if (mark >= 75)
        {
            grade = "Pass with Distinction";
        }
        else if (mark >= 60)
        {
            grade = "Pass with Merit";
        }
        else if (mark >= 40)
        {
            grade = "Pass";
        }
        else
        {
            grade = "fail";
        }
        return grade;
    }
    */

   
}

