using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTResultProcessingSystem
{
    public class Student
    {
        public string ID, name, grade;
        public int attendance, quiz1, quiz2, quiz3, quiz4, quiz_Total, mid, final, viva, total;
        public double percentage;


        public void calculateQuizTotal()
        {
            if (quiz1 < quiz2 && quiz1 < quiz3 && quiz1 < quiz4)
            {
                this.quiz_Total = quiz2 + quiz3 + quiz4;
            }
            else if (quiz2 < quiz1 && quiz2 < quiz3 && quiz2 < quiz4)
            {
                this.quiz_Total = quiz1 + quiz3 + quiz4;
            }
            else if (quiz3 < quiz1 && quiz3 < quiz2 && quiz1 < quiz4)
            {
                this.quiz_Total = quiz2 + quiz1 + quiz4;
            }
            else if (quiz4 < quiz1 && quiz4 < quiz2 && quiz4 < quiz3)
            {
                this.quiz_Total = quiz2 + quiz3 + quiz1;
            }
            else
            {
                this.quiz_Total = quiz1 + quiz4 + quiz2;
            }
        }
        public void calculateTotal()
        {
            this.total = attendance + quiz_Total + mid + final + viva;
        }
        public void calculatePercentage()
        {
            this.percentage = Math.Round(((double)total*100 / 300),2);
        }
        public void calculateGrade()
        {
            if (percentage >= 80)
            {
                this.grade = "A+";
            }
            else if (percentage >= 75 && percentage < 80)
            {
                this.grade = "A";
            }
            else if (percentage >= 70 && percentage < 75)
            {
                this.grade = "A-";
            }
            else if (percentage >= 65 && percentage < 70)
            {
                this.grade = "B+";
            }
            else if (percentage >= 60 && percentage < 65)
            {
                this.grade = "B";
            }
            else if (percentage >= 55 && percentage < 60)
            {
                this.grade = "B-";
            }
            else if (percentage >= 50 && percentage < 55)
            {
                this.grade = "C+";
            }
            else if (percentage >= 45 && percentage < 50)
            {
                this.grade = "C";
            }
            else if (percentage >= 40 && percentage < 45)
            {
                this.grade = "D";
            }
            else if (percentage >= 0 && percentage < 40)
            {
                this.grade = "F";
            }
        }
    }
}
