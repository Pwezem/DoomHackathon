using System;
namespace DoomHackathon.World
{
     public class Door : IGameType
    {
            public int id { get; set; }
            public int specialType { get; set; }
            public string state { get; set; }
            public string keyRequired { get; set; }
            public double distance { get; set; }
    }
}
