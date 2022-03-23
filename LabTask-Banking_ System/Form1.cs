using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking_System_Dependencies;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Current_Account> current_Accounts = new List<Current_Account>();   
        List<Savings_Account> savings_Accounts = new List<Savings_Account>();
        List <Loan_Account> loan_Accounts = new List<Loan_Account>();

        public int i;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;
            int amount = Convert.ToInt32(textBox10.Text);
            string type = comboBox1.Text;

            if(type == "Current Account")
            {
                if (amount >= 0)
                {
                    Current_Account current = new Current_Account(amount);
                    current.Acc_name = name;
                    current.Acc_no = Convert.ToString(i) + "-300";
                    MessageBox.Show("Your Account Number is " + i + "-300");
                    current_Accounts.Add(current);
                }
                else
                {
                    MessageBox.Show("Minimum Balance not satisfied!");
                }
            }
            else if (type == "Savings Account")
            {
                if (amount >= 50000)
                {
                    Savings_Account savings = new Savings_Account(amount);
                    savings.Acc_name = name;
                    savings.Acc_no = Convert.ToString(i) + "-314";
                    MessageBox.Show("Your Account Number is " + i + "-314");
                    savings_Accounts.Add(savings);
                }
                else
                {
                    MessageBox.Show("Minimum Balance not satisfied!");
                }
            }
            else if (type == "Loan Account")
            {
                Loan_Account loan = new Loan_Account(amount);
                loan.Acc_name = name;   
                loan.Acc_no = Convert.ToString(i) + "-400";
                MessageBox.Show("Your Account Number is " + i + "-400");
                loan_Accounts.Add(loan);
            }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acc_no = textBox1.Text;
            int amount = Convert.ToInt32(textBox2.Text);
            string date = textBox8.Text;

            if (amount >= 0)
            {
                for (int j = 0; j < current_Accounts.Count; j++)
                {
                    if (current_Accounts[j].Acc_no == acc_no)
                    {
                        if (amount >= 100000)
                        {
                            current_Accounts[j].depositAmount(amount, date);
                            MessageBox.Show("Amount Depositted!");
                        }
                        
                        else 
                        {
                            MessageBox.Show("Minimum Transaction Amount not met!");
                        }
                    }
                }
                for (int j = 0; j < savings_Accounts.Count; j++)
                {
                    if (savings_Accounts[j].Acc_no == acc_no)
                    {
                        savings_Accounts[j].depositAmount(amount, date);
                        MessageBox.Show("Amount Depositted!");
                    }
                }
                for (int j = 0; j < loan_Accounts.Count; j++)
                {
                    if (loan_Accounts[j].Acc_no == acc_no)
                    {
                        loan_Accounts[j].depositAmount(amount, date);
                        MessageBox.Show("Amount Depositted!");
                    }
                }
                MessageBox.Show("Amount Depositted!");
            }
            else
            {
                    throw new ApplicationException("Negative number can't be deposited!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string acc_no = textBox3.Text;
            int amount = Convert.ToInt32(textBox4.Text);
            string date = textBox9.Text;

            if(amount >= 0) { 
            for (int j = 0; j < current_Accounts.Count; j++)
            {
                    if (current_Accounts[j].Acc_no == acc_no)
                    {
                        if(amount >= 100000) { 
                        current_Accounts[j].withdrawAmount(amount, date);
                            MessageBox.Show("Amount Withdrawn!");
                        }
                    else
                    {
                        MessageBox.Show("Minimum Transaction Amount not met!");
                    }
                    }

            }
            for (int j = 0; j < savings_Accounts.Count; j++)
            {
                if (savings_Accounts[j].Acc_no == acc_no)
                {
                    savings_Accounts[j].withdrawAmount(amount, date);
                        MessageBox.Show("Amount Withdrawn!");
                    }
            }
            for (int j = 0; j < loan_Accounts.Count; j++)
            {
                if (loan_Accounts[j].Acc_no == acc_no)
                {
                    loan_Accounts[j].withdrawAmount(amount, date);
                        MessageBox.Show("Amount Withdrawn!");
                    }
            }
            
        }
            else
            {
                throw new ApplicationException("Negative number can't be withdrawn!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string acc_no = textBox6.Text;

            listBox1.Items.Clear();
            listBox1.Items.Add("Account Name \t Amount"); 
            for (int j = 0; j < current_Accounts.Count; j++)
            {
                if (current_Accounts[j].Acc_no == acc_no)
                {
                    listBox1.Items.Add(current_Accounts[j].getAccountDetails());
                }
            }
            for (int j = 0; j < savings_Accounts.Count; j++)
            {
                if (savings_Accounts[j].Acc_no == acc_no)
                {
                    listBox1.Items.Add(savings_Accounts[j].getAccountDetails());
                }
            }
            for (int j = 0; j < loan_Accounts.Count; j++)
            {
                if (loan_Accounts[j].Acc_no == acc_no)
                {
                    listBox1.Items.Add(loan_Accounts[j].getAccountDetails());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string acc_no = textBox7.Text;

            listBox2.Items.Clear();
            listBox2.Items.Add("Transaction History");

            for (int j = 0; j < current_Accounts.Count; j++)
            {
                if (current_Accounts[j].Acc_no == acc_no)
                {
                    listBox2.Items.Add(current_Accounts[j].transHis());
                }
            }
            for (int j = 0; j < savings_Accounts.Count; j++)
            {
                if (savings_Accounts[j].Acc_no == acc_no)
                {
                    listBox2.Items.Add(savings_Accounts[j].transHis());
                }
            }
            for (int j = 0; j < loan_Accounts.Count; j++)
            {
                if (loan_Accounts[j].Acc_no == acc_no)
                {
                    listBox2.Items.Add(loan_Accounts[j].transHis());
                }
            }
        }
    }
}
