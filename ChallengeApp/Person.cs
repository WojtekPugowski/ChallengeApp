namespace ChallengeApp;

public abstract class Person
{
    public Person(string name, string surname, string gender)
    {
        Name = name;
        Surname = surname;
        Gender = gender;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Gender { get; private set; }
    public Statistics GetStatistics()
    {
        throw new NotImplementedException();
    }
}