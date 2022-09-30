


//changed topic from video games to board game (I know more of them. lol)

using System.Security.Cryptography.X509Certificates;

List<string> boardGames = new List<string>() { "Monopoly", "Cashflow", "Clue", "Scrabble","Settlers of Catan",
    "Ticket to Ride", "Risk" };

//order the list of games by length of game name.  


Console.WriteLine("--- Wrote out the foreach loop -----");
var nameLength = boardGames.OrderBy(x => x.Length);

foreach (var game in nameLength)
{
    Console.WriteLine(game);

}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--- Wrote using 1 line of code -----");
//can also write this in an even more concise way:
boardGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));