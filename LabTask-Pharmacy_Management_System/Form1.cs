using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Dependencies;

namespace PharmacyManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Medicine> Medicines = new List<Medicine>();
        List<User> Users = new List<User>();
            
        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            string name = medicineNameTextBox.Text;
            string ID = medicineIDTextBox.Text;
            int quantity = Convert.ToInt32(medicineQuantityTextBox.Text);
            int price = Convert.ToInt32(medicinePriceTextBox.Text);
            string userID = userIDTextBox.Text;

            Medicine medicine = new Medicine();
            medicine.name = name;
            medicine.ID = ID;
            medicine.quantity = quantity;
            medicine.price = price;

            Medicines.Add(medicine);

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string userID = userIDTextBox.Text;
            int balance = Convert.ToInt32(initialBalanceTextBox.Text);

            User user = new User();
            user.ID = userID;
            user.balance = balance;

            Users.Add(user);
        }

        private void sellMedicineButton_Click(object sender, EventArgs e)
        {
            string id = sellMedicineIDTextBox.Text;
            int quantity = Convert.ToInt32(sellMedicineQuantityTextBox.Text);
            string userID = textBox1.Text ;

            for(int i = 0; i < Medicines.Count; i++)
            {
                if(id == Medicines[i].ID)
                {
                    if(quantity<= Medicines[i].quantity)
                    {
                        Medicines[i].sellMedicine(quantity);
                        int price = Medicines[i].price;

                        for (int j = 0; j < Users.Count; j++)
                        {
                            if (userID == Users[j].ID)
                            {
                                Users[j].addBalance(quantity, price);
                            }
                        }
                    }
                }
            }
            
        }

        private void checkMedicineStockButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = checkMedicineNameTextbox.Text;

            for(int i = 0; i < Medicines.Count; i++)
            {
                if(name == Medicines[i].name)
                {
                    listBox1.Items.Add(Medicines[i].getInfo());
                }
            }
        }

        private void checkAccBalance_Click(object sender, EventArgs e)
        {
            string id = checkUserIDTextBox.Text;

            for(int i = 0; i < Users.Count; i++)
            {
                if (id == Users[i].ID)
                {
                    showBalanceLabel.Text = Users[i].getBalance();
                }
            }
        }
    }
}
