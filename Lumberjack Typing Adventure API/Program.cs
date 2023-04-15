using Lumberjack_Typing_Adventure_API;
using Lumberjack_Typing_Adventure_API.Entities;

using (var context = new ScoreboardContext())
{
	context.Database.EnsureCreated();

	if (context.HighScores.FirstOrDefault(hs => hs.playerName == "test") is null)
	{
		context.HighScores.Add(new HighScore
		{
			playerName = "test",
			score = 0
		});
	}

	context.SaveChanges();
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
