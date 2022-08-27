using SpaceInvaders.GameObjects;

namespace SpaceInvaders
{
    internal class Scene
    {
        private List<GameObject> _swarm;
        private List<GameObject> _ground;
        private GameObject _playerShip;
        private List<GameObject> _playerShipMissile;

        private static Scene _scene;

        private Scene()
        {

        }

        public Scene(GameSettings gameSettings)
        {

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
