using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StatInkClientDotNet
{
    public class StatInkService : IDisposable
    {
        private readonly StatInkClient statInkClient;

        public StatInkService(string bearerToken)
        {
            statInkClient = new StatInkClient(bearerToken);
        }

        public void Dispose()
        {
            statInkClient.Dispose();
        }

        public async Task DownloadAllData(int startSplatInkBattleId, string outputDirectory, int intervalSecond = 5)
        {
            intervalSecond = Math.Max(intervalSecond, 1);
            var id = startSplatInkBattleId;

            while (true)
            {
                var battleDataArray = await statInkClient.GetUserBattles(id);

                foreach (var battleData in battleDataArray)
                {
                    var tmp = JsonConvert.SerializeObject(battleData, Formatting.Indented);
                    File.WriteAllText(Path.Combine(outputDirectory, $"{battleData.SplatnetNumber}.json"), tmp);
                }

                if (battleDataArray.Length == 0)
                {
                    break;
                }

                id = battleDataArray
                    .Select(x => x.Id)
                    .First();

                await Task.Delay(TimeSpan.FromSeconds(intervalSecond));
            }
        }
    }
}
