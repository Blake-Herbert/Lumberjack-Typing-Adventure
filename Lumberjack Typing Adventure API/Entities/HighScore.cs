namespace Lumberjack_Typing_Adventure_API.Entities
{
	public class HighScore
	{
		public Guid id { get; set; }
		public string playerName { get; set; }
		public int score { get; set; }
	}
}
