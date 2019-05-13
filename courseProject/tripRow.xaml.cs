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
    /// Логика взаимодействия для tripRow.xaml
    /// </summary>
    public partial class tripRow : UserControl
    {
        Home em;

        public tripRow(int tripsId, string fromWhere, string destination, string driver, string date, string state, Home empl = null)
        {
            InitializeComponent();

            TripsNumber.Text = tripsId.ToString();
            From.Text = fromWhere;
            Destination.Text = destination;
            Driver.Text = driver;
            Date.Text = date;

            switch (state)
            {
                case "В пути":
                    TripState.Source = new BitmapImage(new Uri("img/processing.png", UriKind.Relative));
                    break;
                case "Завершена":
                    TripState.Source = new BitmapImage(new Uri("img/Complete.png", UriKind.Relative));
                    break;
                case "Отменена":
                    TripState.Source = new BitmapImage(new Uri("img/canceled.png", UriKind.Relative));
                    break;

            }
            em = empl;
        }

        private void СanceledBt_Click(object sender, RoutedEventArgs e)
        {
            confirmTrip ct = new confirmTrip(false, TripsNumber.Text,em);
            ct.Show();
        }

        private void CompleteBt_Click(object sender, RoutedEventArgs e)
        {
            confirmTrip ct = new confirmTrip(true, TripsNumber.Text,em);
            ct.Show();
        }

    }
}
