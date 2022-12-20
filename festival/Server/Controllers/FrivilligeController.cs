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
    [Route("api/frivilligeapi")]
    public class FrivilligeController : ControllerBase
    {
        private readonly IFrivilligeRepository Repository = new FrivilligeRepository();

        public FrivilligeController(IFrivilligeRepository frivilligeRepository)
        {
            if (Repository == null && frivilligeRepository != null)
            {
                Repository = frivilligeRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        //Vi laver en GET-request. Her henter vi "Alle frivillige"
        [HttpGet]
        public IEnumerable<Frivillige> GetAllFrivillige()
        {
            return Repository.GetAllFrivillige();
        }

        //Vi laver en Delete-request.
        [HttpDelete("{id:int}")]
        public StatusCodeResult DeleteFrivillige(int id)
        {
            Console.WriteLine("Server: Delete item called: id = " + id);

            bool deleted = Repository.DeleteFrivillige(id);
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

        //Vi laver en Post-request. Her kan vi tilføje frivillige
        [HttpPost]
        public void AddFrivillige(Frivillige item)
        {
            Console.WriteLine("Add frivillige called: " + item.ToString());
            Repository.AddFrivillige(item);
        }

        //Her laver en Get-request. Her vi skal finde et item.
        [HttpGet("{id:int}")]
        public Frivillige FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

        //Her laver vi en Put-request. Her kan vi opdatere på vores data.
        [HttpPut]
        public void Update(Frivillige item)
        {
            Repository.UpdateFrivillig(item);
            Console.WriteLine("updated frillig");
        }
    }
}
