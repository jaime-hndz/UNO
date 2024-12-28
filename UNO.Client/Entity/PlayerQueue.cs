namespace UNO.Client.Entity
{
    public class PlayerQueue
    {
        public PlayerQueue(Player player) { 
        
            PlayerList = new List<Player>();
            PlayerList.Add(player);
        }
        public List<Player> PlayerList {  get; set; }
    }
}
