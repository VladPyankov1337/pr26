using System.Windows;
using System.Windows.Controls;

namespace WpfApp26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(new Pages.Clubs.Main());
        }

        private void Clubs(object sender, RoutedEventArgs e)
        {
            OpenPages(new Pages.Clubs.Main());
        }

        private void Users(object sender, RoutedEventArgs e)
        {
            OpenPages(new Pages.Users.Main());

        }

        public void OpenPages(Page Page)
        {
            frame.Navigate(Page);
        }
    }
}
