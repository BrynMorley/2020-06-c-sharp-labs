using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Words.NET;

namespace lab_12_Big_Go_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void button_Go_Click(object sender, RoutedEventArgs e)
        {
         
            var stopwatch = new Stopwatch();
            string folderName = @"d:\redrum";
            string[] files = Directory.GetFiles(folderName);
            int fileAmount = 1000;

            stopwatch.Start();
            if (Directory.Exists(folderName))
            {
                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
                Directory.Delete(folderName);
            }
           
                Directory.CreateDirectory(folderName);
            for (int i=0;i < fileAmount; i++)
            {
                File.WriteAllText(@"d:\redrum\text"+i,"All work and no play makes Jack a dull boy");
            }
            stopwatch.Stop();
            label_Timer.Content = stopwatch.ElapsedMilliseconds;

            var document = DocX.Create("TimerReport.docx");
            document.InsertParagraph($"Report genereated by <<author>> at {DateTime.Now}");
            document.InsertParagraph($"{fileAmount} files created in {stopwatch.ElapsedMilliseconds} miliseconds");
            document.Save();
            

        }
    }
}
