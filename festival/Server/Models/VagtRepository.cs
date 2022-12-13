using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Driver;

namespace festival.Server.Models
{
    internal class VagtRepository : IVagtRepository
    {
        
        DBContext db = new DBContext();


        public void AddItem(Vagt item)
        {
            //db.Items.InsertOne(item);
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();

            /*
            FilterDefinition<Vagt> item = Builders<Vagt>.Filter.Eq("id", id);
            var deletedItem = db.Items.FindOneAndDelete(item);
            if (deletedItem != null)
                return true;
            else
                return false;
            */
        }

        public bool UpdateItem(Vagt item)
        {
            throw new NotImplementedException();
        }

        public Vagt FindItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vagt> GetAllItems()
        {
            // return db.Items.Find(_ => true).ToList();
            throw new NotImplementedException();
        }


    }
}

