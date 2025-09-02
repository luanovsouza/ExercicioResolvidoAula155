using System.Globalization;
using Exercicio155.Entities;

namespace Exercicio155;

public class Program
{
    static void Main(string[] args)
    {
        string finalpath =
            @"C:\Users\gamer\OneDrive\Documentos\Curso C# POO UDEMY\Exercicios\Seção13\Exercicio ResolvidoAula155\ExercicioResolvidoAula155/in.txt";

        HashSet<User> users = new HashSet<User>();
        
        try
        {
            using (StreamReader sr = new StreamReader(finalpath))
            {
                string line;

                while ((line = sr.ReadLine()!) != null)
                {
                    string[] fields = line.Split(' ');
                    string userName = fields[0];
                    DateTime acessTime = DateTime.ParseExact(fields[1], "yyyy-MM-ddTHH:mm:ssK", CultureInfo.InvariantCulture);
                    
                    
                    
                    users.Add(new User(userName, acessTime));
                }

                Console.WriteLine("Leitura do Arquivo Feita com Sucesso!");

                foreach (var user in users)
                {
                    Console.WriteLine($"Total users: {users.Count}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Um erro aconteceu!");
            Console.WriteLine(e.Message);
        }
        
    }
}