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
    /// Логика взаимодействия для TripInfo.xaml
    /// </summary>
    public partial class TripInfo : Window
    {
        public TripInfo(string id)
        {
            InitializeComponent();

            using(TripContext db = new TripContext())
            {
                Trip trip = db.Trips.Where(t => t.Id.ToString() == id).FirstOrDefault();
                if(trip != null)
                {
                    TripId.Text = "Поездка номер: " + trip.Id.ToString();
                    FromWhere.Text = "Откуда: " + trip.FromWhere;
                    Destination.Text = "Куда: " + trip.Destination;
                    Driver.Text = "Водитель: " + trip.Name;
                    Car.Text = "Машина: " + trip.CarName;
                    switch (trip.CarLevel)
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
                    Price.Text = "Цена: " + trip.Price;
                    CustomerNumber.Text = "Номер клиента: " + trip.PhoneNumber;
                    Date.Text = "Дата: " + trip.Date;
                    Status.Text = "Статус: " + trip.State;
                    switch (trip.State)
                    {
                        case "В пути":
                            TripState.Source = new BitmapImage(new Uri("../img/processing.png", UriKind.Relative));
                            break;
                        case "Завершена":
                            TripState.Source = new BitmapImage(new Uri("../img/Complete.png", UriKind.Relative));
                            break;
                        case "Отменена":
                            TripState.Source = new BitmapImage(new Uri("../img/canceled.png", UriKind.Relative));
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
