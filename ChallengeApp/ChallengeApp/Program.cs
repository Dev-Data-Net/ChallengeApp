using ChallengeApp;

Console.WriteLine("Witamy w programie ocen pracowników");
Console.WriteLine("===================================");
Console.WriteLine();

var employee = new Employee();

try
{
    Employee emp = null;
    var name = emp.Surname;
}
catch (Exception)
{
    Console.WriteLine("Takiej sytuacji nie powinno być.");
}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    Console.WriteLine("Jeśli chcesz zakończyć naciśnij Q.");
    var input = Console.ReadLine();
    if (input == "Q" || input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");