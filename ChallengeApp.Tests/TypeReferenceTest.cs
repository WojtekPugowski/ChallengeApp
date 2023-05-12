namespace ChallengeApp.Tests;

public class TypeReferenceTest
{
    [Test]
    public void Test1()
    {
        //arrange
        var employee1 = new Employee("Wojtek", "Pugowski", "M");
        var employee2 = new Employee("Monika", "Pugowska", "F");

        //act
        //assert
        Assert.AreNotEqual(employee1, employee2);
    }

    [Test]
    public void Test2()
    {
        //arrange
        var employee1 = new Employee("Wojtek", "Pugowski", "M");
        var employee2 = new Employee("Wojtek", "Pugowski", "M");

        //act
        //assert
        Assert.AreEqual(employee1.ToString(), employee2.ToString());
    }

    private Employee GetEmployee(string name, string surname, string gender)
    {
        return new Employee(name, surname, gender);
    }
}