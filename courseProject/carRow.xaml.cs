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
    /// Логика взаимодействия для carRow.xaml
    /// </summary>
    public partial class carRow : UserControl
    {
        employess em;
        public carRow(string carName, string carNumber, string yearOfIssue, string carState,string carLevel, employess e)
        {
            InitializeComponent();

            CarName.Text = carName;
            CarNumber.Text = carNumber;
            YearOfIssue.Text = yearOfIssue;
            CarState.Text = carState;

            switch (carState)
            {
                case "Свободна":
                    CarState.Foreground = Brushes.ForestGreen;
                    break;
                case "Занята":
                    CarState.Foreground = Brushes.DarkRed;
                    break;
            }

            switch (carLevel)
            {
                case "Премиум":
                    CarLevel.Source = new BitmapImage(new Uri("img/Premium.png", UriKind.Relative));
                    break;
                case "Средний":
                    CarLevel.Source = new BitmapImage(new Uri("img/Average.png", UriKind.Relative));
                    break;
                case "Эконом":
                    CarLevel.Source = new BitmapImage(new Uri("img/Econom.png", UriKind.Relative));
                    break;
            }
            em = e;

        }

        private void DeleteBt_Click(object sender, RoutedEventArgs e)
        {
            DeleteCar dc = new DeleteCar(CarNumber.Text, em);
            dc.Show();
            
        }
    }
}
