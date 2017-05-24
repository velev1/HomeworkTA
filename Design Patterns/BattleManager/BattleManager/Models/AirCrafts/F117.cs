using System;
using System.Collections.Generic;
using BattleManager.Models.Contracts;

namespace BattleManager.Models.AirCrafts
{
    public class F117 : IAirplane
    {
        public F117(IPilot pilot)
        {

        }

        public void Attack(ICollection<ICombatUnit> units)
        {
            Console.WriteLine(this.GetType().Name + " Attacking");
        }

        public void Defend(ICollection<ICombatUnit> units)
        {
            Console.WriteLine(this.GetType().Name + " Defending");
        }
    }
}
