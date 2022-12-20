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

//[BEMÆRK] Repository for koordinator 
namespace festival.Server.Models
{
    internal class MusikRepository : IMusikRepository
    {
        DBContext db = new DBContext();


        public void AddItem(Musik item)
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

        public bool UpdateItem(Musik item)
        {
            throw new NotImplementedException();
        }

        public Musik FindItem(int id)
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

        public List<Musik> GetAllMusik()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM musik";
                var Items = connection.Query<Musik>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Musikid}, {item.Musiknavn}, {item.Datodag}");

                }
                return Items.ToList();
            }



        }


    }
}
