using System;
namespace DoomHackathon.World
{
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }

    public class Flags
    {
        public bool? MF_SPECIAL { get; set; }
        public bool? MF_COUNTITEM { get; set; }
        public bool? MF_AMBUSH { get; set; }
        public bool? MF_SOLID { get; set; }
        public bool? MF_SHOOTABLE { get; set; }
        public bool? MF_NOBLOOD { get; set; }
        public bool? MF_COUNTKILL { get; set; }
    }

    public class WorldObject : IGameType
    {
        public int id { get; set; }
        public Position position { get; set; }
        public int angle { get; set; }
        public int height { get; set; }
        public int health { get; set; }
        public int typeId { get; set; }
        public string type { get; set; }
        public Flags flags { get; set; }
        public double distance { get; set; }

        public WorldObject()
        {
            position = new Position();
            flags = new Flags();
        }
    }
}
