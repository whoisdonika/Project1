using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesInputUpgrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students would you like to add? - ");
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            Console.WriteLine("Enter the students' info : ");

            List<double> belGrades = new List<double>();
            List<double> mathsGrades = new List<double>();
            List<double> historyGrades = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Student {i} : ");
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Surname : ");
                string surname = Console.ReadLine();
                Console.Write("Bulgarian grade : ");
                double belGrade = double.Parse(Console.ReadLine());
                if (belGrade < 2 || belGrade > 6)
                {
                    Console.Write("Invalid value for the grade! Try again : ");
                    belGrade = double.Parse(Console.ReadLine());
                }
                else
                {
                    belGrades.Add(belGrade);
                }
                Console.Write("Maths grade : ");
                double mathsGrade = double.Parse(Console.ReadLine());
                if (mathsGrade < 2 || mathsGrade > 6)
                {
                    Console.Write("Invalid value for the grade! Try again : ");
                    mathsGrade = double.Parse(Console.ReadLine());
                }
                else
                {
                    mathsGrades.Add(mathsGrade);
                }
                Console.Write("History grade : ");
                double historyGrade = double.Parse(Console.ReadLine());
                if (historyGrade < 2 || historyGrade > 6)
                {
                    Console.Write("Invalid value for the grade! Try again : ");
                    historyGrade = double.Parse(Console.ReadLine());
                }
                else
                {
                    historyGrades.Add(historyGrade);
                }

                Student student = new Student(name, surname, belGrade, historyGrade, mathsGrade);
                students.Add(student);

                Console.WriteLine();

            }

            double belAvg = belGrades.Sum() / belGrades.Count();
            double mathsAvg = mathsGrades.Sum() / mathsGrades.Count();
            double historyAvg = historyGrades.Sum() / historyGrades.Count();

            Console.WriteLine($"Bulgarian average : {belAvg}");
            Console.WriteLine($"Maths average : {mathsAvg}");
            Console.WriteLine($"History average : {historyAvg}");

            var highestAverage = students.OrderByDescending(s => s.GetAverageGrade()).First();
            var lowestAverage = students.OrderBy(s => s.GetAverageGrade()).First();

            Console.WriteLine("Highest average :");
            Console.WriteLine($"{highestAverage.Name} {highestAverage.Surname} - {highestAverage.GetAverageGrade():F2}");

            Console.WriteLine("Lowest  average :");
            Console.WriteLine($"{lowestAverage.Name} {lowestAverage.Surname} - {lowestAverage.GetAverageGrade():F2}");
        }
    }
}

       

        
    

