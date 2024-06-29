using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);       
       
        public abstract void AddGrade(char grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
        

        //public virtual void AddGrade(float grade); Metoda virtualna musi mieć ciało i można ją nadpisać 

    }
}
