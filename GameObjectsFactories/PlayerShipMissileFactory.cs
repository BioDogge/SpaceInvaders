using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjectsFactories
{
    internal class PlayerShipMissileFactory : GameObjectFactories
    {
        public PlayerShipMissileFactory(GameSettings gameSettings)
           : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject missile = new PlayerShipMissile()
            {
                Figure = GameSettings.PlayerMissile,
                GameObjectPlace = objectPlace,
                ObjectType = GameObjectType.PlayerShipMissile
            };

            return missile;
        }
    }
}
