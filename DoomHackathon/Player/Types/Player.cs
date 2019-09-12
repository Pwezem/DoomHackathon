using System;
namespace DoomHackathon.Player
{ 
    public class Position
    {
        public double x { get; set; }
        public double y { get; set; }
        public int z { get; set; }
    }

    public class Flags
    {
        public bool MF_SOLID { get; set; }
        public bool MF_SHOOTABLE { get; set; }
        public bool MF_DROPOFF { get; set; }
        public bool MF_PICKUP { get; set; }
        public bool MF_NOTDMATCH { get; set; }
    }

    public class KeyCards
    {
        public bool blue { get; set; }
        public bool red { get; set; }
        public bool yellow { get; set; }
    }

    public class CheatFlags
    {
    }

    public class PlayerAction
    {
        public string type { get; set; }

        public PlayerAction(string actionType)
        {
            type = actionType;
        }
    }

    public class Action
    {
        public const string shoot = "shoot";
        public const string forward = "forward";
        public const string backward = "backward";
        public const string turn_left = "turn-left";
        public const string turn_right = "turn-right";
        public const string use = "use";
    };

    public class Player : IGameType
    {
        public int id { get; set; }
        public Position position { get; set; }
        public int angle { get; set; }
        public int height { get; set; }
        public int health { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public Flags flags { get; set; }
        public int armor { get; set; }
        public int kills { get; set; }
        public int items { get; set; }
        public int secrets { get; set; }
        public int weapon { get; set; }
        public KeyCards keyCards { get; set; }
        public CheatFlags cheatFlags { get; set; }

        public Player()
        {
            position = new Position();
            flags = new Flags();
            keyCards = new KeyCards();
            cheatFlags = new CheatFlags();
        }
    }
}
