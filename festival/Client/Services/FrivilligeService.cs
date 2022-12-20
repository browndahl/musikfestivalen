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
            //Vi giver en klasse anmodning til at sende Http-request og modtage Http-responses
            this.httpClient = httpClient;
        }

        public Task<Frivillige[]?> GetAllFrivillige()
        {
            //Bemærk, at vi her er det GetFromJsonAsync (HttpGet)
            var result = httpClient.GetFromJsonAsync<Frivillige[]>("api/frivilligeapi");
            return result;

        }

        public async Task<Frivillige> GetItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();  

        }

        public async Task<int> AddFrivillige(Frivillige item)
        {
            //Bemærk, at vi her er det PostAsJsonAsync (HttpPost)
            var result = await httpClient.PostAsJsonAsync("api/frivilligeapi", item);
            return (int)result.StatusCode;

        }

        public async Task<int> DeleteFrivillige(Frivillige frivillig)
        {
            //Bemærk, at vi her er det DeleteAsync (HttpDelete)
            //Vi sletter vores 'Frivilligid' fra vores Frivillige
            var result = await httpClient.DeleteAsync("api/frivilligeapi/" + frivillig.Frivilligid);
            return (int)result.StatusCode;

        }

        public async Task<int> UpdateFrivillig(Frivillige item)
        {
            //Bemærk, at vi her er det PutAsJsonAsync (HttpPut)
            Console.WriteLine("In service update frivillige");
            var result = await httpClient.PutAsJsonAsync("api/frivilligeapi", item);
            return (int)result.StatusCode;
        }
    }
}

