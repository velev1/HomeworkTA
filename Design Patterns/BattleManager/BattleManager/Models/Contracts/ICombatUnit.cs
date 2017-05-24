using System.Collections.Generic;

namespace BattleManager.Models.Contracts
{
    public interface ICombatUnit
    {
        void Attack(ICollection<ICombatUnit> units);

        void Defend(ICollection<ICombatUnit> units);
    }
}
