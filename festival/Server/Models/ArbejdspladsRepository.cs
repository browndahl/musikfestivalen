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

        public bool UpdateArbejdsplads(Arbejdsplads item)
        {
            string sql8 = $"UPDATE arbejdsplads " +
                $"SET arbejdspladsid = '{item.Arbejdspladsid}', arbejdspladsnavn = '{item.Arbejdspladsnavn}', arbejdsbeskrivelse = '{item.Arbejdsbeskrivelse}'" +
                $"WHERE arbejdspladsid = {item.Arbejdspladsid}";
            int rows = db.connection.Execute(sql8);
            return rows > 0;
        }

        public Arbejdsplads FindItem(int id)
        {
            throw new NotImplementedException();
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
