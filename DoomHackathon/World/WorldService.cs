using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DoomHackathon.Player;
using Newtonsoft.Json;

namespace DoomHackathon.World
{
    public class WorldService
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpointBase;
        private readonly string worldEndpoint = "/world";
        private readonly string worldObjectEndpoint = "/world/objects";
        private readonly string doorEndpoint = "/world/doors";

        public WorldService(HttpClient httpClient, string endpointBase)
        {
            _httpClient = httpClient;
            _endpointBase = endpointBase;
        }

        // GET Requests are going to have to be awaited
        public async Task<World> GetWorldStatus()
        {
            var response = await _httpClient.GetStringAsync(_endpointBase + worldEndpoint);
            return JsonConvert.DeserializeObject<World>(response);
        }

        public async Task<List<WorldObject>> GetWorldObjects()
        {
            var response = await _httpClient.GetStringAsync(_endpointBase + worldObjectEndpoint);
            return JsonConvert.DeserializeObject<List<WorldObject>>(response);
        }

        public async Task<List<Door>> GetDoors()
        {
            var response = await _httpClient.GetStringAsync(_endpointBase + doorEndpoint);
            return JsonConvert.DeserializeObject<List<Door>>(response);
        }

        public async Task<HttpStatusCode> OpenDoor(string doorId)
        {
            var response = await _httpClient.DeleteAsync(_endpointBase + doorEndpoint + "/" + doorId);
            return response.StatusCode;
        }
    }
}
