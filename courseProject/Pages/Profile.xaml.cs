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

namespace courseProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile(string name)
        {
            InitializeComponent();
            UpdateInformation(name);
        }

        public void UpdateInformation(string name)
        {
           
                using (TripContext db = new TripContext())
                {
                    var trips = db.Trips.Where(t => (t.Name == name && t.State == "Завершена"));
                    DriverName.Text = name;
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
}
