using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> Users = new List<User>();
        List<Car> Cars = new List<Car>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void user(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string ID = userIDTextBox.Text;
            string address = addressTextBox.Text;
            string destination = destinationTextBox.Text;

            User users = new User();
            users.UserName = name;
            users.UserID = ID;
            users.Address = address;
            users.Destination = destination;


            Users.Add(users);
            MessageBox.Show("User Information Saved!");

        }

        private void car(object sender, EventArgs e)
        {
            string name = carNameTextBox.Text;
            string model = carIDTextBox.Text;
            int NumberOfCars = Convert.ToInt32(quantityTextBox.Text);

            Car Car = new Car();
            Car.CarName = name;
            Car.Model = model;
            Car.number_of_cars = NumberOfCars;

            Cars.Add(Car);
            MessageBox.Show("Car Information Saved!");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
