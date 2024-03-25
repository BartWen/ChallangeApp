
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
            this.grades.Add(grade);
        }
        public Statistics GetStatistics2()
        {
            var statistics = new Statistics();

            statistics.Max = this.grades.Max();
            statistics.Min = this.grades.Min();
            statistics.Avarege = this.grades.Average();

            return statistics;
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
                statistics.Min = Math.Min(statistics.Max, grade);

                statistics.Avarege += grade;
            }

            statistics.Avarege/=this.grades.Count();

            return statistics;

        }
    }

}







