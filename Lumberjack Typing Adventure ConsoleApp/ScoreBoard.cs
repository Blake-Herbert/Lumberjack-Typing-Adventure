using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using System.Net.Http.Json;
using System.Text.Json.Nodes;


namespace Lumberjack_Typing_Adventure_ConsoleApp
{

	public static class ScoreBoard
	{
		public static readonly HttpClient _httpClient = new HttpClient();

		public static async Task<string> GetDataFromApi(string apiUrl)
		{

			var response = await _httpClient.GetAsync(apiUrl);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				return content;
			}

			return null;
		}

		public static async Task PostScoreToApi(string apiUrl, string playerName, int score)
		{
			await _httpClient.PostAsJsonAsync(apiUrl, new HighScore()
			{
				playerName = playerName,
				score = score,
				playerId = Guid.NewGuid()
			});
		}

	}
}


