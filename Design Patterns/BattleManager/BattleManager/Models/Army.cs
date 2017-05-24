using BattleManager.Models.Contracts;
using System.Collections.Generic;
using System;

namespace BattleManager.Models
{
    public class Army : IArmy
    {
        private ICollection<ICombatUnit> armyUnits;

        public Army(ICollection<ICombatUnit> army)
        {
            armyUnits = new List<ICombatUnit>();
            this.ArmyUnits = army;
        }

        public ICollection<ICombatUnit> ArmyUnits
        {
            get
            {
                return this.armyUnits;
            }
            set
            {
                this.armyUnits = value;
            }
        }
    }
}
