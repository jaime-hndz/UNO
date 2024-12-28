using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO.Client.Entity
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public PlayerQueue? Queue { get; set; }
        public Player? Winner { get; set; }
    }
}
