


//changed topic from video games to board game (I know more of them. lol)

List<string> boardGames = new List<string>() { "Monopoly", "Cashflow", "Clue", "Scrabble","Settlers of Catan",
    "Ticket to Ride", "Risk" };

//order the list of games by length of game name.  

var nameLength = boardGames.OrderBy(x => x.Length);

foreach (var game in nameLength)
{
    Console.WriteLine(game);

}
