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
using System.Windows.Shapes;

namespace courseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для CarInfo.xaml
    /// </summary>
    public partial class CarInfo : Window
    {
        public CarInfo(string number)
        {
            InitializeComponent();

            using(CarContext db = new CarContext())
            {
                Car car = db.Cars.Where(c => c.CarNumber == number).FirstOrDefault();
                if(car != null)
                {
                    switch (car.CarLevel)
                    {
                        case "Премиум":
                            CarLevel.Source = new BitmapImage(new Uri("../img/Premium.png", UriKind.Relative));
                            break;
                        case "Средний":
                            CarLevel.Source = new BitmapImage(new Uri("../img/Average.png", UriKind.Relative));
                            break;
                        case "Эконом":
                            CarLevel.Source = new BitmapImage(new Uri("../img/Econom.png", UriKind.Relative));
                            break;
                    }

                    CarName.Text = "Модель: " + car.CarName;
                    CarNumber.Text = "Номер Машины: " + car.CarNumber;
                    TripsYear.Text = "Год выпуска: " + car.YearOfIssue;
                    int tripNumber = 0;
                    using(TripContext tdb = new TripContext())
                    {
                        tripNumber = tdb.Trips.Where(t => t.CarName == car.CarName).Count();
                    }
                    TripsNumber.Text = "Кол-во поездок: " + tripNumber;
                    CarStatus.Text = "Статус: " + car.State;
                    switch (car.State)
                    {
                        case "Свободна":
                            CarStatus.Foreground = Brushes.ForestGreen;
                            break;
                        case "Занята":
                            CarStatus.Foreground = Brushes.DarkRed;
                            break;
                    }
                }
                else
                {
                    this.Close();
                }
                
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
