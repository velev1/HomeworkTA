using BattleManager.Models;
using BattleManager.Models.AirCrafts;
using BattleManager.Models.Contracts;
using BattleManager.Models.Units;
using System.Collections.Generic;

namespace BattleManager
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            IHuman human = new Human();
            IRobot robot = new Robot();

            IWeapon kalashnikov = new AK47();
            IWeapon laser = new Laser();

            ICombatUnit soldier = new Soldiеr(human, kalashnikov);
            IKiborg kiborg = new Kiborg(human, robot, laser);

            Soldiеr specialSoldier = new Soldiеr(kiborg, laser);

            IPilot pilot = new Pilot();
            IAirplane airplane = new F117(pilot);
            ISecretAirplane secretAirplane = new SecretAirCraft(airplane, kiborg);

            var army = new List<ICombatUnit>
            {
                soldier,
                specialSoldier,
                airplane,
                secretAirplane
            };

            IArmy myArmy = new Army(army);

            foreach (var unit in myArmy.ArmyUnits)
            {
                unit.Attack(army);
            }
        }
    }
}
