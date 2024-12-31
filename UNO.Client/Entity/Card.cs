using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.Client.Entity
{
    public class Card
    {
        public Card() {
            Array values = Enum.GetValues(typeof(CardColor));
            Random random = new Random();

            Random rnd = new Random();
            Number = rnd.Next(1, 10);
            Color = (CardColor)rnd.Next(0, 4);
        }

        public int Number {  get; set; }
        public CardColor Color { get; set; }
        public CardType Type { get; set; } = CardType.Standar;

    }

    public enum CardColor
    {
        Blue,
        Green,
        Red,
        Yellow
    }

    public enum CardType
    {
        Standar
    }
}
