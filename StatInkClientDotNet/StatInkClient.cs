using Newtonsoft.Json;
using StatInkClientDotNet.RawModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StatInkClientDotNet
{
    public class StatInkClient : IDisposable
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly JsonSerializerSettings jsonSerializerSettings;

        public StatInkClient(string bearerToken)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", bearerToken);

            jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new SnakeCaseContractResolver()
            };
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }

        public async Task<BattleData[]> GetUserBattles(int id)
        {
            var url = $"https://stat.ink/api/v2/user-battle?count=50&order=asc&newer_than={id}";
            var result = await httpClient.GetStringAsync(url);

            return JsonConvert.DeserializeObject<BattleData[]>(result, jsonSerializerSettings);
        }
    }
}
