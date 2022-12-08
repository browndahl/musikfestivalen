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
            throw new NotImplementedException();
        }

        public Task<VagtData[]?> GetAllItems()
        {
            throw new NotImplementedException();

        }

        public async Task<VagtData> GetItem(int id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> AddItem(VagtData item)
        {
            throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(VagtData id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(VagtData item)
        {
            throw new NotImplementedException();
        }

    }

}
