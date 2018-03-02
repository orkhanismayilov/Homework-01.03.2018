using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Name = "Murad";
            std1.Surname = "Jafarov";
            std1.AddScore(45.2);
            std1.AddScore(55.3);
            std1.AddScore(78);
            std1.AddScore(98);
            std1.AddScore(77);
            Console.WriteLine("Student: " + std1.Name +" "+ std1.Surname);
            Console.WriteLine("Gross Point Average: " + std1.gpa);
            Console.WriteLine("Minimum Point: " + std1.minscore);
            Console.WriteLine("Maximum Point: " + std1.maxscore);
            
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private double GPA { get; set; }
        private double MinScore { get; set; }
        private double MaxScore { get; set; }
        double[] results = new double[] { };

        public double gpa
        {
            get
            {
                this.GPACalc();
                return this.GPA;
            }
        }

        public double minscore
        {
            get
            {
                this.MinPoint();
                return this.MinScore;
            }
        }

        public double maxscore
        {
            get
            {
                this.MaxPoint();
                return this.MaxScore;
            }
        }

        public void AddScore(double ExamScore)
        {
            Array.Resize(ref results, results.Length + 1);
            results[results.Length - 1] = ExamScore;
        }

        private void GPACalc()
        {
            double total = 0;
            for(int i = 0; i < results.Length; i++)
            {
                total += results[i];
            }
            this.GPA = total / results.Length;
        }

        private void MinPoint()
        {
            this.MinScore = this.results.Min();
        }

        private void MaxPoint()
        {
            this.MaxScore = this.results.Max();
        }
    }
}
