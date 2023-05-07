namespace ChallengeApp.Tests;

public class TypeReferenceTest
{
    [Test]
    public void Test1()
    {
        //arrange
        var employee1 = new Employee("Wojtek", "Pugowski");
        var employee2 = new Employee("Monika", "Pugowska");

        //act
        //assert
        Assert.AreNotEqual(employee1, employee2);
    }

    [Test]
    public void Test2()
    {
        //arrange
        var employee1 = new Employee("Wojtek", "Pugowski");
        var employee2 = new Employee("Wojtek", "Pugowski");

        //act
        //assert
        Assert.AreEqual(employee1.ToString(), employee2.ToString());
    }

    private Employee GetEmployee(string name, string surname)
    {
        return new Employee(name, surname);
    }
}