// See https://aka.ms/new-console-template for more information

namespace SpaceInvaders
{
    class Program
    {
        static GameEngine gameEngine;
        static GameSettings gameSettings;
        static UIController gameController;

        static void Main(string[] args)
        {
            Initialize();
            gameEngine.Run();
        }

        private static void Initialize()
        {
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);
            gameController = new UIController();

            gameController.OnAPressed += (obj, args) => gameEngine.CalculateMovePlayerShipLeft();
            gameController.OnDPressed += (obj, args) => gameEngine.CalculateMovePlayerShipRight();
            gameController.OnSpacePressed += (obj, args) => gameEngine.Shoot();

            Thread uIThread = new Thread(gameController.StartMove);
            uIThread.Start();
        }
    }
}
