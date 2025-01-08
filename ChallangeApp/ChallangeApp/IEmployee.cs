

namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get;}
        string Surname { get;}
       
        public void AddGrade(float grade);
        public void AddGrade(string grade);
        public void AddGrade(char grade);
        public void AddGrade(int grade);
        public void AddGrade(double grade);
        Statistics GetStatistics();
       
    }
}
