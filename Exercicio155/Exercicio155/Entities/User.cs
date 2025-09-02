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


    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is User))
        {
            return false;
        }
        
        User? other = obj as User;

        return Name.Equals(other.Name);
    }
}