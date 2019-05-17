using courseProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        
        public Home()
        {
            InitializeComponent();
            FirstUnderLine.Background = Brushes.Yellow;
            EmployeesList.Visibility = Visibility.Hidden;


            AddDriverList();
            UpdateTripsList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstUnderLine.Background = Brushes.Yellow;
            SecondUnderLine.Background = Brushes.White;
            CurrentTripsList.Visibility = Visibility.Visible;
            EmployeesList.Visibility = Visibility.Hidden;
            UpdateTripsList();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondUnderLine.Background = Brushes.Yellow;
            FirstUnderLine.Background = Brushes.White;
            EmployeesList.Visibility = Visibility.Visible;
            CurrentTripsList.Visibility = Visibility.Hidden;
            UpdateInformation();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        
        
        public void UpdateTripsList()
        {
            TripsList.Children.Clear();

            using (TripContext db = new TripContext())
            {
                var Trips = db.Trips.Where(t => t.State == "В пути").OrderByDescending(t => t.Id);

                foreach (Trip t in Trips)
                {
                    tripRow tr = new tripRow(t.Id, t.FromWhere, t.Destination, t.Name, t.Date, t.State, this);
                    tr.CompleteButtons.Visibility = Visibility.Visible;
                    tr.InfoBt.Visibility = Visibility.Hidden;
                    TripsList.Children.Add(tr);
                }
            }
        }

        private void DriverList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DriverListContent.Visibility = Visibility.Visible;
            UpdateInformation();
            
        }
        public void UpdateInformation()
        {
            if(DriverList.SelectedValue != null)
            {
                using (TripContext db = new TripContext())
                {
                    var trips = db.Trips.Where(t => (t.Name == DriverList.SelectedValue.ToString() && t.State == "Завершена"));
                    if (DriverList.SelectedValue.ToString() == "Вся компания")
                    {
                        trips = db.Trips.Where(t => t.State == "Завершена");
                    }
                    DriverName.Text = DriverList.SelectedValue.ToString();
                    NumberOfTrips.Text = trips.Count().ToString();
                    int money = 0;
                    foreach (Trip t in trips)
                    {
                        money += Convert.ToInt32(t.Price);
                    }
                    Money.Text = money.ToString() + "р";

                    PremiumTrip.Text = trips.Where(t => t.CarLevel == "Премиум").Count().ToString();
                    AverageTrip.Text = trips.Where(t => t.CarLevel == "Средний").Count().ToString();
                    EconomTrip.Text = trips.Where(t => t.CarLevel == "Эконом").Count().ToString();

                }
            }
            
        }
        public void AddDriverList()
        {
            List<string> Drivers = new List<string>();
            using(UserContext db = new UserContext())
            {
                Drivers.Add("Вся компания");
                var users = db.Users.Where(u => u.position == "Driver");
                foreach (User u in users)
                {
                    Drivers.Add(u.Name);
                }
                DriverList.ItemsSource = Drivers;
            }
            
            
            
        }
    }
}
