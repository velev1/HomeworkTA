using BattleManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager.Models.AirCrafts
{
    public class SecretAirCraft : ISecretAirplane
    {
        public SecretAirCraft(IAirplane airplane, IKiborg kiborg)
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
