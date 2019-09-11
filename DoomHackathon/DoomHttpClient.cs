using System;
using System.Net.Http;
using DoomHackathon.Player;
using DoomHackathon.World;

namespace DoomHackathon
{
    public class DoomHttpClient
    {
        static readonly HttpClient CLIENT = new HttpClient();
        static readonly string URIBASE = "http://localhost:6666/api";

        // Game Object Services
        public PlayerService PlayerService;
        public WorldService WorldService;

        public DoomHttpClient()
        {
            // Provision Services
            PlayerService = new Player.PlayerService(CLIENT, URIBASE);
            WorldService = new World.WorldService(CLIENT, URIBASE);
        }
    }
}
