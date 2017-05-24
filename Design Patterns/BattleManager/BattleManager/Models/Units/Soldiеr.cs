using System;
using System.Collections.Generic;
using BattleManager.Models.Contracts;

namespace BattleManager.Models
{
    public class Soldiеr : ICombatUnit, ISoldier
    {
        public Soldiеr(IUnit unit, IWeapon weapon)
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
