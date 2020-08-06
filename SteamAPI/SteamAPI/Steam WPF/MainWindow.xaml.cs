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
using SteamAPI2;

namespace Steam_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Program.Root root = new Program.Root();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_BrynID_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Steam_ID.Text = 76561198033967649.ToString();
        }

        private void Button_RecentGame_Click(object sender, RoutedEventArgs e)
        {
            root = Program.getRecentGames(TextBox_Steam_ID.Text);
            TextBlock_Information.Text = $"Most Played recent game: {root.response.games[0].name}           Time Played: {root.response.games[0].playtime_2weeks}";
            
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri($"http://media.steampowered.com/steamcommunity/public/images/apps/{root.response.games[0].appid}/{root.response.games[0].img_logo_url}.jpg", UriKind.Absolute);
            bitmapImage.EndInit();

            Image_Steam.Source = bitmapImage;
           
               
        }

        private void Button_PlayerSummary_Click(object sender, RoutedEventArgs e)
        {
            root =  Program.getPlayer(TextBox_Steam_ID.Text);
            TextBlock_Information.Text = $"UserName: {root.response.players[0].personaname}";

            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(root.response.players[0].avatarfull, UriKind.Absolute);
            bitmapImage.EndInit();

            Image_Steam.Source = bitmapImage;
        }
    }
}
