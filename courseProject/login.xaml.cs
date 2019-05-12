using courseProject.Models;
using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows;
    using System.Windows.Controls;

namespace courseProject
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        string connectionString;

        
        public login()
        {
            InitializeComponent();
            //bd
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        private void SumbitButton_Click(object sender, RoutedEventArgs e)
        {

            using (UserContext db = new UserContext())
            {

                var users = db.Users;

                foreach (User u in users)
                {

                    if ((LoginBox.Text == u.UserName) && (PasswordBox.Password.GetHashCode().ToString() == u.password))
                    {
                        

                        MainWindow taskWindow = new MainWindow(u.Name, u.position);
                        taskWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        WarningMessage.Text = "Неверный логин или пароль!";
                    }

                }
            }

            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
