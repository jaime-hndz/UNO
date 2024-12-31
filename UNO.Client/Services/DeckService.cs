using UNO.Client.Entity;

namespace UNO.Client.Services
{
    public class DeckService
    {
        public static List<Card> GenDeck(int count)
        {
            List<Card> list = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Card());
            }

            return list;

        }

        public static void PrintCard(Card card)
        {
            switch (card.Color)
            {
                case CardColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case CardColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case CardColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case CardColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"┌─┐");
            Console.WriteLine($"|{card.Number}|");
            Console.WriteLine($"└─┘");
            Console.ResetColor();

        }

        public static void PlayerTurn(Player player)
        {
            foreach (Card card in player.Cards)
            {
                PrintCard(card);
            }
        }
    }
}
