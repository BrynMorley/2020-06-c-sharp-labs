using RadioApp;
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

namespace RadioGUI
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
        Radio radio = new Radio();


        private void Channel_1_Checked(object sender, RoutedEventArgs e)
        {
            radio.Channel = 1;
            Display.Content = radio.Play();

        }

        private void Channel_2_Checked(object sender, RoutedEventArgs e)
        {
            radio.Channel = 2;
            Display.Content = radio.Play();

        }
        private void Channel_3_Checked(object sender, RoutedEventArgs e)
        {
            radio.Channel = 3;
            Display.Content = radio.Play();
        }

        private void Channel_4_Checked(object sender, RoutedEventArgs e)
        {
            radio.Channel = 4;
            Display.Content = radio.Play();
        }
        private void On_Off_Click(object sender, RoutedEventArgs e)
        {
            radio.ToggleOnOff();
            Display.Content = radio.Play();
        }
    }
}

        
    
