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
            //Vi giver en klasse anmodning til at sende Http-request og modtage Http-responses
            this.httpClient = httpClient;
        }

        public Task<Koordinator[]?> GetAllKoordinator()
        {
            //Bemærk, at vi her er det GetFromJsonAsync (HttpGet)
            var result = httpClient.GetFromJsonAsync<Koordinator[]>("api/koordinatorapi");
            return result;

        }

        public async Task<Koordinator> GetItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();

        }

        public async Task<int> AddItem(Koordinator item)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }

        public async Task<int> DeleteItem(Koordinator id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();

        }

        public async Task<int> updateItem(Koordinator item)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }
    }
}

