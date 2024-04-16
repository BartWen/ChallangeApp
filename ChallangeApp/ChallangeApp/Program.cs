using ChallangeApp;

Console.WriteLine("Witamy w programie oceny pracowanika");
Console.WriteLine("====================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj ocene pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break; 
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Maksymalny wynik:{statistics.Max}");
Console.WriteLine($"Minimalny wynik:{statistics.Min}");
Console.WriteLine($"Srednia wyników:{statistics.Avarege:N2}");
Console.WriteLine($"Ocena końcowa:{statistics.AverageLetter}");























