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
    [Route("api/musikapi")]
    public class MusikController : ControllerBase
    {
        private readonly IMusikRepository Repository = new MusikRepository();

        public MusikController(IMusikRepository musikRepository)
        {
            if (Repository == null && musikRepository != null)
            {
                Repository = musikRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        public IEnumerable<Musik> GetAllMusik()
        {
            return Repository.GetAllMusik();
        }

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

        [HttpPost]
        public void AddItem(Musik item)
        {
            Console.WriteLine("Add item called: " + item.ToString());
            Repository.AddItem(item);
        }


        [HttpGet("{id:int}")]
        public Musik FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

    }
}
