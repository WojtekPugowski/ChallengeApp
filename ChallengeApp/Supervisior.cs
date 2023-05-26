// namespace ChallengeApp;
//
// public class Supervisior : IEmployee
// {
//     public Supervisior(string name, string surname, string gender)
//     {
//         Name = name;
//         Surname = surname;
//         Gender = gender;
//     }
//     private List<float> grades = new List<float>();
//
//     public string Name { get; }
//     public string Surname { get; }
//     public string Gender { get; }
//
//     public void AddGrade(float grade)
//     {
//         if (grade >= 0 && grade <= 100)
//         {
//             grades.Add(grade);
//         }
//         else
//         {
//             throw new Exception("Invalid grade value");
//         }
//     }
//
//     public void AddGrade(string grade)
//     {
//         switch (grade)
//         {
//             case "6":
//                 grades.Add(100);
//                 break;
//             case "6-":
//             case "-6":
//                 grades.Add(90);
//                 break;
//             case "5+":
//             case "+5":
//                 grades.Add(85);
//                 break;
//             case "5":
//                 grades.Add(80);
//                 break;
//             case "5-":
//             case "-5":
//                 grades.Add(70);
//                 break;
//             case "4+":
//             case "+4":
//                 grades.Add(65);
//                 break;
//             case "4":
//                 grades.Add(60);
//                 break;
//             case "4-":
//             case "-4":
//                 grades.Add(50);
//                 break;
//             case "3+":
//             case "+3":
//                 grades.Add(45);
//                 break;
//             case "3":
//                 grades.Add(40);
//                 break;
//             case "3-":
//             case "-3":
//                 grades.Add(30);
//                 break;
//             case "2+":
//             case "+2":
//                 grades.Add(25);
//                 break;
//             case "2":
//                 grades.Add(20);
//                 break;
//             case "2-":
//             case "-2":
//                 grades.Add(10);
//                 break;
//             case "1":
//                 grades.Add(0);
//                 break;
//         }
//     }
//
//     public void AddGrade(double grade)
//     {
//         var fromDoubleGrade = (float)grade;
//         AddGrade(fromDoubleGrade);
//     }
//
//     public Statistics GetStatistics()
//     {
//         var statistics = new Statistics();
//         statistics.Min = float.MaxValue;
//         statistics.Max = float.MinValue;
//         statistics.Average = 0;
//
//         foreach (var grade in grades)
//         {
//             if (grade >= 0)
//             {
//                 statistics.Min = Math.Min(statistics.Min, grade);
//                 statistics.Max = Math.Max(statistics.Max, grade);
//                 statistics.Average += grade;
//             }
//         }
//
//         statistics.Average /= grades.Count;
//         switch (statistics.Average)
//         {
//             case var average when average >= 80:
//                 statistics.AverageLetter = 'A';
//                 break;
//             case var average when average >= 60:
//                 statistics.AverageLetter = 'B';
//                 break;
//             case var average when average >= 40:
//                 statistics.AverageLetter = 'C';
//                 break;
//             case var average when average >= 20:
//                 statistics.AverageLetter = 'D';
//                 break;
//             default:
//                 statistics.AverageLetter = 'E';
//                 break;
//         }
//
//         return statistics;
//     }
// }