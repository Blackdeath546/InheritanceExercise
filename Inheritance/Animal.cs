using System;

namespace Inheritance;

public class Animal
{
    //Properties
    public string Name { get; set; }
    public int Limbs { get; set; }
    public int Age { get; set; }
    public bool CanBreatheAir { get; set; }

    public void DisplayClass()
    {
        Console.WriteLine($"Name: {Name}\nLimbs: {Limbs}\nAge: {Age}\nCan Breathe: {CanBreatheAir}");
    }
}

