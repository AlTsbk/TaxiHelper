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
    /// Логика взаимодействия для addEmployee.xaml
    /// </summary>
    public partial class addEmployee : Window
    {
        employess em;
        public addEmployee(employess e)
        {
            InitializeComponent();

            List<string> PositionList = new List<string>();
            PositionList.Add("Admin");
            PositionList.Add("Manager");
            PositionList.Add("Driver");
            Position.ItemsSource = PositionList;

            em = e;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addUser_Button(object sender, RoutedEventArgs e)
        {
            if ((Name.Text != "") && (UserName.Text != "") && (Password.Text != "") && (Position.SelectedValue != null))
            {
                using (UserContext db = new UserContext())
                {
                    User us = db.Users.Where(u => u.UserName == UserName.Text).FirstOrDefault();

                    if (us == null)
                    {
                        User user = new User();
                        user.Name = Name.Text;
                        user.UserName = UserName.Text;
                        user.password = (Password.Text).GetHashCode().ToString();
                        user.position = Position.SelectedValue.ToString();
                        user.state = "Свободен";

                        db.Users.Add(user);
                        db.SaveChanges();

                        em.EmployeeListUpdate();
                        this.Close();
                    }
                    else
                    {
                        WarnngMessage.Text = "Этот логин уже занят!";
                    }
                    

                }
                
            }
            else
            {
                WarnngMessage.Text = "Заполните все поля!";
            }
            
        }
    }
}
