using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Info()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

class Student : Person
{
    public string Group;

    public Student(string name, int age, string group)
        : base(name, age)
    {
        Group = group;
    }

    public override void Info()
    {
        Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person("Андрей", 30);
        Student s = new Student("Вячеслав", 18, "ИСИТ-о-24/4");

        p.Info();
        s.Info();
    }
}
