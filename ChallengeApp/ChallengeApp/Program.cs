using ChallengeApp;

Console.WriteLine("Witamy w programie ocen pracowników");
Console.WriteLine("===================================");
Console.WriteLine();
Console.WriteLine("Podaj ocenę pracownika: ");
var input = Console.ReadLine();

var employee = new Employee();
employee.AddGrade(input);
var statistics = employee.GetStatistics();
Console.WriteLine(statistics.Average);