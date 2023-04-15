using Microsoft.EntityFrameworkCore;
using Lumberjack_Typing_Adventure_API.Entities;
using System;
using System.Collections.Generic;

namespace Lumberjack_Typing_Adventure_API
{
	public class ScoreboardContext : DbContext
	{
		public DbSet<HighScore> HighScores { get; set; }

		public string DbPath { get; }

		public ScoreboardContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "scoreboard.db");
		}

		// The following configures EF to create a Sqlite database file in the
		// special "local" folder for your platform.
		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbPath}");
	}

}
