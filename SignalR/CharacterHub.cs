using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerProfessionApp.SignalR
{
    public class CharacterHub : Hub
    {
        public Dictionary<string, int> dictionary = new Dictionary<string, int>();

        public override Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;

            var httpContext = Context.GetHttpContext();
            var characterId = httpContext.Request.Query["characterId"];

            if (int.TryParse(characterId, out int value))
                dictionary.Add(connectionId, value);

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            var connectionId = Context.ConnectionId;

            if (dictionary.ContainsKey(connectionId))
                dictionary.Remove(connectionId);

            return base.OnDisconnectedAsync(exception);
        }

        public async Task OnMoneyChange(int id, int gold, int silver, int bronze)
        {
            if (Clients != null)
                await Clients.Clients(GetFilteredConnections(id)).SendAsync("onMoneyChange", gold, silver, bronze);
        }

        private IReadOnlyList<string> GetFilteredConnections(int id) => dictionary.Where(a => a.Value == id).Select(a => a.Key).ToList();
    }
}