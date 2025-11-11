using System.Windows;
using System.Windows.Controls;

namespace WpfApp26.Pages.Clubs.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Main Main;
        Models.Club Club;
        
        public Item(Models.Club Club, Main Main)
        {
            InitializeComponent();
            this.Name.Text = Club.Name;
            this.Address.Text = Club.Address;
            this.WorkTime.Text = Club.WorkTime;
            this.Main = Main;
            this.Club = Club;
        }

        private void EditClub(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this.Main, this.Club));

        private void DeleteClub(object sender, RoutedEventArgs e)
        {
            Main.AllClub.Clubs.Remove(Club);
            Main.AllClub.SaveChanges();
            Main.Parent.Children.Remove(this);
        }
    }
}
