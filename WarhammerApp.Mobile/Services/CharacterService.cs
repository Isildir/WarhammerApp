using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WarhammerApp.Mobile.Views;

namespace WarhammerApp.Mobile.Services
{
    public static class CharacterService
    {
        private static readonly Uri url = new Uri("http://192.168.0.52:8020/WarhammerProfessionsApp/api/characters/");

        public static async Task<List<Character>> GetCharactersList()
        {
            HttpClientHandler httpClientHandler = new HttpClientHandler()
            {
                Proxy = new WebProxy("http://localhost:3000/")
            };

            var client = new HttpClient()
            {
                BaseAddress = url
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", App.Token);

            try
            {
                client.Timeout = TimeSpan.FromSeconds(10);
                var response = await client.GetAsync($"GetUserCharacters/");
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var data = await Task.Run(() => JsonConvert.DeserializeObject<List<Character>>(responseString));

                    return data;
                }
            }
            catch (Exception e)
            {
            }

            return null;
        }

        private class CharacterT
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string ProfessionName { get; set; }

            public string Race { get; set; }
        }
    }
}