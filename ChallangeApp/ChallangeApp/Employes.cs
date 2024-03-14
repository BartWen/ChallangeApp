

using System.Numerics;
using System.Xml.Schema;

namespace ChallangeApp
{
    class Employee
    {
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        private List<int> scores = new List<int>();
        
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }
        public int result
        {
            get
            { return scores.Sum(); }
        }              
        public void Addscores(int number)
        {
            this.scores.Add(number);
        }
 
    } 
}
