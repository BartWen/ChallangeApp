

namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {      
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
                      
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                
                if (GradeAdded != null) 
                    {
                        GradeAdded(this,new EventArgs());
                    }
            }
            else
            {
                throw new Exception("Invalid Value");
            }
        } //override nadpisujemy metode absctakcyjna

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else if (char.TryParse(grade, out char LetterResult))

                this.AddGrade(LetterResult);
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(char grade)
        {
            switch ((float)grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }


        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

                return statistics;
        }
    }
}
