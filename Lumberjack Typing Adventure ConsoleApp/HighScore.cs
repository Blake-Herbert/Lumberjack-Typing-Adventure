namespace Lumberjack_Typing_Adventure_ConsoleApp
{
	internal class HighScore
	{
		public HighScore()
		{
		}

		public string playerName { get; set; }
		public int score { get; set; }
		public Guid playerId { get; set; }
	}
}