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
            //Vi giver en klasse anmodning til at sende Http-request og modtage Http-responses
            this.httpClient = httpClient;
        }

        public Task<Arbejdsplads[]?> GetAllArbejdsplads()
        {
            //Bemærk, at vi her er det GetFromJsonAsync (HttpGet)
            var result = httpClient.GetFromJsonAsync<Arbejdsplads[]>("api/arbejdspladsapi");
            return result;

        }

        public async Task<Arbejdsplads> GetItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException(); 
        }

        public async Task<Arbejdsplads> AddItem(Arbejdsplads item)
        {
            //await foran http, så venter result på at få info før den går videre
            //Bemærk, at vi her er det PostAsJsonAsync (HttpPost)
            var result = await httpClient.GetFromJsonAsync<Arbejdsplads>("api/arbejdspladsapi");
            return result;
        }

        public async Task<int> DeleteItem(Arbejdsplads id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException(); 
        }

        public async Task<int> UpdateArbejdsplads(Arbejdsplads item)
        {
            //Bemærk, at vi her er det PutAsJsonAsync (HttpPut)
            Console.WriteLine("In service update arbejdsplads");
            var result = await httpClient.PutAsJsonAsync("api/arbejdspladsapi", item);
            return (int)result.StatusCode;
        }
    }
}

