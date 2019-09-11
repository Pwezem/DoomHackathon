using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static DoomHackathon.Player.Player;

namespace DoomHackathon.Player
{
    public class PlayerService
    { 
        private readonly HttpClient _httpClient;
        private readonly string _endpointBase;
        private readonly string playerEndpoint = "/player";
        private readonly string playerActionEndpoint = "/actions";


        public PlayerService(HttpClient httpClient, string endpointBase)
        {
            _httpClient = httpClient;
            _endpointBase = endpointBase;
        }
        
        // GET Requests are going to have to be awaited
        public async Task<Player> GetPlayerStatus()
        {
            var response = await _httpClient.GetStringAsync(_endpointBase + playerEndpoint);
            return JsonConvert.DeserializeObject<Player>(response);
        }

        public async Task<HttpStatusCode> UpdatePlayer(Player playerConfig)
        {
            var content = new StringContent(JsonConvert.SerializeObject(playerConfig));
            var response = await _httpClient.PatchAsync(_endpointBase + playerEndpoint, content);
            return response.StatusCode;
        }

        public async Task<HttpStatusCode> PerformPlayerAction(string action)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new PlayerAction(action)));
            var response = await _httpClient.PostAsync(_endpointBase + playerEndpoint + playerActionEndpoint, content);
            return response.StatusCode;
        }


    }
}
