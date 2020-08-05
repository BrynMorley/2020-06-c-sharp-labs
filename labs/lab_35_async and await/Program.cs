using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_35_async_and_await
{
    class Program
    {
        static Stopwatch s = new Stopwatch();
        static List<string> fileOutput = new List<string>();
        static void Main(string[] args)
        {
            s.Start();
            string fileName = @"D:\Github\2020-06-c-sharp-labs\labs\lab_35_async and await\Text.txt";

            if(File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                for (int i = 1; i <= 1000000 ; i++)
                { 
                    sw.WriteLine($"Line {i}");
                }
            }
            Console.WriteLine($"File create took {s.ElapsedMilliseconds}");

            s.Restart();

            var array =  ReadFile(fileName);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine($"File read took {s.ElapsedMilliseconds}");

            s.Restart();
            List<string> fileOutput = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                while(!reader.EndOfStream)
                {
                    fileOutput.Add(reader.ReadLine());
                }
            }
            Console.WriteLine($"Streamreader to list took {s.ElapsedMilliseconds}");

            s.Restart();
            var stringbuilder = new StringBuilder();
            using(var reader = new StreamReader(fileName))
                    {
                while (!reader.EndOfStream)
                {
                    stringbuilder.Append(reader.ReadLine());
                }

            }
            string fileOutput2 = stringbuilder.ToString();
            Console.WriteLine($"Streamreader to stringbuilder took {s.ElapsedMilliseconds}");


            s.Restart();
            ReadTextFileToArrayAsync(fileName);
            Console.WriteLine($"Async file read took {s.ElapsedMilliseconds} with {fileOutput.Count}  records");

            s.Restart();
            ReadFileToStringBuilder(fileName);
            
            Console.WriteLine($"Async streamread to string builder took {s.ElapsedMilliseconds}");

            s.Restart();
            var ArrayOutput = ReturnTextFileToArrayAsync(fileName);
            Console.WriteLine($"Array Async took {s.ElapsedMilliseconds} with {ArrayOutput.Result.Length}");

            
        }

        static string[] ReadFile(string fileName)
        {
            var array = File.ReadAllLines(fileName);
            return array;
        }

        static async Task<string[]> ReturnTextFileToArrayAsync(string fileName)
        {
            
            var array = await Task.FromResult(File.ReadAllLinesAsync(fileName));
            return array;
        
        }

        static async void ReadTextFileToArrayAsync(string fileName)
        {
            var array = await File.ReadAllLinesAsync(fileName);
            fileOutput = array.ToList();
        }



        static async void ReadFileToStringBuilder(string filename)
        {
            var stringbuilder = new StringBuilder();
            using (var reader = new StreamReader(filename))
            {
                while(!reader.EndOfStream)
                {
                     stringbuilder.Append(await reader.ReadLineAsync());
                }
            }
        }

    }
}
