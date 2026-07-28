using System;

class Student
{
    public string Name { get; set; }
    public int Roll { get; set; }
    public double Marks { get; set; }

    public Student(string name, int roll, double marks)
    {
        Name = name;
        Roll = roll;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll: " + Roll);
        Console.WriteLine("Marks: " + Marks);
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Ram", 101, 85.5);

        s1.Display();
    }
}

