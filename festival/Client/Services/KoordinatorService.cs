using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Client;
using MongoDB.Driver;
using Npgsql;
using Dapper;


namespace festival.Client.Services
{
    public class KoordinatorService : IKoordinatorService
    {
        private readonly HttpClient httpClient;

        public KoordinatorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            //throw new NotImplementedException();
        }

        public Task<Koordinator[]?> GetAllKoordinator()
        {
            var result = httpClient.GetFromJsonAsync<Koordinator[]>("api/koordinatorapi");
            return result;
            //throw new NotImplementedException();

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

