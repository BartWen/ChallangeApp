using ChallangeApp;

var employee = new Employee("M", "Z");

employee.AddGrade(10);
employee.AddGrade("1");
employee.AddGrade(5);
employee.AddGrade(25);


var statistics = employee.GetStatistics();
var statisticFor = employee.GetStatisticswuthFor();
var statisticDoWhile = employee.GetStatisticswuthDoWhile();
var statisticWhile = employee.GetStatisticsWhile();



Console.WriteLine($"Wynik foreach");
Console.WriteLine($"Maksymalny wynik:{statistics.Max}");
Console.WriteLine($"Minimalny wynik:{statistics.Min}");
Console.WriteLine($"Srednia wyników:{statistics.Avarege:N2}");

Console.WriteLine($" ");
Console.WriteLine($"Wynik For");
Console.WriteLine($"Maksymalny wynik:{statisticFor.Max}");
Console.WriteLine($"Minimalny wynik:{statisticFor.Min}");
Console.WriteLine($"Srednia wyników:{statisticFor.Avarege:N2}");

Console.WriteLine($" ");
Console.WriteLine($"Wynik DoWhile");
Console.WriteLine($"Maksymalny wynik:{statisticDoWhile.Max}");
Console.WriteLine($"Minimalny wynik:{statisticDoWhile.Min}");
Console.WriteLine($"Srednia wyników:{statisticDoWhile.Avarege:N2}");

Console.WriteLine($" ");
Console.WriteLine($"Wynik While");
Console.WriteLine($"Maksymalny wynik:{statisticWhile.Max}");
Console.WriteLine($"Minimalny wynik:{statisticWhile.Min}");
Console.WriteLine($"Srednia wyników:{statisticWhile.Avarege:N2}");

























