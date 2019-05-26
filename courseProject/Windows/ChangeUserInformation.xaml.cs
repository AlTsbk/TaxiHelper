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

namespace courseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChangeUserInformation.xaml
    /// </summary>
    public partial class ChangeUserInformation : Window
    {
        employess em;
        string userName;
        public ChangeUserInformation(employess e, string UN)
        {
            InitializeComponent();

            List<string> PositionList = new List<string>();
            PositionList.Add("Admin");
            PositionList.Add("Manager");
            PositionList.Add("Driver");
            Position.ItemsSource = PositionList;

            userName = UN;
            em = e;

            using (UserContext db = new UserContext())
            {
                User user = db.Users.Where(u => u.UserName == userName).FirstOrDefault();

                Name.Text = user.Name;
                UserName.Text = user.UserName;

                Position.SelectedValue = user.position;
            }

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addUser_Button(object sender, RoutedEventArgs e)
        {
            if ((Name.Text != "") && (UserName.Text != "") && (Position.SelectedValue != null))
            {
                using (UserContext db = new UserContext())
                {
                    User user = db.Users.Where(u => u.UserName == userName).FirstOrDefault();
                    User us = db.Users.Where(u => u.UserName == UserName.Text).FirstOrDefault();

                    if (us == null || user.UserName == userName)
                    {

                        user.Name = Name.Text;
                        user.UserName = UserName.Text;
                        if (user.password != (Password.Text).GetHashCode().ToString() && Password.Text != "")
                        {
                            user.password = (Password.Text).GetHashCode().ToString();
                        } 
                        user.position = Position.SelectedValue.ToString();
                   
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
