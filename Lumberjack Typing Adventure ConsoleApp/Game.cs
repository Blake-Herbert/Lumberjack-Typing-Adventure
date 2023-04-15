using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lumberjack_Typing_Adventure_ConsoleApp.Menus;
using static System.Console;

namespace Lumberjack_Typing_Adventure
{
    public class Game
	{
		public void Start()
		{	
			string playerName = Console.ReadLine();
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
			Guid playerId = Guid.NewGuid();
			
			Console.WriteLine($"{playerId} {playerName} {score}");





			// post and put playerId, playerName, and score to database

			WriteLine("Press any key to return to the main menu");
			ReadKey();
			MainMenu mainmenu = new MainMenu();
			mainmenu.Start();
		}

	}
}
