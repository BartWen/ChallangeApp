﻿using ChallangeApp;

var employee = new Employee("M", "Z");

employee.AddGrade(10);
//employee.AddGrade("1");
//employee.AddGrade(5);
//employee.AddGrade(33.455561565615);
//employee.AddGrade(33.4);
//employee.AddGrade(115);


var statistics = employee.GetStatistics();


Console.WriteLine($"Maksymalny wynik:{statistics.Max}");
Console.WriteLine($"Minimalny wynik:{statistics.Min}");
Console.WriteLine($"Srednia wyników:{statistics.Avarege:N2}");


























