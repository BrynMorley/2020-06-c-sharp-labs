using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace lab_11_microsoft_word
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create New Word Document
        
            var document = DocX.Create("MyReport.docx");
            document.InsertParagraph("This is an amazing report.");
            document.InsertParagraph($"Report genereated by <<author>> at {DateTime.Now}");
            document.Save();
            Process.Start("WINWORD.EXE", "MyReport.docx");

            
        }
    }
}
