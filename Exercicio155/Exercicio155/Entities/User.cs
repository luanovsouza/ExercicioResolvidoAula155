namespace Exercicio155.Entities;

public class User
{
    public string? Name { get; set; }
    public DateTime AcessTime { get; set; }

    public User(string? name, DateTime acessTime)
    {
        Name = name;
        AcessTime = acessTime;
    }
}