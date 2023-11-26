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

    // Ветка A: Изменения в конструкторе
    public Person(string name, int age) : this(name)
    {
        this.age = age + 1; // Добавлено изменение: увеличиваем возраст на 1
    }

    public Person(string name, int age, string email) : this(name, age)
    {
        this.email = email;
    }

    // Ветка B: Изменения в методе DisplayInfo
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
