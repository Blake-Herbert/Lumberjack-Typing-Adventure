using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Numerics;


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
	}
}


