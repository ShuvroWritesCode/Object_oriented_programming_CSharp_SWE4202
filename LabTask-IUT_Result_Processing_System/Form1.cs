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

namespace IUTResultProcessingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> studentList = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"\\Mac\Home\Desktop\IUTResultProcessingSystem\SWE4201MarkSheet.csv"))
            {


                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student dummy = new Student();

                    dummy.ID = values[0];
                    dummy.name = values[1];
                    dummy.attendance = Convert.ToInt32(values[2]);
                    dummy.quiz1 = Convert.ToInt32(values[3]);
                    dummy.quiz2 = Convert.ToInt32(values[4]);
                    dummy.quiz3 = Convert.ToInt32(values[5]);
                    dummy.quiz4 = Convert.ToInt32(values[6]);
                    dummy.mid = Convert.ToInt32(values[7]);
                    dummy.final = Convert.ToInt32(values[8]);
                    dummy.viva = Convert.ToInt32(values[9]);
                    dummy.calculateQuizTotal();
                    dummy.calculateTotal();
                    dummy.calculatePercentage();
                    dummy.calculateGrade();

                    studentList.Add(dummy);
                }


            }
            var List = from student in studentList
                       select student;
            foreach(var any in List)
            {
                listBox1.Items.Add(any.ID +"\t" + any.name + "\t" + any.percentage +"%\t"+   any.grade.PadLeft(20));
            }
            
        }

        private void searchByIDButton_Click(object sender, EventArgs e)
        {
            string ID = searchIDTextBox.Text;
            
        var showList = from student in studentList
                       where student.ID == ID
                       select student;

            foreach(Student student1 in showList)
            {
                attendanceLabel.Text = Convert.ToString("Attendance:\t" + student1.attendance);
                quiz1Label.Text = Convert.ToString("Quiz 1:\t" + student1.quiz1);
                quiz2Label.Text = Convert.ToString("Quiz 2:\t" + student1.quiz2);
                quiz3Label.Text = Convert.ToString("Quiz 3:\t" + student1.quiz3);
                quiz4Label.Text = Convert.ToString("Quiz 4:\t" + student1.quiz4);
                quizTotalLabel.Text= Convert.ToString("Quiz Total(Best 3):\t" + student1.quiz_Total);
                midLabel.Text = Convert.ToString("Mid:\t" + student1.mid);
                finalLabel.Text = Convert.ToString("Final:\t" + student1.final);
                vivaLabel.Text = Convert.ToString("Viva:\t" + student1.viva);
                totalLabel.Text = Convert.ToString("Total (Out of 300):\t" + student1.total);
                percentageLabel.Text = Convert.ToString("Percentage:\t" + student1.percentage +"%");
                gradeLabel.Text = Convert.ToString("Grade:\t" + student1.grade);
            }
        }
    }
}
