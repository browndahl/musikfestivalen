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
        }

        public Task<Arbejdsplads[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<Arbejdsplads[]>("api/koordinatorapi");
            return result;
        }

        public async Task<Arbejdsplads> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Arbejdsplads>("api/koordinatorapi" + id);
            return result;
        }

        public async Task<int> AddItem(Arbejdsplads data)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinatorapi", data);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> DeleteItem(Arbejdsplads id)
        {
            var response = await httpClient.DeleteAsync("api/koordinatorapi" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> updateItem(Arbejdsplads data)
        {
            throw new NotImplementedException();
        }

        Task<Vagt[]?> IVagtService.GetAllItems()
        {
            throw new NotImplementedException();
        }

        Task<Vagt?> IVagtService.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IVagtService.AddItem(Vagt data)
        {
            throw new NotImplementedException();
        }

        Task<int> IVagtService.DeleteItem(Vagt data)
        {
            throw new NotImplementedException();
        }

        Task<int> IVagtService.updateItem(Vagt data)
        {
            throw new NotImplementedException();
        }
    }

}
