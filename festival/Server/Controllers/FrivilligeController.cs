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

        [HttpGet]
        public IEnumerable<Frivillige> GetAllFrivillige()
        {
            return Repository.GetAllFrivillige();
        }

        [HttpDelete("{id:int}")]
        public StatusCodeResult DeleteFrivillige(int id)
        {
            Console.WriteLine("Server: Delete item called: id = " + id);

            //Skal stå void her?
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

        [HttpPost]
        public void AddFrivillige(Frivillige item)
        {
            Console.WriteLine("Add frivillige called: " + item.ToString());
            Repository.AddFrivillige(item);
        }


        [HttpGet("{id:int}")]
        public Frivillige FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

        [HttpPut]
        public void Update(Frivillige item)
        {
            Repository.UpdateFrivillig(item);
            Console.WriteLine("updated frillig");
        }

    }
}
