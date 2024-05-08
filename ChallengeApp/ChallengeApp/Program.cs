using ChallengeApp;

Employee employee1 = new Employee("Stanisław", "Nowak", 36);
Employee employee2 = new Employee("Mieczysław", "Kowalski", 40);
Employee employee3 = new Employee("Leszek", "Marszałek", 50);


employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(8);
employee1.AddScore(9);
//SUMA = 35

employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(4);
// SUMA = 23

employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
// SUMA = 21

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};


int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Największą liczbę punktów zdobył: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " " + "lat.\n" + "Zdobywając: " + employeeWithMaxResult.Result + " punktów.");



