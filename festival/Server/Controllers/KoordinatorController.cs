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
    [Route("api/koordinatorapi")]
    public class KoordinatorController : ControllerBase
    {
        private readonly IKoordinatorRepository Repository = new KoordinatorRepository();

        public KoordinatorController(IKoordinatorRepository koordinatorRepository)
        {
            if (Repository == null && koordinatorRepository != null)
            {
                Repository = koordinatorRepository;
                Console.WriteLine("Repository initialized");
            }
        }
        //Vi laver en GET-requests. Her henter vi "Alle koordinatorer"
        [HttpGet]
        public IEnumerable<Koordinator> GetAllKoordinator()
        {
            return Repository.GetAllKoordinator();
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
        //Vi laver en Post-request. Her kan vi tilføje koordinator
        [HttpPost]
        public void AddItem(Koordinator item)
        {
            Console.WriteLine("Add item called: " + item.ToString());
            Repository.AddItem(item);
        }

        //Her laver en Get-request. Her vi skal finde et item.
        [HttpGet("{id:int}")]
        public Koordinator FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

    }
}
