using System;
using System.Collections.Generic;
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

namespace lab_07_calculator
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
        static int firstNumber = 0;
        static int secondNumber = 0;

        bool plusClicked = false;
        bool minusClicked = false;
        bool timesClicked = false;
        bool divideClcked = false;

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
            plusClicked = true;
            minusClicked = false;
            timesClicked = false;
            divideClcked = false;
        }
        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
            plusClicked = false;
            minusClicked = true;
            timesClicked = false;
            divideClcked = false;
        }
        private void Button_times_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
            plusClicked = false;
            minusClicked = false;
            timesClicked = true;
            divideClcked = false;
        }
        private void Button_divide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(LabelDisplay.Content);
            LabelDisplay.Content = "";
            plusClicked = false;
            minusClicked = false;
            timesClicked = false;
            divideClcked = true;
        }

        private void Button_equals_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = Convert.ToInt32(LabelDisplay.Content);

            if (plusClicked == true)
            {
                LabelDisplay.Content = firstNumber + secondNumber;
            }
            else if (minusClicked == true)
            {
                LabelDisplay.Content = firstNumber - secondNumber;
            }
            else if (timesClicked == true)
            {
                LabelDisplay.Content = firstNumber * secondNumber;
            }
            else if (divideClcked == true)
            {
                LabelDisplay.Content = firstNumber / secondNumber;
            }
            else
            {
                LabelDisplay.Content = 0;
            }
        }

        private void Button_01_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "1";
        }

        private void Button_02_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "2";
        }

        private void Button_03_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "3";
        }
        private void Button_04_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "4";
        }

        private void Button_05_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "5";
        }

        private void Button_06_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "6";
        }
        private void Button_07_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "7";
        }

        private void Button_08_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "8";
        }

        private void Button_09_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "9";
        }
        private void Button_00_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content += "0";
        }

        private void Button_clear_Click(object sender, RoutedEventArgs e)
        {
            LabelDisplay.Content = "0";
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}
