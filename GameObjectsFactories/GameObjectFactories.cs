using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders.GameObjectsFactories
{
    abstract class GameObjectFactories
    {
        public GameSettings GameSettings { get; set; }
        public abstract GameObject GetGameObject(GameObjectPlace objectPlace);

        public GameObjectFactories(GameSettings gameSettings)
        {
            GameSettings = gameSettings;
        }
    }
}
