using System;
using DoomHackathon.World;
using DoomHackathon.Player;
using System.Net.Http;
using System.Collections.Generic;

namespace DoomHackathon
{
    public class EventScripts
    {
        private readonly DoomHttpClient _httpClient;

        public EventScripts(DoomHttpClient client)
        {
            _httpClient = client;
        }

        public async System.Threading.Tasks.Task OpenAllDoorsAsync()
        {
            var doors = _httpClient.WorldService.GetDoors();
            List<Door> doorsList = doors.Result;

            foreach (Door door in doorsList)
            {
                Console.WriteLine("Opening door " + door.id);
                await _httpClient.WorldService.OpenDoor(door.id.ToString());
            }
        }

        public void KillAllEnemies()
        {
            throw new NotImplementedException();
        }

        public void ExplodeEverything()
        {
            throw new NotImplementedException();
        }
    }
}
