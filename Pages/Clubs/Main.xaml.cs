using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp26.Classes;

namespace WpfApp26.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public ClubsContext AllClub = new ClubsContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Club Club in AllClub.Clubs)
                Parent.Children.Add(new Elements.Item(Club, this));
        }

        private void AddClub(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this));
        }
    }
}
