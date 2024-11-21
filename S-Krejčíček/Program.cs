using System;

class Singleton
{
    static Singleton singl; 

    private Singleton() { } 

    public static Singleton Dej()
    {
        if (singl == null)
        {
            singl = new Singleton();
            Console.WriteLine("instance udelana.");
        }
        return singl;
    }

    public void Ukaz()
    {
        Console.WriteLine("Singleton");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var prvni = Singleton.Dej();
        prvni.Ukaz();

        var druhy = Singleton.Dej();

        if (prvni == druhy)
        {
            Console.WriteLine("Opakuje se");
        }
        else
        {
            Console.WriteLine("Chyba");
        }
    }
}
