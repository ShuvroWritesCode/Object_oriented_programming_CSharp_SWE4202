using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileHandling
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           
             DateTime clickTime = DateTime.Now;
            string ID = searchIDTextBox.Text;

                for (int i = 0; i < empList.Count; i++)
                {
                    if (empList[i].ID == ID)
                    {
                        nameLabel.Text = empList[i].Name;
                        IDLabel.Text = empList[i].ID;
                        hireDateLabel.Text = empList[i].HireDate;
                        salaryLabel.Text = empList[i].Salary;

                    string path = @"C:\Users\ASUS\Desktop\OOC lab\FileHandling\File.txt";
             
                            File.AppendAllText(path,empList[i].ID+" "+empList[i].Name+" "+empList[i].HireDate+" "+empList[i].Salary+" " + clickTime +"\n");
     
                    }
                }
                if(IDLabel.Text != ID)
            {
                MessageBox.Show("Employee not found!");
            }
            
        }

        List<Employee> empList = new List<Employee>();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\ASUS\Desktop\OOC lab\FileHandling\employees.csv"))
            {
                

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Employee emp = new Employee();

                    emp.ID = values[0];
                    emp.Name = values[1];
                    emp.HireDate = values[5];
                    emp.Salary = values[7];

                    empList.Add(emp);
                }

                for(int i = 0; i < empList.Count; i++)
                {
                    EmployeeID.Items.Add(empList[i].ID);
                    NameListBox.Items.Add(empList[i].Name);
                }
            }
        }
    }
}
