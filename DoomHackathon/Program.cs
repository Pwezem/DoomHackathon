using System;
using System.Collections.Generic;
using System.Net.Http;
using DoomHackathon.World;
using DoomHackathon.Player;
using System.Threading.Tasks;

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

            //var doors = doomClient.WorldService.GetDoors();
            //List<Door> doorsList = doors.Result;

            //foreach (Door door in doorsList)
            //{
            //    Console.WriteLine("Opening door " + door.id);
            //    doomClient.WorldService.OpenDoor(door.id.ToString());
            //}
            ////////////////////////////
            // Testing API
            //var player = doomClient.PlayerService.GetPlayerStatus();
            //Console.WriteLine("Player Health: " + player.Result.health);
            //Console.WriteLine("Coordinates: (" + player.Result.position.x + "," + player.Result.position.y + "," + player.Result.position.z + ")");

            //var world = doomClient.WorldService.GetWorldStatus();
            //Console.WriteLine("Level: " + world.Result.episode);

            //var doors = doomClient.WorldService.GetDoors();
            //List<Door> doorsList = doors.Result;
            //foreach (Door obj in doorsList)
            //{
            //    Console.WriteLine("Door " + obj.id + " is " + obj.state);
            //}

            //var worldObjects = doomClient.WorldService.GetWorldObjects();
            ////List<WorldObject> worldObjectsList = worldObjects.Result;
            ////foreach(WorldObject obj in worldObjectsList) {
            //    //Console.WriteLine("Found Object: " + obj.type);
            ////}

            //Player.Player updatedPlayer = new Player.Player();

            //updatedPlayer.health = 500;

            //var response = doomClient.PlayerService.UpdatePlayer(updatedPlayer);
            //Console.WriteLine("Updated Player: " + response.Result.ToString());

            //var response1 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            //Console.WriteLine("BANG!");
            //var response2 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            //Console.WriteLine("BANG!");
            //var response3 = doomClient.PlayerService.PerformPlayerAction(Player.Action.shoot);
            //Console.WriteLine("BANG!");

            //Console.WriteLine("Coordinates: (" + player.Result.position.x.ToString() + "," + player.Result.position.y.ToString() + "," + player.Result.position.z.ToString()+ ")");
            ////var response4 = doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right);
            ////doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right);


            //Console.WriteLine("Coordinates: (" + player.Result.position.x.ToString() + "," + player.Result.position.y.ToString() + "," + player.Result.position.z.ToString()+ ")");
            ////var response5 = doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right);
            ////var response6 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            ////var response7 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            ////var response8 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            ////var response9 = doomClient.PlayerService.PerformPlayerAction(Player.Action.forward);
            ////Console.WriteLine("RUN AWAY!!");

            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);
            //Program.turnRightTestNoWait(doomClient);



            // TODO Add PATCH command for opening Doors, will probably open all doors at the beginning
            // There is a big scary monster man in the last door though, opening that too early
            // may be a problem

            //
            ///////////////////////////////

        }

        //public async System.Threading.Tasks.Task OpenAllDoorsAsync()
        //{
        //    var doors = DoomHttpClient.WorldService.GetDoors();
        //    List<Door> doorsList = doors.Result;

<<<<<<< HEAD
            //
            ///////////////////////////////*/
            //    foreach (Door door in doorsList)
            //    {
            //        Console.WriteLine("Opening door " + door.id);
            //        await _httpClient.WorldService.OpenDoor(door.id.ToString());
            //    }
            //}

            /*public static async void turnRightTestNoWait(DoomHttpClient doomClient)
            {
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
            }
    
            public static async void turnRightTestWait(DoomHttpClient doomClient)
            {
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(800);
                await doomClient.PlayerService.PerformPlayerAction(Player.Action.turn_right); Console.WriteLine("BANG!");
            }*/
        }
    }
}
