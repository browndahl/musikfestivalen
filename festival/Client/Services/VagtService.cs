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

        public Task<Vagt[]?> GetAllItems()
        {
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/vagtapi");
            return result;
        }

        public async Task<Vagt> GetItem(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Vagt>("api/vagtapi" + id);
            return result;
        }

        public async Task<int> AddItem(Vagt data)
        {
            var response = await httpClient.PostAsJsonAsync("api/vagtapi", data);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> DeleteItem(Vagt id)
        {
            var response = await httpClient.DeleteAsync("api/vagtapi" + id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> updateItem(Vagt data)
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
