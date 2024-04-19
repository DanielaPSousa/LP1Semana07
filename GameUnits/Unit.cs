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
    }
}