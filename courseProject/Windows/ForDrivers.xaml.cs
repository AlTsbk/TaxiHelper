using courseProject.Pages;
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
using System.Windows.Shapes;

namespace courseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для ForDrivers.xaml
    /// </summary>
    public partial class ForDrivers : Window
    {
        TripsForDriver trips;
        Profile profile;
        public ForDrivers(string name)
        {
            InitializeComponent();
            trips = new TripsForDriver(name);
            profile = new Profile(name);
            ContentField.Children.Add(profile);
            ContentField.Children.Add(trips);

            trips.Visibility = Visibility.Hidden;
            Profile.Style = Application.Current.FindResource("buttonStyleCl") as Style;
            AutorizeName.Text = "Пользователь: " + name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login taskWindow = new login();
            taskWindow.Show();
            taskWindow.WarningMessage.Text = "Log Out";
            this.Close();
        }

        private void ChangePage_Click(object sender, RoutedEventArgs e)
        {
            profile.Visibility = Visibility.Hidden;
            trips.Visibility = Visibility.Hidden;

            Style style = Application.Current.FindResource("buttonStyle") as Style;
            Style styleCl = Application.Current.FindResource("buttonStyleCl") as Style;
            Profile.Style = style;  
            Trips.Style = style;
  
            Button bt = sender as Button;
            switch (bt.Name.ToString())
            {
                case "Profile":
                    Profile.Style = styleCl;
                    profile.Visibility = Visibility.Visible;
                    break;
                case "Trips":
                    Trips.Style = styleCl;
                    trips.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
