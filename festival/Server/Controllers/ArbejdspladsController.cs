using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using festival.Server.Models;
using festival.Shared.Models;
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


namespace festival.Server.Controllers
{
    [ApiController]
    [Route("api/arbejdspladsapi")]
    public class ArbejdspladsController : ControllerBase
    {
        private readonly IArbejdspladsRepository Repository = new ArbejdspladsRepository();

        public ArbejdspladsController (IArbejdspladsRepository arbejdsRepository)
        {
            if (Repository == null && arbejdsRepository != null)
            {
                Repository = arbejdsRepository;
                Console.WriteLine("Repository initialized");
            }
        }
        //Vi laver en GET-requests. Her henter vi "Alle arbejdsplads"
        [HttpGet]
        public IEnumerable<Arbejdsplads> GetAllArbejdsplads()
        {
            return Repository.GetAllArbejdsplads();
        }
        //Vi laver en Delete-request.
        [HttpDelete("{id:int}")]
        public StatusCodeResult DeleteItem(int id)
        {
            Console.WriteLine("Server: Delete item called: id = " + id);

            bool deleted = Repository.DeleteItem(id);
            if (deleted)
            {
                Console.WriteLine("Server: Item deleted succces");
                int code = (int)HttpStatusCode.OK;
                return new StatusCodeResult(code);
            }
            else
            {
                Console.WriteLine("Server: Item deleted fail - not found");
                int code = (int)HttpStatusCode.NotFound;
                return new StatusCodeResult(code);
            }
        }
        //Vi laver en Post-request. Her kan vi tilføje arbejdsplads
        [HttpPost]
        public void AddItem(Arbejdsplads item)
        {
            Console.WriteLine("Add item called: " + item.ToString());
            Repository.AddItem(item);
        }

        //Her laver en Get-request. Her vi skal finde et item.
        [HttpGet("{id:int}")]
        public Arbejdsplads FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }
        //Her laver vi en Put-request. Her kan vi opdatere på vores data.
        [HttpPut]
        public void Update(Arbejdsplads item)
        {
            Repository.UpdateArbejdsplads(item);
            Console.WriteLine("updated frillig");
        }

    }
}
