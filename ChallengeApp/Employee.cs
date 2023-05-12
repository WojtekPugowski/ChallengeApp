namespace ChallengeApp;

public class Employee : Person
{
    private List<float> grades = new List<float>();

    public Employee() : this("no name", "no surname", "no gender")
    {
    }

    public Employee(string name, string surname, string gender) : base(name, surname, gender)
    {
    }


    public float Result => grades.Sum();

    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            throw new Exception("Invalid grade value");
        }
    }

    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            AddGrade(result);
        }
        else
        {
            throw new Exception("Invalid grade value");
        }
    }

    public void AddGrade(double grade)
    {
        var fromDoubleGrade = (float)grade;
        AddGrade(fromDoubleGrade);
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        statistics.Average = 0;

        foreach (var grade in grades)
        {
            if (grade >= 0)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
        }

        statistics.Average /= grades.Count;
        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'E';
                break;
        }

        return statistics;
    }

    // public override string ToString()
    // {
    //     return ($"{Name} {Surname} - {Result} pkt.");
    // }
}