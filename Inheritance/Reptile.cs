using System;

namespace Inheritance;

public class Reptile : Animal
{
    public string CanSwim { get; set; }
    public bool HasTail { get; set; }
    public string CanClimb { get; set; }
    public bool IsColdBlooded { get; set; }


    public void ReptileStats()
    {
        Console.WriteLine($"Reptile stats:\nName: {Name}\nLimbs: {Limbs}\nAge:" +
                          $" {Age}\nCan Breathe: {CanBreatheAir}\nCanSwim: {CanSwim}\nHas Tail: " +
                          $"{HasTail}\nCan Climb: {CanClimb}\nIsColdBlooded: {IsColdBlooded}");
    }

    public Reptile()
    {
        
    }

    public Reptile(string name, int limbs, int age, bool canBreatheAir, string canSwim, bool hasTail, string canClimb, bool isColdBlooded)
    {
        Name = name;
        Limbs = limbs;
        Age = age;
        CanBreatheAir = canBreatheAir;
        CanSwim = canSwim;
        HasTail = hasTail;
        CanClimb = canClimb;
        IsColdBlooded = isColdBlooded;
    }
}