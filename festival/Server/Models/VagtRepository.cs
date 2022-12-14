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

//[BEMÆRK] Repository for vagt 
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
            /**
            FilterDefinition<Koordinator> item = Builders<Koordinator>.Filter.Eq("id", id);
            var deletedItem = db.Items.FindOneAndDelete(item);
            if (deletedItem != null)
                return true;
            else
                return false;
            *///
        }

        public bool UpdateItem(Vagt item)
        {
            throw new NotImplementedException();
        }

        public Vagt FindItem(int id)
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

        public List<Vagt> GetAllVagt()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM vagt";
                var Items = connection.Query<Vagt>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Vagtid}, {item.Arbejdspladsid}, {item.Frivilligid}, {item.Koordinatorid}");

                }
                return Items.ToList();
            }



        }


    }
}
