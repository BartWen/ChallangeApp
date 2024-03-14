using ChallangeApp;

Employee employee1 = new Employee("Mark", "Jeden", 25);
Employee employee2 = new Employee("Zbych", "Dwa", 35);
Employee employee3 = new Employee("Jan", "trzy", 45);

List<Employee> employesList = new List<Employee>()
    {employee1,employee2,employee3};

employee1.Addscores(5);
employee1.Addscores(7);
employee1.Addscores(1);
employee1.Addscores(7);
employee1.Addscores(7);

employee2.Addscores(5);
employee2.Addscores(9);
employee2.Addscores(2);
employee2.Addscores(1);
employee2.Addscores(9);

employee3.Addscores(9);
employee3.Addscores(50);
employee3.Addscores(9);
employee3.Addscores(6);
employee3.Addscores(1);

List<int> listMaxresult = new List<int>()
{employee1.result,employee2.result,employee3.result};

for (int i = 0; i < listMaxresult.Count; i++)
{
    if (listMaxresult.Max() == listMaxresult[i])
    {
        Console.WriteLine("{0} {1} ma {2} lat i zdobył {3} pkt",
            employesList[i].name, employesList[i].surname, employesList[i].age, listMaxresult.Max());
    }
};






















