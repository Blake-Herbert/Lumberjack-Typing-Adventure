Before starting the program be sure to...  
Run the command: "dotnet ef database update",  
Run the database migrations,  
Then run the API and console app in separate windows



Lumberjack Typing Adventure was created as my capstone project for Code Louisville's C# Software Development 2 course.



Feature List:
1. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program

I have satisfied this requirement by adding a list of lumberjack related vocabulary words. These word prompts are chosen at random during the game for the player to type.

2. Make your application an API

I have satisfied this requirement by adding an API containing seeded high scores. The console app sends a get request to the API which can be viewed under the "scores" menu. The console app also sends a post request after completing a game.

3. Make your application asynchonous

I have satisfied this requirement by using an asynchronous method to issue get commands to the API
