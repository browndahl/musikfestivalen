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
    public class FrivilligeService : IFrivilligeService
    {
        private readonly HttpClient httpClient;

        public FrivilligeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            //throw new NotImplementedException();
        }

        public Task<Frivillige[]?> GetAllFrivillige()
        {
            var result = httpClient.GetFromJsonAsync<Frivillige[]>("api/frivilligeapi");
            return result;
            //throw new NotImplementedException();

        }

        public async Task<Frivillige> GetItem(int id)
        {
            
            throw new NotImplementedException();

        }

        public async Task<int> AddFrivillige(Frivillige item)
        {
            var result = await httpClient.PostAsJsonAsync("api/frivilligeapi", item);
            return (int)result.StatusCode;
            //throw new NotImplementedException();

        }

        public async Task<int> DeleteFrivillige(Frivillige id)
        {
            //throw new NotImplementedException();
            //Bemærk skal det være PostAsJsonAsync eller DeleteAsJsonAsync
            var result = await httpClient.DeleteAsync("api/frivilligeapi" + id);
            return (int)result.StatusCode;

        }

        public async Task<int> updateItem(Frivillige item)
        {
            throw new NotImplementedException();
        }
    }
}

