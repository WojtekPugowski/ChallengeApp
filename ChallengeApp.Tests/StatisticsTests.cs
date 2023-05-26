namespace ChallengeApp.Tests;

public class StatisticsTests
{
    [Test]
    public void MaxValueForEmployee()
    {
        //arrange
        var employee = new EmployeeInMemory("Wojtek", "Pugowski", "M");
        employee.AddGrade(15);
        employee.AddGrade(4);
        //act
        var statistics = employee.GetStatistics();
        //assert
        Assert.AreEqual(15, statistics.Max);
    }

    [Test]
    public void MinValueForEmployee()
    {
        //arrange
        var employee = new EmployeeInMemory("Wojtek", "Pugowski", "M");
        employee.AddGrade(15);
        employee.AddGrade(4);
        //act
        var statistics = employee.GetStatistics();
        //assert
        Assert.AreEqual(4, statistics.Min);
    }

    [Test]
    public void AverageValueForEmployee()
    {
        //arrange
        var employee = new EmployeeInMemory("Wojtek", "Pugowski", "M");
        employee.AddGrade(2);
        employee.AddGrade(2);
        employee.AddGrade(6);
        //act
        var statistics = employee.GetStatistics();
        //assert
        Assert.AreEqual(Math.Round(3.33,2), Math.Round(statistics.Average, 2));
    }
}