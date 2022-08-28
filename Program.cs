// See https://aka.ms/new-console-template for more information

namespace SpaceInvaders
{
    class Program
    {
        static GameEngine gameEngine;
        static GameSettings gameSettings;

        static void Main(string[] args)
        {
            Initialize();
            gameEngine.Run();
        }

        private static void Initialize()
        {
            gameSettings = new GameSettings();
            gameEngine = GameEngine.GetGameEngine(gameSettings);
        }
    }
}
