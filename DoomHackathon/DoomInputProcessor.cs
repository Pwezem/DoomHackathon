using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Action = DoomHackathon.Player.Action;

namespace DoomHackathon
{
    public class DoomInputProcessor : IInputProcessor
    {
        private DoomHttpClient _doomHttpClient;

        public DoomInputProcessor(DoomHttpClient doomHttpClient)
        {
            _doomHttpClient = doomHttpClient;
        }
        
        public async Task Start()
        {
            using (StreamReader r = new StreamReader(@"C:\Users\Tam\DoomHackathon\source\DoomHackathon\DoomHackathon\actions.json"))
            {
                string json = r.ReadToEnd();
                List<DoomHackathon.ActionConfig> actionsQueue = JsonConvert.DeserializeObject<List<DoomHackathon.ActionConfig>>(json);
                
                actionsQueue.ForEach(a =>
                {
                    
                    switch (a.Name)
                    {
                        case Action.forward: 
                            var test =_doomHttpClient.PlayerService.PerformPlayerAction(Action.forward).Result;
                            break;
                        case Action.backward: 
                            test = _doomHttpClient.PlayerService.PerformPlayerAction(Action.backward).Result;
                            break;
                        case Action.shoot:
                            test = _doomHttpClient.PlayerService.PerformPlayerAction(Action.shoot).Result;
                            break;
                        case Action.turn_left:
                            test = _doomHttpClient.PlayerService.PerformPlayerAction(Action.turn_left).Result;
                            break;
                        case Action.turn_right:
                            test = _doomHttpClient.PlayerService.PerformPlayerAction(Action.turn_right).Result;
                            break;
                        case Action.use:
                            test = _doomHttpClient.PlayerService.PerformPlayerAction(Action.use).Result;
                            break;
                        default:
                            throw new NotSupportedException(nameof(a.Name));
                    }
                    Console.WriteLine(a.Name);
                    Thread.Sleep(a.TimeToWaitAfterExecMS);
                });
                
            }
        }
    }
}