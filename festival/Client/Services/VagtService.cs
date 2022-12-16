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
            var result = await httpClient.PostAsJsonAsync("api/vagtapi", item);
            return (int)result.StatusCode;

            //var responseStatusCode = response.StatusCode;
            //await foran http, så venter result på at få info før den går videre
            //throw new NotImplementedException();

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

