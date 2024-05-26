﻿using ChallengeApp;

Console.WriteLine("Witamy w programie ocen pracowników");
Console.WriteLine("===================================");
Console.WriteLine();

var employee = new Employee();

//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Finally here.");
//}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    Console.WriteLine("Jeśli chcesz zakończyć naciśnij Q.");
    var input = Console.ReadLine();
    if (input == "Q" || input == "q")
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
Console.WriteLine($"Średnia ocen: {statistics.Average}");
Console.WriteLine($"Najniższa ocena: {statistics.Min}");
Console.WriteLine($"Najwyższa ocena: {statistics.Max}");