using Lumberjack_Typing_Adventure;
using static System.Console;

namespace Lumberjack_Typing_Adventure_ConsoleApp.Menus
{
    public class MainMenu
    {
        public void Start()
        {

            string mainMenuPrompt = "Welcome to Lumberjack Typing Adventure ";
            string[] mainMenuOptions = { "New Game", "Scores", "Exit" };
            Menu mainMenu = new Menu(mainMenuPrompt, mainMenuOptions);
            mainMenu.Options = mainMenuOptions;
            mainMenu.DisplayOptions();
            int selectedMainMenuOption = mainMenu.Run();

            switch (selectedMainMenuOption)
            {
                case 0:
                    Game game = new Game();
                    game.Start();
                    break;

                case 1:
                    ScoreMenu informationMenu = new ScoreMenu();
                    informationMenu.Start();
                    break;

                case 2:
                    Clear();
                    WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
            }
        }

    }


}