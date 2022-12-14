using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Driver;
using Npgsql;
using Dapper;

//[BEMÆRK] Repository for frivillige 
namespace festival.Server.Models
{
    internal class FrivilligeRepository : IFrivilligeRepository
    {
        DBContext db = new DBContext();


        public void AddItem(Frivillige item)
        {
            //db.Items.InsertOne(item);
            throw new NotImplementedException();

        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
            /**
            FilterDefinition<Fri> item = Builders<Koordinator>.Filter.Eq("id", id);
            var deletedItem = db.Items.FindOneAndDelete(item);
            if (deletedItem != null)
                return true;
            else
                return false;
            *///
        }

        public bool UpdateItem(Frivillige item)
        {
            throw new NotImplementedException();
        }

        public Frivillige FindItem(int id)
        {
            throw new NotImplementedException();

            /*
            using (var connection = db.connection )
            {
                string sql = "SELECT * FROM koordinator WHERE koordinatorid = " + id;
                var Items = connection.Query<Koordinator>(sql);
                
                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.koordinatorid}, {item.fornavn}, {item.efternavn}, {item.tlf}");
                }
            }
           */
        }

        public List<Frivillige> GetAllFrivillige()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM frivillige";
                var Items = connection.Query<Frivillige>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Frivilligeid}, {item.Fornavn}, {item.Efternavn}, {item.Tlf}");

                }
                return Items.ToList();
            }

        }


    }
}
