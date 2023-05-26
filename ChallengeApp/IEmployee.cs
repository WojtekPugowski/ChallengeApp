using static ChallengeApp.EmployeeBase;

namespace ChallengeApp;

public interface IEmployee
{
    string Name { get; }
    string Surname { get; }
    string Gender { get; }
    void AddGrade(float grade);
    void AddGrade(string grade);
    void AddGrade(double grade);


    Statistics GetStatistics();
    public event GradeAddedDelegate GradeAdded;
}