using ChallangeApp;
using System.Xml.Schema;


Employee employee1 = new Employee("Mark", "Jeden", 25);
Employee employee2 = new Employee("Zbych", "Dwa", 35);
Employee employee3 = new Employee("Jan", "trzy", 45);


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

employee3.Addscores(1);
employee3.Addscores(8);
employee3.Addscores(4);
employee3.Addscores(6);
employee3.Addscores(1);

List<int> listMaxresult = new List<int>();

listMaxresult.Add(employee1.result);
listMaxresult.Add(employee2.result);
listMaxresult.Add(employee3.result);

var MaxValue = listMaxresult.Max();

if (MaxValue == listMaxresult[0])
{
    Console.WriteLine("{0} {1} ma {2} lat i zdobył {3} pkt",
        employee1.name, employee1.surname, employee1.age, listMaxresult[0]);
}
else if (MaxValue == listMaxresult[1])
{
    Console.WriteLine("{0} {1} ma {2} lat i zdobył {3} pkt",
        employee1.name, employee1.surname, employee1.age, listMaxresult[1]);
}
else
{
    Console.WriteLine("{0} {1} ma {2} lat i zdobył {3} pkt",
            employee1.name, employee1.surname, employee1.age, listMaxresult[2]);
}






















