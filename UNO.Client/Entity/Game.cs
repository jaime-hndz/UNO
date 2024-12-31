using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNO.Client.Services;

namespace UNO.Client.Entity
{
    public class Game
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        private PlayerQueue? Queue;
        public Player? Winner;
        public Card Current { get; set; } = new Card();

        public Game(Player player) {
            Queue = new PlayerQueue(player);
        }

        public void SetWinner(Player winner)
        {
            Winner = winner;
            Console.WriteLine("el ganador es: " + winner.Name);
        }

        public void ShowCurrent()
        {
            Console.WriteLine("Current: ");
            DeckService.PrintCard(Current);
            Console.WriteLine("____________");

        }

        public void PlayTurn(Player player)
        {

            Console.Clear();
            ShowCurrent();

            int i = 0;
            foreach (var card in player.Cards)
            {
                i++;
                Console.Write(i + ".\n");
                DeckService.PrintCard(card);
            }

            if (player.Cards.Count() == 1)
            {
                Console.WriteLine("UNO!!!!!!");
            }

            if (CheckPlayable(player.Cards))
            {

                try
                {
                    int opt = Int32.Parse(Console.ReadLine());

                    Card selected = player.Cards[opt - 1];

                    DeckService.PrintCard(selected);

                    if (selected.Color == Current.Color || selected.Number == Current.Number)
                    {
                        Current = selected;
                        player.Cards.RemoveAt(opt - 1);
                    }
                    else
                    {
                        Console.WriteLine("Esa carta no puede ser elegida");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Ha ocurrido un error al seleccionar la carta");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("No tienes cartas debes sacar una del mazo");
                Console.ReadKey();
                player.Cards.Add(new Card());
            }

            if (player.Cards.Count == 0)
            {
                SetWinner(player);
            }


        }

        public bool CheckPlayable(List<Card> cards)
        {
            foreach (var card in cards)
            {

                if (card.Color == Current.Color || card.Number == Current.Number)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
