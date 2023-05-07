namespace ChallengeApp.Tests;

public class StatisticsTests
{
    [Test]
    public void MaxValueForEmployee()
    {
        //arrange
        var employee = new Employee("Wojtek", "Pugowski");
        employee.AddGrade(15);
        employee.AddGrade(4);
        //act
        var statistics = employee.GetStatistics();
        var maxStat = statistics.Max;
        //assert
        Assert.AreEqual(15, maxStat);
    }
    
    [Test]
    public void MinValueForEmployee()
    {
        //arrange
        var employee = new Employee("Wojtek", "Pugowski");
        employee.AddGrade(15);
        employee.AddGrade(4);
        //act
        var statistics = employee.GetStatistics();
        var minStat = statistics.Min;
        //assert
        Assert.AreEqual(4, minStat);
    }
    [Test]
    public void AverageValueForEmployee()
    {
        //arrange
        var employee = new Employee("Wojtek", "Pugowski");
        employee.AddGrade(14);
        employee.AddGrade(4);
        //act
        var statistics = employee.GetStatistics();
        var aveStat = statistics.Average;
        //assert
        Assert.AreEqual(9, aveStat);
    }
}