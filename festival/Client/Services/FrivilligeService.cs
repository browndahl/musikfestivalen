using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    public class FrivilligeService : IFrivilligeService
    {
        private readonly HttpClient httpClient;

        public FrivilligeService(HttpClient httpClient)
        {
            throw new NotImplementedException();
        }

        public Task<Frivillige[]?> GetAllItems()
        {
            throw new NotImplementedException();

        }

        public async Task<Frivillige> GetItem(int id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Frivillige item)
        {
            throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(Frivillige id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Frivillige item)
        {
            throw new NotImplementedException();
        }
    }
}

