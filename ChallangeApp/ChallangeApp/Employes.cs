
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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }           
        }
        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.grades.Add(value);
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
    }

}







