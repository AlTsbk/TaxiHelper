using courseProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для employess.xaml
    /// </summary>
    public partial class employess : UserControl
    {
        

        public employess()
        {
            InitializeComponent();
            FirstUnderLine.Background = Brushes.Yellow;


        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstUnderLine.Background = Brushes.Yellow;
            SecondUnderLine.Background = Brushes.White;
            carsList.Visibility = Visibility.Hidden;
            employeesList.Visibility = Visibility.Visible;

            EmployeeListUpdate();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondUnderLine.Background = Brushes.Yellow;
            FirstUnderLine.Background = Brushes.White;
            employeesList.Visibility = Visibility.Hidden;
            carsList.Visibility = Visibility.Visible;

            CarsListUpdate();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {


            EmployeeListUpdate();

            CarsListUpdate();

        }

        private void addCar_Button(object sender, RoutedEventArgs e)
        {
            addCar addCar = new addCar(this);
            addCar.Show();


        }

        private void addEmployee_Button(object sender, RoutedEventArgs e)
        {
            addEmployee addEmployee = new addEmployee(this);
            addEmployee.Show();
        }

        public void CarsListUpdate()
        {
            carsListPanel.Children.Clear();
            using (CarContext db = new CarContext())
            {
                var cars = db.Cars;

                foreach (Car c in cars)
                {
                    carRow cr = new carRow(c.CarName, c.CarNumber, c.YearOfIssue, c.State, c.CarLevel, this);
                    carsListPanel.Children.Add(cr);
                }
            }
        }

        public void EmployeeListUpdate()
        {
            employeesListPanel.Children.Clear();

            using (UserContext db = new UserContext())
            {
                var users = db.Users;

                foreach (User u in users)
                {
                    userRowForAdmin userRowForAdmin = new userRowForAdmin(u.Name, u.position, u.UserName, this);
                    employeesListPanel.Children.Add(userRowForAdmin);
                    
                }
            }
        }
    }
}
