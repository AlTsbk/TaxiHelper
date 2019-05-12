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
        public tripRow(string tripsId, string fromWhere, string destination, string driver, string date)
        {
            InitializeComponent();

            TripsNumber.Text = tripsId;
            From.Text = fromWhere;
            Destination.Text = destination;
            Driver.Text = driver;
            Date.Text = date;
            

        }

        private void DeleteBt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
