using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager.Models.Contracts
{
    public interface IArmy
    {
        ICollection<ICombatUnit> ArmyUnits { get; }
    }
}
