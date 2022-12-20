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
            //Vi giver en klasse anmodning til at sende Http-request og modtage Http-responses
            this.httpClient = httpClient;
        }

        public Task<Vagt[]?> GetAllVagt()
        {
            //Bemærk, at vi her er det GetFromJsonAsync (HttpGet)
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/vagtapi");
            return result;

        }

        public async Task<Vagt> GetItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }

        public async Task<int> AddItem(Vagt item)
        {
            //Bemærk, at vi her er det PostAsJsonAsync (HttpPost)
            //await foran http, så venter result på at få info før den går videre
            var result = await httpClient.PostAsJsonAsync("api/vagtapi", item);
            return (int)result.StatusCode;
            

        }

        public async Task<int> DeleteVagt(Vagt vagt)
        {
            //Bemærk, at vi her er det DeleteAsync (HttpDelete)
            //Vi sletter vores 'Vagtid' fra vores vagt
            var result = await httpClient.DeleteAsync("api/vagtapi/" + vagt.Vagtid);
            return (int)result.StatusCode;

        }

        public async Task<int> UpdateVagt(Vagt item)
        {
            //Bemærk, at vi her er det PutAsJsonAsync (HttpPut)
            Console.WriteLine("In service update vagt");
            var result = await httpClient.PutAsJsonAsync("api/vagtapi", item);
            return (int)result.StatusCode;
        }

       
    }
}

