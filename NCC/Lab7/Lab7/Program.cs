using System;

class Temp
{
    public delegate void Alert(double t);

    public event Alert HighTemp;

    public void Check(double t)
    {
        Console.WriteLine("Temperature: " + t);

        if (t >= 40)
        {
            HighTemp?.Invoke(t);
        }
    }
}

class Program
{
    static void Main()
    {
        Temp obj = new Temp();

        obj.HighTemp += Warning;

        obj.Check(25);
        obj.Check(55);
    }

    static void Warning(double t)
    {
        Console.WriteLine("Warning! High temperature: " + t);
    }
}