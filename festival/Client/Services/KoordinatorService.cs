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
            throw new NotImplementedException();
        }

        public Task<Koordinator[]?> GetAllKoordinator()
        {
            throw new NotImplementedException();

        }

        public async Task<Koordinator> GetItem(int id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Koordinator item)
        {
            throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(Koordinator id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Koordinator item)
        {
            throw new NotImplementedException();
        }
    }
}

