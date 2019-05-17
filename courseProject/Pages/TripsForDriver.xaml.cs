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
    /// Логика взаимодействия для TripsForDriver.xaml
    /// </summary>
    public partial class TripsForDriver : UserControl
    {
        public TripsForDriver(string name)
        {
            InitializeComponent();
            UpdateTripsList(name);
        }

        public void UpdateTripsList(string name)
        {
            TripsList.Children.Clear();

            using (TripContext db = new TripContext())
            {
                var Trips = db.Trips.Where(t => t.Name == name).OrderByDescending(t => t.Id);

                foreach (Trip t in Trips)
                {
                    tripRow tr = new tripRow(t.Id, t.FromWhere, t.Destination, t.Name, t.Date, t.State);
                    TripsList.Children.Add(tr);
                }
            }
        }
    }
}
