using System;

namespace MilitaryUnit
{
    public class MilitaryUnit : Unit
    {
    public int XP { get; private set; }
    public int AttackPower { get; private set; }
    public MilitaryUnit(int attackPower) : base(1, 10)
        {
            XP = 0;
            AttackPower = attackPower;
        }
    }
}