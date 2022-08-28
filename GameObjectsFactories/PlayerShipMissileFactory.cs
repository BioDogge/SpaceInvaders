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
            GameObjectPlace missilePlace = new GameObjectPlace()
            { 
                XCoordinate = objectPlace.XCoordinate,
                YCoordinate = objectPlace.YCoordinate - 1,
            };

            GameObject missile = new PlayerShipMissile()
            {
                Figure = GameSettings.PlayerMissile,
                GameObjectPlace = missilePlace,
                ObjectType = GameObjectType.PlayerShipMissile
            };

            return missile;
        }
    }
}
