using courseProject.Models;
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
    /// Логика взаимодействия для trips.xaml
    /// </summary>
    public partial class trips : UserControl
    {
        public trips()
        {
            InitializeComponent();
            
            FirstUnderLine.Background = Brushes.Yellow;
            addTrip.Visibility = Visibility.Hidden;

            List<string> CarLevelList = new List<string>();
            CarLevelList.Add("Премиум");
            CarLevelList.Add("Средний");
            CarLevelList.Add("Эконом");
            TripLevel.ItemsSource = CarLevelList;

            UpdateTripsList();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstUnderLine.Background = Brushes.Yellow;
            SecondUnderLine.Background = Brushes.White;
            addTrip.Visibility = Visibility.Hidden;
            TripsList.Visibility = Visibility.Visible;
            UpdateTripsList();
              
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondUnderLine.Background = Brushes.Yellow;
            FirstUnderLine.Background = Brushes.White;
            TripsList.Visibility = Visibility.Hidden;
            addTrip.Visibility = Visibility.Visible;
            
        }

        private void AddTrip_Click(object sender, RoutedEventArgs e)
        {
            if((From.Text !="")&&(Destination.Text != "")&&(PhoneNumber.Text != "")&&(Price.Text != "")&&(Driver.SelectedValue != null)&&(Car.SelectedValue != null))
            {
                using(TripContext db = new TripContext())
                {
                    
                    Trip trip = new Trip();
                    trip.FromWhere = From.Text;
                    trip.Destination = Destination.Text;
                    trip.Name = Driver.SelectedValue.ToString();
                    trip.CarName = Car.SelectedValue.ToString();
                    trip.PhoneNumber = PhoneNumber.Text;
                    trip.Price = Price.Text;
                    trip.Date = DateTime.Now.ToShortDateString();
                    trip.Time = DateTime.Now.ToLongTimeString();
                    trip.State = "В пути";

                    using(CarContext cdb = new CarContext())
                    {
                        
                        Car car = cdb.Cars.Where(c => c.CarName == Car.SelectedValue.ToString()).FirstOrDefault();

                        if (car != null)
                        {
                            car.State = "Занята";
                        }
                        cdb.SaveChanges();
                    }
                    using(UserContext udb = new UserContext())
                    {
                        User user = udb.Users.Where(u => u.Name == Driver.SelectedValue.ToString()).FirstOrDefault();

                       

                        if(user != null)
                        {
                            user.state = "Занят";
                        }
                        udb.SaveChanges();
                    }
                    db.Trips.Add(trip);
                    db.SaveChanges();
                    From.Text = "";
                    Destination.Text = "";
                    PhoneNumber.Text = "";
                    Price.Text = "";


                }
                WarnngMessage.Foreground = Brushes.Green;
                WarnngMessage.Text = "Поездка успешно добавлена";
            }
            else
            {
                WarnngMessage.Foreground = Brushes.Red;
                WarnngMessage.Text = "Заполните все поля";
            }

            updateLists(TripLevel.SelectedValue.ToString());
        }

        public void updateLists(string level)
        {
            using (CarContext db = new CarContext())
            {
                List<string> CarList = new List<string>();
                var car = db.Cars.Where(c => c.State == "Свободна");
                   
                switch (level)
                {   case "Премиум":
                        car = db.Cars.Where(c => c.State == "Свободна" && c.CarLevel == "Премиум");
                        break;
                    case "Средний":
                        car = db.Cars.Where(c => c.State == "Свободна" && c.CarLevel == "Средний");
                        break;
                    case "Эконом":
                        car = db.Cars.Where(c => c.State == "Свободна" && c.CarLevel == "Эконом");
                        break;
                }
               
                foreach (Car c in car)
                {
                    CarList.Add(c.CarName);
                }
                Car.ItemsSource = CarList;
            }

            using (UserContext db = new UserContext())
            {
                List<string> UserList = new List<string>();

                var user = db.Users.Where(c => c.position == "Driver" && c.state == "Свободен");

                foreach (User u in user)
                {
                    UserList.Add(u.Name);
                }
                Driver.ItemsSource = UserList;

            }
        }

        public void UpdateTripsList()
        {
            TripsList.Children.Clear();

            using(TripContext db = new TripContext())
            {
                var Trips = db.Trips.OrderByDescending(t => t.Id);

                foreach (Trip t in Trips)
                {
                    tripRow tr = new tripRow(t.Id, t.FromWhere, t.Destination, t.Name, t.Date, t.State);
                    TripsList.Children.Add(tr);
                }
            }
        }

        private void TripLevel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateLists(TripLevel.SelectedValue.ToString());
            TripFild.Visibility = Visibility.Visible;
        }
    }
}
