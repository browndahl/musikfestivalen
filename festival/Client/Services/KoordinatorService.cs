using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    public class KoordinatorService : IKoordinatorService
    {
        private readonly HttpClient httpClient;

        public KoordinatorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Koordinator[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<Koordinator[]>("api/koordinatorapi");
            return result;
        }

        public async Task<Koordinator> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Koordinator>("api/koordinatorapi" + id);
            return result;
        }

        public async Task<int> AddItem(Koordinator data)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinatorapi", data);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> DeleteItem(Koordinator id)
        {
            var response = await httpClient.DeleteAsync("api/koordinatorapi" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> updateItem(Koordinator data)
        {
            throw new NotImplementedException();
        }

    }

}
