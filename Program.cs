using System.Dynamic;
using System.Runtime.CompilerServices;

namespace MyFirstBlerp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Be andvändaren om ett namn
        Console.WriteLine("What is your name?");
        string myName = Console.ReadLine() ?? "";
        string mySurname = "Svensson";
        int myAge = 50;
        int MyShoeSize = 46;

        // Skriv ut en hälsning till användaren med namnet
        if (myName.ToLower() == "tony") Console.WriteLine("Fudge you, Tony!");
        else Console.WriteLine($"Hello, and welcome, {myName}!");

        // Man kan också skapa en instans av person-klassen med namn
        Person individ1 = new Person(myName, mySurname, myAge, MyShoeSize); 
         Console.ReadLine();
         Console.WriteLine("Vi testar att skriva ut den nya individens objektvariabler.");
         Console.WriteLine("Hej, {0} {1}! Du är {2} år gammal och du har skostorlek {3}.", individ1._firstName, individ1._lastName, individ1._age, individ1._shoeSize);
    }


}

// Vi skapar person-klassen här
public class Person
{
    // Objektvariabler
    public string _firstName, _lastName;
    public int _age, _shoeSize;

    public Person(string firstName, string lastName, int age, int shoeSize)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._age = age;
        this._shoeSize = shoeSize;
    }
}