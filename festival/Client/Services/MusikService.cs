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
    public class MusikService : IMusikService
    {
        private readonly HttpClient httpClient;

        public MusikService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            //throw new NotImplementedException();
        }

        public Task<Musik[]?> GetAllMusik()
        {
            var result = httpClient.GetFromJsonAsync<Musik[]>("api/musikapi");
            return result;
            //throw new NotImplementedException();

        }

        public async Task<Musik> GetItem(int id)
        {

            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Musik item)
        {
            var result = await httpClient.PostAsJsonAsync("api/musikapi", item);
            return (int)result.StatusCode;

            //var responseStatusCode = response.StatusCode;
            //await foran http, så venter result på at få info før den går videre
            //throw new NotImplementedException();

        }

        public async Task<int> DeleteItem(Musik id)
        {
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Musik item)
        {
            throw new NotImplementedException();
        }
    }
}

