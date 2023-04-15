using Newtonsoft.Json;
using Lumberjack_Typing_Adventure_ConsoleApp;

namespace Lumberjack_Typing_Adventure_ConsoleApp.Menus
{
    public class ScoreMenu
    {


        public async Task GetApi()
        {
            var apiUrl = "https://localhost:7251/api/HighScores";
            var data = await ScoreBoard.GetDataFromApi(apiUrl);
            var result = JsonConvert.DeserializeObject<dynamic>(data);





            if (data != null)
            {
                foreach (var item in result) { Console.WriteLine(item.playerName + " " + item.score); }

            }
            else
            {
                Console.WriteLine("Failed to get data from API.");
            }
        }




        public void Start()
        {

            GetApi();

            //get scores from database
            //allow deletion from database



            string scoreMenuPrompt = "Here's a list of high scores";
            string[] scoreMenuOptions = { "Return to the main menu" };
            Menu scoreMenu = new Menu(scoreMenuPrompt, scoreMenuOptions);
            scoreMenu.Options = scoreMenuOptions;
            scoreMenu.DisplayOptions();
            scoreMenu.Run();

            MainMenu mainMenu = new MainMenu();
            mainMenu.Start();

        }
    }


}