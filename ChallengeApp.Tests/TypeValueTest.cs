namespace ChallengeApp.Tests;

public class TypeValueTest
{
    [Test]
    public void Test1()
    {
        //arrange
        var number1 = 12;
        var number2 = 12;

        //act
        //assert
        Assert.AreEqual(number1, number2);
    }
}