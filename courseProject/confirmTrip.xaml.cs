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

namespace courseProject
{
    /// <summary>
    /// Логика взаимодействия для confirmTrip.xaml
    /// </summary>
    public partial class confirmTrip : Window
    {
        bool b;
        int id;
        Home em;
        public confirmTrip(bool bl, string Id,Home e)
        {
            InitializeComponent();

            if (bl)
            {
                confirmMessage.Text = "Поездка завершена?";
            }
            else
            {
                confirmMessage.Text = "Поездка отменена?";
            }

            b = bl;
            id = Convert.ToInt32(Id);
            em = e;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YesBt_Click(object sender, RoutedEventArgs e)
        {
            using(TripContext db = new TripContext())
            {
                Trip trip = db.Trips.Where(t => t.Id == id).FirstOrDefault();

                if(trip != null)
                {
                    if (b)
                    {
                        trip.State = "Завершена";
                    }
                    else
                    {
                        trip.State = "Отменена";
                    }
                }
                db.SaveChanges();

                using(UserContext udb = new UserContext())
                {
                    User user = udb.Users.Where(u => u.Name == trip.Name).FirstOrDefault();
                    if(user != null)
                    {
                        user.state = "Свободен";
                    }
                    udb.SaveChanges();
                }

                using(CarContext cdb = new CarContext())
                {
                    Car car = cdb.Cars.Where(c => c.CarName == trip.CarName).FirstOrDefault();
                    if(car != null)
                    {
                        car.State = "Свободна";
                    }
                    cdb.SaveChanges();
                }
            }
            em.UpdateTripsList();
            this.Close();
        }

        private void NoBt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
