namespace MyFirstBlerp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Be andvändaren om ett namn
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine() ?? "";

        // Skriv ut en hälsning till användaren med namnet
        Console.WriteLine($"Hello, and welcome, {name}!");
        Console.ReadLine();
    }
}
