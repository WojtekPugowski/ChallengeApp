using ChallengeApp;

Console.WriteLine("===========================================");
Console.WriteLine();
// Console.WriteLine("Podaj dane pracownika: ");
//Console.WriteLine("Wpisz imię: ");
//var name = Console.ReadLine();
//Console.WriteLine("Wpisz nazwisko: ");
//var surname = Console.ReadLine();
//Console.WriteLine("Wpisz płeć (K/M): ");
//var sex = Console.ReadLine();

var employee = new EmployeeInFile("Woj", "Tek", "M");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(5f);
employee.AddGrade(10f);
employee.AddGrade("a");


Console.WriteLine();
var statisticsEmployeeInFile = employee.GetStatistics();
Console.WriteLine($"Average: {statisticsEmployeeInFile.Average}");
Console.WriteLine($"Min: {statisticsEmployeeInFile.Min}");
Console.WriteLine($"Max: {statisticsEmployeeInFile.Max}");
Console.WriteLine($"AverageLetter: {statisticsEmployeeInFile.AverageLetter}");

//Console.WriteLine("Podaj ocenę pracownika: ");
//var input = Console.ReadLine();

//try
//{
//    employee.AddGrade(input);
//}
//catch (Exception e)
//{
//    Console.WriteLine($"Exception catched: {e.Message}");
//}

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika (jeśli chcesz wyjść naciśnij 'q'): ");
//    input = Console.ReadLine();
//    if (input == "q")
//    {
//        Console.WriteLine("Oto wyniki podanego pracownika: "); 
//        break;        
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");
//    }

//}

// var statistics = employee.GetStatistics();
// Console.WriteLine($"Average: {statistics.Average}");
// Console.WriteLine($"Min: {statistics.Min}");
// Console.WriteLine($"Max: {statistics.Max}");
// Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");