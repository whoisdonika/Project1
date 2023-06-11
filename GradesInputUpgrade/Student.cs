using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesInputUpgrade
{
    internal class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private double belGrade;

        public double BelGrade
        {
            get { return belGrade; }
            set { belGrade = value; }
        }

        private double mathsGrade;

        public double MathsGrade
        {
            get { return mathsGrade; }
            set { mathsGrade = value; }
        }

        private double historyGrade;

        public double HistoryGrade
        {
            get { return historyGrade; }
            set { historyGrade = value; }
        }

        public Student(string name, string surname, double belGrade, double historyGrade, double mathsGrade)
        {
            this.Name = name;
            this.Surname = surname;
            this.BelGrade = belGrade;
            this.MathsGrade = mathsGrade;
            this.HistoryGrade = historyGrade;
        }

        public double GetAverageGrade()
        {
            return (BelGrade + HistoryGrade + MathsGrade) / 3;
        }
    }
}
