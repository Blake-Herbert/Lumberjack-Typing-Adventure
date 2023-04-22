using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lumberjack_Typing_Adventure_ConsoleApp;
using Lumberjack_Typing_Adventure_ConsoleApp.Menus;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
    public class Game
	{
		public void Start()
		{
			string playerName;
			do {
				Clear();
				Console.WriteLine("\n Enter player name:");
				playerName = Console.ReadLine();
			} while (string.IsNullOrEmpty(playerName));

			int score = 0;
			int rounds = 5;
			for (int i = 0; i < rounds; i++)
			{
				Clear();
				Prompt prompt = new Prompt();
				string currentPrompt = prompt.RandomSingleWord();
				WriteLine(currentPrompt);
				
				if (currentPrompt == ReadLine()) {score++; }
			}

			Clear();
			WriteLine($"{playerName} scored ({score} / {rounds})");

			// post playerId, playerName, and score to database

			PostScore(playerName, score);






			WriteLine("Press any key to return to the main menu");
			ReadKey();
			MainMenu mainmenu = new MainMenu();
			mainmenu.Start();
		}

		public static async Task PostScore(string playerName, int score)
		{
			var apiUrl = "https://localhost:7251/api/HighScores";
			await ScoreBoard.PostScoreToApi(apiUrl, playerName, score);

		}
	}

	

}
