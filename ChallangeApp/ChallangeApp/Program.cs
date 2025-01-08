using ChallangeApp;

Console.WriteLine("Witamy w programie oceny pracowanika");
Console.WriteLine("====================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Mark", "Edmos");
employee.GradeAdded += Employee_GradeAdded;

void Employee_GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocene");
}

while (true)
{
    Console.WriteLine("  ");
    Console.WriteLine("Podaj ocene szefa");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

}

var statistics = employee.GetStatistics();

Console.WriteLine($"Maksymalny wynik:{statistics.Max}");
Console.WriteLine($"Minimalny wynik:{statistics.Min}");
Console.WriteLine($"Srednia wyników:{statistics.Avarege:N2}");
Console.WriteLine($"Ocena końcowa:{statistics.AverageLetter}");

























