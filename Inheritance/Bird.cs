using System;

namespace Inheritance;

public class Bird : Animal
{
   public bool CanFly { get; set; }
   public string NoiseLevel { get; set; }
   public bool CanSwim { get; set; }
   public string BeakSize { get; set; }

   public void BirdStats()
   {
      Console.WriteLine($"Bird stats: \nName: {Name}\nAge: {Age}\nCan Breathe: {CanBreatheAir}\nCan Fly: {CanFly}\nNoiseLevel: {NoiseLevel}\nCanSwim: {CanSwim}\nBeakSize: {BeakSize}");
   }


   public Bird()
   {
      
   }

   public Bird(string name, int limbs, int age, bool canBreatheAir, bool canFly, string noiseLevel, bool canSwim, string beakSize)
   {
      Name = name;
      Limbs = limbs;
      Age = age;
      CanBreatheAir = canBreatheAir;
      CanFly = canFly;
      NoiseLevel = noiseLevel;
      CanSwim = canSwim;
      BeakSize = beakSize;
      
   }
    
}