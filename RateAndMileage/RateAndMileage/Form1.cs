using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateAndMileage
{
    public partial class RateAndMileage : Form
    {
        List<Person> personList = new List<Person>();
        public RateAndMileage()
        {
            InitializeComponent();
            PreloadPersonList();
            Display(personList);
        }
        private void PreloadPersonList()
        {
            Person person1 = new Person("Poppy", "Zhang", "4252352352");

            //add cars to this person
            Car car1 = new Car("Toyato", "Camry", 2015, 60000, 150);
            Car car2 = new Car("Honda", "Civic", 2012, 12000, 125);
            Car car3 = new Car("Ford", "Focus", 2018, 17999, 145);
            person1.AddCar(car1);
            person1.AddCar(car2);
            person1.AddCar(car3);
            personList.Add(person1);

            Person person2 = new Person("Veronica", "Lombardi", "2531112222");
            car1 = new Car("Lexus", "GS", 2016, 8640, 265);
            car2 = new Car("BMW", "735", 2019, 60234, 285);
            car3 = new Car("Mercedes", "G-Class", 2020, 1250, 350);
            person2.AddCar(car1);
            person2.AddCar(car2);
            person2.AddCar(car3);
            personList.Add(person2);

            Person person3 = new Person("Jamie", "O'Connor", "8096728485");
            car1 = new Car("Honda", "CR-V", 2016, 86520, 135);
            car2 = new Car("Toyta", "RAV4", 2018, 58421, 175);
            person3.AddCar(car1);
            person3.AddCar(car2);
            personList.Add(person3);

            Person person4 = new Person("Ahmad", "Monir", "6238458789");
            car1 = new Car("Ford", "Mustang", 1982, 250640, 115);
            car2 = new Car("Dodge", "Durango", 2018, 35865, 145);
            person4.AddCar(car1);
            person4.AddCar(car2);
            personList.Add(person4);

            Person person5 = new Person("Cruz", "Vasquez", "5558243765");
            car1 = new Car("Honda", "Highlander", 2016, 15000, 125);
            car2 = new Car("Nissan", "Altima", 2013, 78641, 135);
            person5.AddCar(car1);
            person5.AddCar(car2);
            personList.Add(person5);


        }
        private void Display(List<Person> list)
        {
            CustomerInfoLV.Items.Clear();
            foreach (Person person in list)
            {
                //create a ListViewItem
                string[] items = { person.Firstname, person.Lastname, person.Phone };
                ListViewItem lstviewitem = new ListViewItem(items);
                CustomerInfoLV.Items.Add(lstviewitem);
            }

        }

        private void CustomerInfoLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerInfoLV.SelectedIndices.Count > 0)
            {
                int index = CustomerInfoLV.SelectedIndices[0];
                Person person = personList[index];
                Car[] cars = person.CarList;
                CarInfoLV.Items.Clear();

                foreach (Car car in cars)
                {
                    string[] items = {car.Make,car.Model,
                                      car.Year.ToString(),
                                      car.Mileage.ToString(),
                                      car.Rate.ToString("c")};
                    ListViewItem lstviewitem =
                        new ListViewItem(items);
                    CarInfoLV.Items.Add(lstviewitem);
                }
            }
        }
        private void UpdateMileageBtn_Click(object sender, EventArgs e)
        {
            //checks if a selection was made in customerInfoLV
            if (CustomerInfoLV.SelectedIndices.Count > 0)
            {
                int index = CustomerInfoLV.SelectedIndices[0];
                Person person = personList[index];
                Car[] cars = person.CarList;

                //checks if a selection was made in carInfoLV
                if (CarInfoLV.SelectedIndices.Count > 0)
                {
                    int index2 = CarInfoLV.SelectedIndices[0];
                    Car selectedCar = cars[index2];
                    int mileage;
                    int.TryParse(mileageTxtBox.Text, out mileage);
                    selectedCar.Mileage = mileage;
                    CarInfoLV.Items.Clear();

                    foreach (Car car in cars)
                    {
                        string[] items = {car.Make,car.Model,
                                      car.Year.ToString(),
                                      car.Mileage.ToString(),
                                      car.Rate.ToString("c")};
                        ListViewItem lstviewitem =
                            new ListViewItem(items);
                        CarInfoLV.Items.Add(lstviewitem);
                    }
                }
                else
                    MessageBox.Show("Please select a car.");
            }
            else
            {
                MessageBox.Show("Please select a person.");
            }
        }
        private void UpdateRateBtn_Click(object sender, EventArgs e)
        {
            if (CustomerInfoLV.SelectedIndices.Count > 0)
            {
                int index = CustomerInfoLV.SelectedIndices[0];
                Person person = personList[index];
                Car[] cars = person.CarList;

                if (CarInfoLV.SelectedIndices.Count > 0)
                {
                    int index2 = CarInfoLV.SelectedIndices[0];
                    Car selectedCar = cars[index2];
                    decimal newrate;
                    decimal.TryParse(rateTxtBox.Text, out newrate);
                    selectedCar.Rate = newrate;
                    CarInfoLV.Items.Clear();
                    foreach (Car car in cars)
                    {
                        string[] items = {car.Make,car.Model,
                                      car.Year.ToString(),
                                      car.Mileage.ToString(),
                                      car.Rate.ToString("c")};
                        ListViewItem lstviewitem =
                            new ListViewItem(items);
                        CarInfoLV.Items.Add(lstviewitem);

                    }
                }
                else
                    MessageBox.Show("Please select a car.");
            }
            else
            {
                MessageBox.Show("Please select a person.");
            }
        }

        private void RemoveCarBtn_Click(object sender, EventArgs e)
        {
            if (CustomerInfoLV.SelectedIndices.Count > 0)
            {
                int index = CustomerInfoLV.SelectedIndices[0];
                Person person = personList[index];
                Car[] cars = person.CarList;

                if (CarInfoLV.SelectedIndices.Count > 0)
                {
                    int index2 = CarInfoLV.SelectedIndices[0];
                    Car selectedCar = cars[index2];
                    person.RemoveCar(selectedCar);
                    CarInfoLV.Items.Clear();
                    cars = person.CarList;

                    foreach (Car car in cars)
                    {
                        string[] items = {car.Make,car.Model,
                                      car.Year.ToString(),
                                      car.Mileage.ToString(),
                                      car.Rate.ToString("c")};
                        ListViewItem lstviewitem =
                            new ListViewItem(items);
                        CarInfoLV.Items.Add(lstviewitem);

                    }
                }
                else
                    MessageBox.Show("Please select a car.");
            }
            else
            {
                MessageBox.Show("Please select a person.");
            }
        }

    }
}
