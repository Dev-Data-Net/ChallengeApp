using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}"); //:N2 - float do dwóch miejsc po przecinku
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(ref statistics);
void SetSth(ref Statistics statistics) //ref - referencja
{
    statistics = new Statistics();
}