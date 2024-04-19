using System;

namespace GameUnits
{
    public abstract class Unit
    {
        public int Movement { get; set; }
        public int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            Movement = movement;
            Health = health;
        }
        public virtual void Move(int distance)
        {
            Console.WriteLine($"Unit moved {distance} units.");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={Health} COST={Cost:F2}";
        }
    }
}