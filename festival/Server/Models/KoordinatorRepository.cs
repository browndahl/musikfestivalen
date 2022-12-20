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
    internal class KoordinatorRepository : IKoordinatorRepository
    {
        DBContext db = new DBContext();


        public void AddItem(Koordinator item)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();

        }

        public bool DeleteItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }

        public bool UpdateItem(Koordinator item)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }

        public Koordinator FindItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();
        }

        //Her kan vi hente alle koordinatorer-data
        public List<Koordinator> GetAllKoordinator()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM koordinator";
                var Items = connection.Query<Koordinator>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Koordinatorid}, {item.Fornavn}, {item.Efternavn}, {item.Tlf}");

                }
                return Items.ToList();
            }



        }


    }
}
