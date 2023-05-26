// namespace ChallengeApp.Tests;
//
// public class SupervisiorTests
// {
//     [Test]
//     public void MaxValueForSupervisiorAddStringGrade()
//     {
//         //arrange
//         var supervisior = new Supervisior("Wojtek", "Pugowski", "M");
//         supervisior.AddGrade("6-");
//         supervisior.AddGrade("+2");
//         //act
//         var statistics = supervisior.GetStatistics();
//         //assert
//         Assert.AreEqual(90, statistics.Max);
//     }
//     [Test]
//     public void MinValueForSupervisiorAddStringGrade()
//     {
//         //arrange
//         var supervisior = new Supervisior("Wojtek", "Pugowski", "M");
//         supervisior.AddGrade("-6");
//         supervisior.AddGrade("2+");
//         //act
//         var statistics = supervisior.GetStatistics();
//         //assert
//         Assert.AreEqual(25, statistics.Min);
//     }
//     
//     [Test]
//     public void AverageForSupervisiorAddStringGrade()
//     {
//         //arrange
//         var supervisior = new Supervisior("Wojtek", "Pugowski", "M");
//         supervisior.AddGrade("-6");
//         supervisior.AddGrade("2");
//         //act
//         var statistics = supervisior.GetStatistics();
//         //assert
//         Assert.AreEqual(55, statistics.Average);
//     }
//
// }