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
    /// Логика взаимодействия для userRow.xaml
    /// </summary>
    public partial class userRow : UserControl
    {
        public userRow(string name, string position,string state)
        {
            InitializeComponent();
            Position.Text = position;
            Name.Text = name;

            if (state == "Свободен")
            {
                UserState.Foreground = Brushes.Green;
            }
            else
            {
                UserState.Foreground = Brushes.Red;
            }

            {

            }
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
                    UserState.Text = state;
                    UserState.Visibility = Visibility.Visible;
                    UserImage.Source = new BitmapImage(new Uri("img/Driver-Photo.png", UriKind.Relative));
                    break;
            }

            

        }
    }
}
