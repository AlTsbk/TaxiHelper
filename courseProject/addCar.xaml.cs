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
    /// Логика взаимодействия для addCar.xaml
    /// </summary>
    public partial class addCar : Window
    {
        employess em;
        public addCar(employess e)
        {
            InitializeComponent();

            List<string> CarLevelList = new List<string>();
            CarLevelList.Add("Премиум");
            CarLevelList.Add("Средний");
            CarLevelList.Add("Эконом");
            CarLevel.ItemsSource = CarLevelList;

            em = e;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addCar_Button(object sender, RoutedEventArgs e)
        {

            if ((CarModel.Text != "") && (CarNumber.Text != "") && (YearOfIssue.Text != ""))
            {
                using (CarContext db = new CarContext())
                {
                    Car cr = db.Cars.Where(c => c.CarNumber == CarNumber.Text).FirstOrDefault();

                    if (cr == null)
                    {
                        Car car = new Car();
                        car.CarName = CarModel.Text;
                        car.CarNumber = CarNumber.Text;
                        car.YearOfIssue = YearOfIssue.Text;
                        car.State = "Свободна";
                        car.CarLevel = CarLevel.SelectedValue.ToString();

                        db.Cars.Add(car);
                        db.SaveChanges();

                        this.Close();
                        em.CarsListUpdate();
                    }
                    else
                    {
                        WarnngMessage.Text = "Этот номер уже есть!";
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
