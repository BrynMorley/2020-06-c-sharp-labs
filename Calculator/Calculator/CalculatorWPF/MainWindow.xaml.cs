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
using Calculator;

namespace CalculatorWPF
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
        static double firstNumber = 0;
        static double secondNumber = 0;

        bool plusClicked = false;
        bool minusClicked = false;
        bool timesClicked = false;
        bool divideClicked = false;
        bool modulusClicked = false;

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(Label_Display.Content);
            Label_Display.Content = "0";
            plusClicked = true;
            minusClicked = false;
            timesClicked = false;
            divideClicked = false;
            modulusClicked = false;

        }

        

        private void Button_Subtract_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(Label_Display.Content);
            Label_Display.Content = "0";
            plusClicked = false;
            minusClicked = true;
            timesClicked = false;
            divideClicked = false;
            modulusClicked = false;
        }

        private void Button_Times_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(Label_Display.Content);
            Label_Display.Content = "0";
            plusClicked = false;
            minusClicked = false;
            timesClicked = true;
            divideClicked = false;
            modulusClicked = false;
        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(Label_Display.Content);
            Label_Display.Content = "0";
            plusClicked = false;
            minusClicked = false;
            timesClicked = false;
            divideClicked = true;
            modulusClicked = false;
        }

        private void Button_Modulus_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = Convert.ToInt32(Label_Display.Content);
            Label_Display.Content = "0";
            plusClicked = false;
            minusClicked = false;
            timesClicked = false;
            divideClicked = false;
            modulusClicked = true;
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {
        secondNumber = Convert.ToInt32(Label_Display.Content);

            if (plusClicked == true)
            {
              Label_Display.Content =   CalculatorMethods.Add(firstNumber,secondNumber);
                int i = Calculator.Calculator.Add(firstNumber, secondNumber);
            }
            else if (minusClicked == true)
            {
                Label_Display.Content = CalculatorMethods.Subtract(firstNumber, secondNumber);
            }
            else if (timesClicked == true)
            {
                Label_Display.Content = CalculatorMethods.Times(firstNumber, secondNumber);
            }
            else if (divideClicked == true)
            {
                Label_Display.Content = CalculatorMethods.Divide(firstNumber, secondNumber);
            }
            else if (modulusClicked == true)
            {
                Label_Display.Content = CalculatorMethods.Modulus(firstNumber, secondNumber);
            }
            else
            {
                Label_Display.Content = 0;
            }
        }

        private void Button_01_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "1";
        }

        private void Button_02_Click(object sender, RoutedEventArgs e)
        {
           Label_Display.Content += "2";
        }

        private void Button_03_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "3";
        }
    

        private void Button_04_Click(object sender, RoutedEventArgs e)
        {
             Label_Display.Content += "4";
        }

        private void Button_05_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "5";
        }

        private void Button_06_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "6";
        }

        private void Button_07_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "7";
        }

        private void Button_08_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "8";
        }

        private void Button_09_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "9";
        }

        private void Button_00_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content += "0";
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            Label_Display.Content = "0";
            firstNumber = 0;
            secondNumber = 0;
        }
    }
}
