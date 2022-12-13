using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using festival.Server.Models;
using festival.Shared.Models;
using System.Net;

namespace festival.Server.Controllers
{
    [ApiController]
    [Route("api/frivilligeapi")]
    public class FrivilligeController : ControllerBase
    {
        private readonly IFrivilligeRepository Repository = new FrivilligeRepository();

        public FrivilligeController(IFrivilligeRepository vagtRepository)
        {
            if (Repository == null && vagtRepository != null)
            {
                Repository = vagtRepository;
                Console.WriteLine("Repository initialized");
            }
        }


        [HttpGet]
        public IEnumerable<Frivillige> GetAllFrivillige()
        {
            return Repository.GetAllFrivillige();
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
        public void AddItem(Frivillige item)
        {
            Console.WriteLine("Add item called: " + item.ToString());
            Repository.AddItem(item);
        }


        [HttpGet("{id:int}")]
        public Frivillige FindItem(int id)
        {
            var result = Repository.FindItem(id);
            return result;
        }

    }
}
