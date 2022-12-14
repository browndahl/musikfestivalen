using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    public class VagtService : IVagtService
    {
        private readonly HttpClient httpClient;

        public VagtService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            //throw new NotImplementedException();
        }

        public Task<Vagt[]?> GetAllVagt()
        {
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/vagtapi");
            return result;
            //throw new NotImplementedException();

        }

        public async Task<Vagt> GetItem(int id)
        {

            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Vagt item)
        {
            throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(Vagt id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Vagt item)
        {
            throw new NotImplementedException();
        }
    }
}

