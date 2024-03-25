using ChallangeApp;

var employee = new Employee("M", "Z");

employee.AddGrade(10);
employee.AddGrade(3);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Maksymalny wynik:{statistics.Max}");
Console.WriteLine($"Minimalny wynik:{statistics.Min}");
Console.WriteLine($"Srednia wyników:{statistics.Avarege:N2}");


























