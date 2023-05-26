namespace ChallengeApp.Tests;

public class LetterGradeTest
{
    [Test]
    public void LetterGradeEmployeeFromAverage()
    {
        //arrange
        var employee = new EmployeeInMemory("Woj", "Tek", "M");
        employee.AddGrade(30);
        employee.AddGrade(20);
        //act
        var statistics = employee.GetStatistics();
        var letterStat = statistics.AverageLetter;
        //assert
        Assert.AreEqual('D', letterStat);
    }
}