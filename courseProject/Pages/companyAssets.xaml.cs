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
    /// Логика взаимодействия для companyAssets.xaml
    /// </summary>
    public partial class companyAssets : UserControl
    {
        public companyAssets()
        {
            InitializeComponent();

            FirstUnderLine.Background = Brushes.Yellow;
            EmployeesList.Visibility = Visibility.Hidden;
            UpdateEmployee();
            UpdateCar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstUnderLine.Background = Brushes.Yellow;
            SecondUnderLine.Background = Brushes.White;
            CarsList.Visibility = Visibility.Visible;
            EmployeesList.Visibility = Visibility.Hidden;
            UpdateCar();

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondUnderLine.Background = Brushes.Yellow;
            FirstUnderLine.Background = Brushes.White;
            EmployeesList.Visibility = Visibility.Visible;
            CarsList.Visibility = Visibility.Hidden;
            UpdateEmployee();
        }

        public void UpdateEmployee()
        {
            EmployeesContent.Children.Clear();
            using (UserContext db = new UserContext())
            {

                var users = db.Users.Where(t => t.position == "Driver");

                foreach (User u in users)
                {
                    userRow ur = new userRow(u.Name, u.position, u.state);
                    EmployeesContent.Children.Add(ur);
                }
            }
        }

        public void UpdateCar()
        {
            CarContent.Children.Clear();
            using (CarContext db = new CarContext())
            {
                var cars = db.Cars;

                foreach (Car c in cars)
                {
                    carRow cr = new carRow(c.CarName, c.CarNumber, c.YearOfIssue, c.State, c.CarLevel);
                    CarContent.Children.Add(cr);
                    cr.DeleteBt.Visibility = Visibility.Hidden;
                    cr.InfoBt.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
