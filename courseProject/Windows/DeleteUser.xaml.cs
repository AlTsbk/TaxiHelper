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
using System.Windows.Shapes;

namespace courseProject
{
    /// <summary>
    /// Логика взаимодействия для DeleteUser.xaml
    /// </summary>
    public partial class DeleteUser : Window
    {
        employess em;
        public DeleteUser(string name, employess e)
        {
            InitializeComponent();
            UserRow.Text = name;
            em = e;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YesBt_Click(object sender, RoutedEventArgs e)
        {
            
            using(UserContext db = new UserContext())
            {
                User user = db.Users.Where(u => u.UserName == UserRow.Text).FirstOrDefault();
                
                if(user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                
            }
            em.EmployeeListUpdate();
            this.Close();
        }

        private void NoBt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
