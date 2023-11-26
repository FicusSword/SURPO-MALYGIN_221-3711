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
        this.age = age + 1;
    }

    public Person(string name, int age, string email) : this(name, age)
    {
        this.email = email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Email: {email}");
        Console.WriteLine($"Name: {name}, Age: {age}, Email: {email}");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Leon");
        Person person2 = new Person("Ada", 23);
        Person person3 = new Person("Kris", 30, "Kris@gmail.com");
        person1.DisplayInfo();
        person2.DisplayInfo();
        person3.DisplayInfo();
    }
}
