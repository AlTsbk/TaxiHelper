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

namespace courseProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Home home = new Home();
        employess employess = new employess();
        trips trips = new trips();
        settings settings = new settings();

        public MainWindow(string name, string position)
        {
            InitializeComponent();
            ContentField.Children.Add(home);
            ContentField.Children.Add(employess);
            ContentField.Children.Add(trips);
            ContentField.Children.Add(settings);


            employess.Visibility = Visibility.Hidden;
            trips.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            
            AutorizeName.Text = "Пользователь: " + name;

            switch (position)
            {
                case "Admin":
                    UserImage.Source = new BitmapImage(new Uri("img/Admin-Photo.png", UriKind.Relative));
                    AdminPanel.Visibility = Visibility.Visible;
                    break;
                case "Manager":
                    UserImage.Source = new BitmapImage(new Uri("img/Manager-Photo.png", UriKind.Relative));
                    break;
                case "Driver":
                    UserImage.Source = new BitmapImage(new Uri("img/Driver-Photo.png", UriKind.Relative));
                    break;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login taskWindow = new login();
            taskWindow.Show();
            taskWindow.WarningMessage.Text = "Log Out";
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void ChangePage_Click(object sender, RoutedEventArgs e)
        {
            employess.Visibility = Visibility.Hidden;
            trips.Visibility = Visibility.Hidden;
            settings.Visibility = Visibility.Hidden;
            home.Visibility = Visibility.Hidden;

            Style style = Application.Current.FindResource("buttonStyle") as Style;
            Style styleCl = Application.Current.FindResource("buttonStyleCl") as Style;
            Home.Style = style;
            AdminPanel.Style = style;
            Trips.Style = style;
            Settings.Style = style;

            Button bt = sender as Button;
            switch (bt.Name.ToString())
            {
                case "Home":
                    home.Visibility = Visibility.Visible;
                    Home.Style = styleCl;
                    break;
                case "AdminPanel":
                    employess.Visibility = Visibility.Visible;
                    AdminPanel.Style = styleCl;
                    break;
                case "Trips":
                    trips.Visibility = Visibility.Visible;
                    Trips.Style = styleCl;
                    break;
                case "Settings":
                    settings.Visibility = Visibility.Visible;
                    Settings.Style = styleCl;
                    break;
            }


        }

    }
     
}
