using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Driver;

//[BEMÆRK] Repository for booking 
namespace festival.Server.Models
{
    internal class KoordinatorRepository : IKoordinatorRepository
    {
        DBContext db = new DBContext();


        public void AddItem(VagtData item)
        {
            db.Items.InsertOne(item);
        }

        public bool DeleteItem(int id)
        {
            FilterDefinition<VagtData> item = Builders<VagtData>.Filter.Eq("id", id);
            var deletedItem = db.Items.FindOneAndDelete(item);
            if (deletedItem != null)
                return true;
            else
                return false;
        }

        public bool UpdateItem(VagtData item)
        {
            throw new NotImplementedException();
        }

        public VagtData FindItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<VagtData> GetAllItems()
        {
            return db.Items.Find(_ => true).ToList();
        }


    }
}
