using System.Windows;
using BusinessLayer;

namespace BlogWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BlogManager bm = new BlogManager();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void button_Create_Click(object sender, RoutedEventArgs e)
        {
            bm.CreateBlog(textBox_blogUrl.Text);
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
                bm.AddPost(textBox_blogUrl.Text, textBox_PostTitle.Text, textBox_PostContent.Text);
        }

        private void button_DeleteBlog_Click(object sender, RoutedEventArgs e)
        {
            bm.DeleteBlog(textBox_blogUrl.Text);
        }

        private void button_DeletePost_Click(object sender, RoutedEventArgs e)
        {
            bm.DeletePost(textBox_blogUrl.Text, textBox_PostTitle.Text);
        }
    }
}
