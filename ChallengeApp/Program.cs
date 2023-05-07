using ChallengeApp;

var employee = new Employee("Wojtek", "Pugowski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(12);
var statistics = employee.GetStatistics();
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Average}");