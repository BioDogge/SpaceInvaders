using SpaceInvaders.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    internal class GameEngine
    {
        private static GameEngine _gameEngine;
        private bool _isNotOver;
        private Scene _scene;
        private SceneRender _sceneRender;
        private GameSettings _gameSettings;

        private GameEngine()
        {

        }

        private GameEngine(GameSettings gameSettings)
        {
            _isNotOver = true;
            _gameSettings = gameSettings;
            _scene = Scene.GetScene(gameSettings);
            _sceneRender = new SceneRender(gameSettings);
        }

        public static GameEngine GetGameEngine(GameSettings gameSettings)
        {
            if (_gameEngine == null)
                _gameEngine = new GameEngine(gameSettings);

            return _gameEngine;
        }

        public void Run()
        {
            int swarmRenderCouner = 0;

            do
            {
                _sceneRender.Render(_scene);

                Thread.Sleep(_gameSettings.GameSpeed);

                _sceneRender.ClearScreen();

                if (swarmRenderCouner == _gameSettings.SwarmSpeed)
                {
                    CalculateSwarmMove();
                    swarmRenderCouner = 0;
                }
                swarmRenderCouner++;

            } while (_isNotOver);
        }

        public void CalculateMovePlayerShipLeft()
        {
            if (_scene.PlayerShip.GameObjectPlace.XCoordinate > 1)
                _scene.PlayerShip.GameObjectPlace.XCoordinate--;
        }

        public void CalculateMovePlayerShipRight()
        {
            if (_scene.PlayerShip.GameObjectPlace.XCoordinate > 1)
                _scene.PlayerShip.GameObjectPlace.XCoordinate++;
        }

        public void CalculateSwarmMove()
        {
            for (int i = 0; i < _scene.Swarm.Count; i++)
            {
                GameObject alienShip = _scene.Swarm[i];

                alienShip.GameObjectPlace.YCoordinate++;

                if (alienShip.GameObjectPlace.YCoordinate == _scene.PlayerShip.GameObjectPlace.YCoordinate)
                    _isNotOver = false;
            }
        }
    }
}
