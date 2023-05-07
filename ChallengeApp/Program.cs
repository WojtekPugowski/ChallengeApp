using ChallengeApp;

var employee = new Employee("Wojtek", "Pugowski");
employee.AddGrade("Adam");
employee.AddGrade(2d);
employee.AddGrade(5);
employee.AddGrade(12);
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average:N2}");