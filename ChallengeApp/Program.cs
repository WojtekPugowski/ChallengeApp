using ChallengeApp;

Console.WriteLine("Witaj w programie oceny pracownika");
Console.WriteLine("==================================\n");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejna ocenę pracownika: ");
    var input = (Console.ReadLine()).ToUpper();
    if(input == "Q") break;
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
  

}

var stat = employee.GetStatistics();
Console.WriteLine($" Ocena max: {stat.Max}");
Console.WriteLine($" Ocena min: {stat.Min}");
Console.WriteLine($" Ocena średnia: {stat.Average}");
Console.WriteLine($" Ocena literowa: {stat.AverageLetter}");