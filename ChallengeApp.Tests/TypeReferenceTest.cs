namespace ChallengeApp.Tests;

public class TypeReferenceTest
{
    [Test]
    public void Test1()
    {
        //arrange
        var employee1 = new EmployeeInMemory("Wojtek", "Pugowski", "M");
        var employee2 = new EmployeeInMemory("Monika", "Pugowska", "F");

        //act
        //assert
        Assert.AreNotEqual(employee1, employee2);
    }

    [Test]
    public void Test2()
    {
        //arrange
        var employee1 = new EmployeeInMemory("Wojtek", "Pugowski", "M");
        var employee2 = new EmployeeInMemory("Wojtek", "Pugowski", "M");

        //act
        //assert
        Assert.AreEqual(employee1.ToString(), employee2.ToString());
    }

    private EmployeeInMemory GetEmployee(string name, string surname, string gender)
    {
        return new EmployeeInMemory(name, surname, gender);
    }
}