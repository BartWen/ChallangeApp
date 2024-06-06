using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ChallangeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid Value");
            }
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "6-":
                case "-6":
                    this.grades.Add(95);
                    break;
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-":
                case "-5":
                    this.grades.Add(75);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;
                case "1":              
                    this.grades.Add(0);
                    break;
            }



            //if (float.TryParse(grade, out float value))
            //{
            //    this.AddGrade(value);
            //}
            //else if (char.TryParse(grade, out char LetterResult))

            //    this.AddGrade(LetterResult);
            //else
            //{
            //    throw new Exception("String is not float");
            //}
        }
        public void AddGrade(char grade)
        {
            switch ((float)grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
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

            switch (statistics.Avarege)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
