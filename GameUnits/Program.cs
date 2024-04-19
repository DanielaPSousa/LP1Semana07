using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit military = new MilitaryUnit(10);

            settler.Move(5);
            military.Move(3);

            Console.WriteLine($"Settler Health: {settler.Health}");
            Console.WriteLine($"Settler Cost: {settler.Cost}");
            Console.WriteLine($"Military Health: {military.Health}");
            Console.WriteLine($"Military Cost: {military.Cost}");
        }
    }
}
