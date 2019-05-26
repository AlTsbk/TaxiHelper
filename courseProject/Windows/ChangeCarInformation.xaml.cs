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
    /// Логика взаимодействия для ChangeCarInformation.xaml
    /// </summary>
    public partial class ChangeCarInformation : Window
    {
        employess em;
        string numberCar;
        public ChangeCarInformation(employess e, string Number)
        {
            InitializeComponent();

            List<string> CarLevelList = new List<string>();
            CarLevelList.Add("Премиум");
            CarLevelList.Add("Средний");
            CarLevelList.Add("Эконом");
            CarLevel.ItemsSource = CarLevelList;

            numberCar = Number;
            

            using (CarContext db = new CarContext())
            {
                Car car = db.Cars.Where(c => c.CarNumber == numberCar).FirstOrDefault();
                if(car != null)
                {
                    CarModel.Text = car.CarName;
                    CarNumber.Text = car.CarNumber;
                    YearOfIssue.Text = car.YearOfIssue;

                    CarLevel.SelectedValue = car.CarLevel;
                }
                
            }

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
                    Car car = db.Cars.Where(c => c.CarNumber == numberCar).FirstOrDefault();

                    Car cr = db.Cars.Where(c => c.CarNumber == CarNumber.Text).FirstOrDefault();

                    if (CarNumber.Text.Length < 8)
                    {
                        WarnngMessage.Text = "Неверный формат номера!";
                    }
                    else if (cr == null || cr.CarNumber == numberCar)
                    {

                        car.CarName = CarModel.Text;
                        car.CarNumber = CarNumber.Text;
                        car.YearOfIssue = YearOfIssue.Text;
                     
                        car.CarLevel = CarLevel.SelectedValue.ToString();

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
