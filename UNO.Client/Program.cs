using UNO.Client.Services;
using UNO.Client.Entity;



Console.Write("Escribe tu nombre: ");
Player player = new Player(Console.ReadLine());


Console.WriteLine("Jugadores: ");
Console.WriteLine(player.Name);

player.Cards = DeckService.GenDeck(7);

Game game = new Game(player);

while (game.Winner == null)
{
game.PlayTurn(player);

}

Console.WriteLine("Juego terminado");


Console.ReadKey();