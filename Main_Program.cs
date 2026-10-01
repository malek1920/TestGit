using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenue dans mon projet C# avec Git !");

        string name = "Malek";
        int age = 25;

        Console.WriteLine($"Nom : {name}");
        Console.WriteLine($"Age : {age}");
        string x = "Ceci est un message à afficher.";
        DisplayMessage(x);
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
}