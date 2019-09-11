using System;
namespace DoomHackathon.World
{
    public class World : IGameType
    {
        public int episode { get; set; }
        public int map { get; set; }
        public string lights { get; set; }
    }
}
