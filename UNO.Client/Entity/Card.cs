using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.Client.Entity
{
    public class Card
    {
        private int Number {  get; set; }
        public CardColor Color { get; set; }
        public CardType Type { get; set; }

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
