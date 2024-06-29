
namespace ChallangeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        { 
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid Value");
            }
          
        }

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
            var result = new Statistics();
            

            result.Max = float.MinValue;
            result.Min = float.MaxValue;
            result.Avarege = 0;
            var counter = 0;

            if (File.Exists(fileName))
            {

                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Avarege += number;
                        counter ++;
                        line= reader.ReadLine();
                    }
                }
                result.Avarege /= counter;

                switch (result.Avarege)
                {
                    case var average when average >= 80:
                        result.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = 'D';
                        break;
                    default:
                        result.AverageLetter = 'E';
                        break;
                }
            }

            return result;
        }
    }
}
