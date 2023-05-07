namespace ChallengeApp;

public class Employee
{
    private List<float> grades = new List<float>();

    public Employee(string name, string surename)
    {
        Name = name;
        Surname = surename;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    private int Age { get; set; }

    public float Result => grades.Sum();

    public void AddGrade(float number)
    {
        grades.Add(number);
    }

    public void SubtractGrade(float number)
    {
        grades.Add(-number);
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;

        foreach (var grade in grades)
        {
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Average += grade;
        }

        statistics.Average /= grades.Count;

        return statistics;
    }

    // public override string ToString()
    // {
    //     return ($"{Name} {Surname} - {Result} pkt.");
    // }
}