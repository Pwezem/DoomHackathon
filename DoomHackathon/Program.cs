using System;
using System.Collections.Generic;
using System.Net.Http;
using DoomHackathon.World;
using DoomHackathon.Player;

namespace DoomHackathon
{
    class Program
    {

        private static IInputProcessor _inputProcessor;
        static void Main(string[] args)
        {
            
            _inputProcessor = new DoomInputProcessor(new DoomHttpClient());
            
            _inputProcessor.Start();
            
            /*Console.WriteLine("Weaponizing Demons, for a Brighter Tomorrow!\n");

            ////////////////////////
            // HTTP Client creates Endpoint Services
            ;


            ////////////////////////////
            // Testing API
            var player = doomClient.PlayerService.GetPlayerStatus();
            Console.WriteLine("Player Health: " + player.Result.health);

            var world = doomClient.WorldService.GetWorldStatus();
            Console.WriteLine("Level: " + world.Result.episode);

            var doors = doomClient.WorldService.GetDoors();
            List<Door> doorsList = doors.Result;
            foreach (Door obj in doorsList)
            {
                Console.WriteLine("Door " + obj.id + " is " + obj.state);
            }

            var worldObjects = doomClient.WorldService.GetWorldObjects();
            List<WorldObject> worldObjectsList = worldObjects.Result;
            //foreach(WorldObject obj in worldObjectsList) {
                //Console.WriteLine("Found Object: " + obj.type);
            //}
            
            Player.Player updatedPlayer = new Player.Player();
           
            updatedPlayer.health = 500;
            
            var response = doomClient.PlayerService.UpdatePlayer(updatedPlayer);
            Console.WriteLine("Updated Player: " + response.Result.ToString());

            var response1 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            Console.WriteLine("BANG!");
            var response2 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            Console.WriteLine("BANG!");
            var response3 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            Console.WriteLine("BANG!");
            var response4 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            var response5 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            var response6 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            Console.WriteLine("RUN AWAY!!");

            // TODO Add PATCH command for opening Doors, will probably open all doors at the beginning
            // There is a big scary monster man in the last door though, opening that too early
            // may be a problem

            //
            ///////////////////////////////*/

        }
    }
}
