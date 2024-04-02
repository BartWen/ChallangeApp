
using System.Diagnostics;

namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string name { get; private set; }
        public string surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(int grade)
        {           
            this.AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {           
            this.AddGrade((float)grade);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avarege = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);

                statistics.Avarege += grade;
            }

            statistics.Avarege /= this.grades.Count();

            return statistics;
        }
        public Statistics GetStatisticswuthFor()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avarege = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);

                statistics.Avarege += grades[i];
            }
            
            statistics.Avarege /= this.grades.Count();

            return statistics;
        }
        public Statistics GetStatisticswuthDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avarege = 0;
            var lineCount = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[lineCount]);
                statistics.Min = Math.Min(statistics.Min, this.grades[lineCount]);

                statistics.Avarege += this.grades[lineCount];
                lineCount++;
            }
            while (lineCount < this.grades.Count);
                     
            statistics.Avarege /= this.grades.Count();

            return statistics;
        }
        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avarege = 0;
            var lineCount = 0;

            while (lineCount<this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[lineCount]);
                statistics.Min = Math.Min(statistics.Min, grades[lineCount]);

                statistics.Avarege += grades[lineCount];
                lineCount++;
            }

            statistics.Avarege /= this.grades.Count();

            return statistics;
        }
    }


}







