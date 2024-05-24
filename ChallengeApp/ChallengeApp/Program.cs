using ChallengeApp;

Employee employee = new Employee("Jan", "Kowalski");
employee.AddGrade(1);
employee.AddGrade(8);
employee.AddGrade(2);
employee.AddGrade(60);
employee.AddGrade('A');
var statistics = employee.GetStatistics();
Console.WriteLine(statistics.AverageLetter);
