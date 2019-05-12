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
    /// Логика взаимодействия для userRowForAdmin.xaml
    /// </summary>
    public partial class userRowForAdmin : UserControl
    {
        employess em;
        public userRowForAdmin(string name, string position, string userName, employess e)
        {
            InitializeComponent();
            Name.Text = name;
            Position.Text = position;
            Login.Text = userName;

            switch (position)
            {
                case "Admin":
                    UserImage.Source = new BitmapImage(new Uri("img/Admin-Photo.png", UriKind.Relative));
                    break;
                case "Manager":
                    UserImage.Source = new BitmapImage(new Uri("img/Manager-Photo.png", UriKind.Relative));
                    break;
                case "Driver":
                    DeleteBt.Visibility = Visibility.Visible;
                    UserImage.Source = new BitmapImage(new Uri("img/Driver-Photo.png", UriKind.Relative));
                    break;
            }
            em = e;
        }

        private void DeleteBt_Click(object sender, RoutedEventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser(Login.Text, em);
            deleteUser.Show();
        }
    }
}
