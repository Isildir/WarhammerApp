using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.SignalR
{
    public class CharacterHub : Hub
    {
        public async Task ChangeExperience(int characterId, int value)
        {
            if (GetReceivers(characterId, out IClientProxy clients))
                await clients.SendAsync("changeExperience", value);
        }

        public async Task ChangeMoney(int characterId, int gold, int silver, int bronze)
        {
            if (GetReceivers(characterId, out IClientProxy clients))
                await clients.SendAsync("changeMoney", gold, silver, bronze);
        }

        public async Task ChangeStatisticValue(int characterId, StatisticType type, int currentValue, int maxValue)
        {
            if (GetReceivers(characterId, out IClientProxy clients))
                await clients.SendAsync("changeStatisticValue", (byte)type, currentValue, maxValue);
        }

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

        public async Task RemoveAbility(int characterId, int abilityId)
        {
            if (GetReceivers(characterId, out IClientProxy clients))
                await clients.SendAsync("removeAbility", abilityId);
        }

        public async Task RemoveSkill(int characterId, int skillId)
        {
            if (GetReceivers(characterId, out IClientProxy clients))
                await clients.SendAsync("removeSkill", skillId);
        }

        private readonly Dictionary<string, int> dictionary = new Dictionary<string, int>();

        private bool GetReceivers(int id, out IClientProxy clientProxy)
        {
            var connectionsIds = dictionary.Where(a => a.Value == id).Select(a => a.Key);

            clientProxy = Clients?.Clients(connectionsIds.ToList()) ?? null;

            return clientProxy != null;
        }
    }
}