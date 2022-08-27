using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjectsFactories
{
    internal class PlayerShipFactory : GameObjectFactories
    {
        public PlayerShipFactory(GameSettings gameSettings)
           : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject playerShip = new PlayerShip()
            {
                Figure = GameSettings.PlayerShip,
                GameObjectPlace = objectPlace,
                ObjectType = GameObjectType.PlayerShip
            };

            return playerShip;
        }

        public GameObject GetPlayerShip()
        {
            GameObjectPlace place = new GameObjectPlace()
            {
                XCoordinate = GameSettings.PlayerShipStartXCoordinate,
                YCoordinate = GameSettings.PlayerShipStartYCoordinate
            };

            GameObject playerShip = GetGameObject(place);

            return playerShip;
        }
    }
}
