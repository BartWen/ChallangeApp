

namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
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
            else if (char.TryParse(grade, out char LetterResult))

                this.AddGrade(LetterResult);

            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(char grade)
        {
            switch ((float)grade)              
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case'B':
                case'b':
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
                    this.grades.Add(0);
                    break;
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







