using courseProject.Models;
using courseProject.Windows;
using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
using System.Linq;
using System.Windows;
    using System.Windows.Controls;

namespace courseProject
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {

        
        public login()
        {
            InitializeComponent();
            
            
        }

        private void SumbitButton_Click(object sender, RoutedEventArgs e)
        {

            using (UserContext db = new UserContext())
            {
                var users = db.Users;

                if (users.Count() == 0)
                {
                    User u = new User();
                    u.Name = "admin";
                    u.password = "admin".GetHashCode().ToString();
                    u.position = "Admin";
                    u.state = "Свободен";
                    u.UserName = "admin";

                    db.Users.Add(u);
                    db.SaveChanges();
                }

                User user = db.Users.Where(u => u.UserName == LoginBox.Text).FirstOrDefault();
                if (user != null && user.password == PasswordBox.Password.GetHashCode().ToString())
                {
                    MainWindow taskWindow = new MainWindow(user.Name, user.position);
                    taskWindow.Show();
                    this.Close();
                }
                else
                {
                    WarningMessage.Text = "Неверный логин или пароль!";
                }
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
