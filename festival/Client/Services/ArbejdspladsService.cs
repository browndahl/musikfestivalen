using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    public class ArbejdspladsService : IArbejdspladsService
    {
        private readonly HttpClient httpClient;

        public ArbejdspladsService (HttpClient httpClient)
        {
            this.httpClient = httpClient;
            //throw new NotImplementedException();
        }

        public Task<Arbejdsplads[]?> GetAllArbejdsplads()
        {
            var result = httpClient.GetFromJsonAsync<Arbejdsplads[]>("api/arbejdspladsapi");
            return result;
            //throw new NotImplementedException();

        }

        public async Task<Arbejdsplads> GetItem(int id)
        {

            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Arbejdsplads item)
        {
       
            throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(Arbejdsplads id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Arbejdsplads item)
        {
            throw new NotImplementedException();
        }
    }
}

