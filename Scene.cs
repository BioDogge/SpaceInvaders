using SpaceInvaders.GameObjects;
using SpaceInvaders.GameObjectsFactories;

namespace SpaceInvaders
{
    internal class Scene
    {
        private List<GameObject> _swarm;
        private List<GameObject> _ground;
        private GameObject _playerShip;
        private List<GameObject> _playerShipMissile;
        private GameSettings _gameSettings;

        private static Scene _scene;

        private Scene()
        {

        }

        private Scene(GameSettings gameSettings)
        {
            _gameSettings = gameSettings;
            _swarm = new AlienShipFactory(gameSettings).GetSwarm();
            _ground = new GroundFactory(gameSettings).GetGround();
            _playerShip = new PlayerShipFactory(gameSettings).GetPlayerShip();
        }

        public static Scene GetScene(GameSettings gameSettings)
        {
            if (_scene == null)
            {
                _scene = new Scene(gameSettings);
            }
        }
    }
}
