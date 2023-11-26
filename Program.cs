using System;

class Person
{
    public string name = "Ben";
    public int age = 18;
    public string email = "ben@gmail.com";

    public Person(string name)
    {
        this.name = name;
    }

    public Person(string name, int age) : this(name)
    {
        this.age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Email: {email}");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Leon");
        Person person2 = new Person("Ada", 25);
        Person person3 = new Person("Kris", 30, "Kris@gmail.com");
        person1.DisplayInfo();
        person2.DisplayInfo();
        person3.DisplayInfo();
    }
}
