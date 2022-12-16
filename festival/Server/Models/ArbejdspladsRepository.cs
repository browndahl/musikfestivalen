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

//[BEMÆRK] Repository for Arbejdspladser 
namespace festival.Server.Models
{
    internal class ArbejdspladsRepository : IArbejdspladsRepository
    {
        DBContext db = new DBContext();


        public void AddItem(Arbejdsplads item)
        {

            //throw new NotImplementedException();

            using (var connection = db.connection)
            {
                string sql = "INSERT INTO arbejdsplads (arbejdspladsid, arbejdspladsnavn, antalpersoner, arbejdsbeskrivelse)";
                var Items = connection.Query<Arbejdsplads>(sql);

            }
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

        public bool UpdateItem(Arbejdsplads item)
        {
            throw new NotImplementedException();
        }

        public Arbejdsplads FindItem(int id)
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

        public List<Arbejdsplads> GetAllArbejdsplads()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM arbejdsplads";
                var Items = connection.Query<Arbejdsplads>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Arbejdspladsid}, {item.Arbejdsbeskrivelse}, {item.Antalpersoner}, {item.Arbejdsbeskrivelse}");

                }

                return Items.ToList();
            }

        }
         

    }
}
