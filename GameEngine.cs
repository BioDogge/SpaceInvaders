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
            do
            {
                _sceneRender.ClearScreen();
                _sceneRender.Render(_scene);

                Thread.Sleep(_gameSettings.GameSpeed);

            } while (_isNotOver);
        }
    }
}
