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

namespace Lab_22_WPF_Practice
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

        private void button_Confirm_Click(object sender, RoutedEventArgs e)
        {
            if(radioButton_Yes.IsChecked== true)
            {
                MessageBox.Show("Oh","Greetings!",MessageBoxButton.OK,MessageBoxImage.Question);
            }
            else if (radioButton_No.IsChecked ==true)
            {
                MessageBox.Show("Nothing wrong with being average.","Greetings!", MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
        }
    }
}
