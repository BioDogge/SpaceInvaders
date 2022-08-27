using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjectsFactories
{
    internal class GroundFactory : GameObjectFactories
    {
        public GroundFactory(GameSettings gameSettings)
           : base(gameSettings)
        {

        }

        public override GameObject GetGameObject(GameObjectPlace objectPlace)
        {
            GameObject groundObject = new GroundObject()
            {
                Figure = GameSettings.Ground,
                GameObjectPlace = objectPlace,
                ObjectType = GameObjectType.GroundObject
            };

            return groundObject;
        }

        public List<GameObject> GetGround()
        {
            List<GameObject> ground = new List<GameObject>();

            int startX = GameSettings.GroundStartXCoordinate;
            int startY = GameSettings.GroundStartYCoordinate;

            for (int y = 0; y < GameSettings.NumberOfGroundRows; y++)
            {
                for (int x = 0; x < GameSettings.NumberOfGroundColls; x++)
                {
                    GameObjectPlace objectPlace = new GameObjectPlace()
                    {
                        XCoordinate = startX + x,
                        YCoordinate = startY + y
                    };

                    GameObject groundObject = GetGameObject(objectPlace);
                    ground.Add(groundObject);
                }
            }

            return ground;
        }
    }
}
