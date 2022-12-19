using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;
using System.Net.Http;
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

        public async Task<Arbejdsplads> AddItem(Arbejdsplads item)
        {
            var  result = await httpClient.GetFromJsonAsync<Arbejdsplads>("api/arbejdspladsapi");
            return result;
            //await foran http, så venter result på at få info før den går videre
            //throw new NotImplementedException();

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

