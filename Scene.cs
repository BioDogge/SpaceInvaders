using SpaceInvaders.GameObjects;
using SpaceInvaders.GameObjectsFactories;

namespace SpaceInvaders
{
    internal class Scene
    {
        private GameSettings _gameSettings;
        public List<GameObject> Swarm { get; private set; }
        public List<GameObject> Ground { get; private set; }
        public GameObject PlayerShip { get; private set; }
        public List<GameObject> PlayerShipMissile { get; private set; }

        private static Scene _scene;

        private Scene()
        {

        }

        private Scene(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            Swarm = new AlienShipFactory(gameSettings).GetSwarm();
            Ground = new GroundFactory(gameSettings).GetGround();
            PlayerShip = new PlayerShipFactory(gameSettings).GetPlayerShip();
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if (_scene == null)
            {
                _scene = new Scene(gameSettings);
            }

            return _scene;
        }
    }
}
