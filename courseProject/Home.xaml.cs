using courseProject.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        string connectionString;
        public Home()
        {
            InitializeComponent();
            //ContentField.Children.Add(register);
            FirstUnderLine.Background = Brushes.Yellow;
            EmployeesList.Visibility = Visibility.Hidden;

            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirstUnderLine.Background = Brushes.Yellow;
            SecondUnderLine.Background = Brushes.White;
            CurrentTripsList.Visibility = Visibility.Visible;
            EmployeesList.Visibility = Visibility.Hidden;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SecondUnderLine.Background = Brushes.Yellow;
            FirstUnderLine.Background = Brushes.White;
            EmployeesList.Visibility = Visibility.Visible;
            CurrentTripsList.Visibility = Visibility.Hidden;
            UpdateContent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateContent();
        }
        public void UpdateContent()
        {
            Content.Children.Clear();
            using (UserContext db = new UserContext())
            {

                var users = db.Users.OrderBy(u => u.position);

                foreach (User u in users)
                {
                    userRow ur = new userRow(u.Name, u.position, u.state);
                    Content.Children.Add(ur);
                }
            }
        }
    }
}
