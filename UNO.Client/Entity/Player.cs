namespace UNO.Client.Entity
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "jugador";
        public List<Card> Cards { get; set; } = new List<Card>();
        public bool Status { get; set; } = true;
        public Player? Next { get; set; }
        public Player? Prev { get; set; }


    }
}
