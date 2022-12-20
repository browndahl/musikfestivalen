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
    [Route("api/vagtapi")]
    public class VagtController : ControllerBase
    {
        private readonly IVagtRepository Repository = new VagtRepository();

        public VagtController(IVagtRepository vagtRepository)
        {
            if (Repository == null && vagtRepository != null)
            {
                Repository = vagtRepository;
                Console.WriteLine("Repository initialized");
            }
        }

        //Vi laver en GET-requests. Her henter vi "Alle vagter"
        [HttpGet]
        public IEnumerable<Vagt> GetAllVagt()
        {
            return Repository.GetAllVagt();
        }

        //Vi laver en Delete-request.
        [HttpDelete("{id:int}")]
        public StatusCodeResult DeleteVagt(int id)
        {
            Console.WriteLine("Server: Delete item called: id = " + id);

            bool deleted = Repository.DeleteVagt(id);
            if (deleted)
            {
                Console.WriteLine("Server: Vagt deleted succces");
                int code = (int)HttpStatusCode.OK;
                return new StatusCodeResult(code);
            }
            else
            {
                Console.WriteLine("Server: Vagt deleted fail - not found");
                int code = (int)HttpStatusCode.NotFound;
                return new StatusCodeResult(code);
            }
        }

        //Vi laver en Post-request. Her kan vi tilføje vagt
        [HttpPost]
        public void AddItem(Vagt item)
        {
            Console.WriteLine("Add item called: " + item.ToString());
            Repository.AddItem(item);
        }

        //Her laver en Get-request. Her vi skal finde et item.
        [HttpGet("{id:int}")]
        public Vagt FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

        [HttpPut]
        public void Update(Vagt item)
        {
            Repository.UpdateVagt(item);
            Console.WriteLine("updated vagt");
        }


    }
}
