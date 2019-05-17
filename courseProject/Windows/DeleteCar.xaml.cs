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
    /// Логика взаимодействия для DeleteCar.xaml
    /// </summary>
    public partial class DeleteCar : Window
    {

        employess em;
        public DeleteCar(string carNumber, employess e)
        {
            InitializeComponent();
            CarRow.Text = carNumber;
            em = e;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YesBt_Click(object sender, RoutedEventArgs e)
        {

           
            using (CarContext db = new CarContext())
            {
                Car car = db.Cars.Where(c => c.CarNumber == CarRow.Text).FirstOrDefault();

                if(car != null)
                {
                    db.Cars.Remove(car);
                    db.SaveChanges();
                }

            }
            em.CarsListUpdate();
            this.Close();
        }

        private void NoBt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
