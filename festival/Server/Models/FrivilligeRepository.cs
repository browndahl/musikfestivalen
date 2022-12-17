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


        public void AddFrivillige(Frivillige item)
        {

            using (var connection = db.connection)
            {
                string sql = $"INSERT INTO frivillige (Frivilligid, Fornavn, Efternavn, Alder, Email,Tlf,Adresse) VALUES ({item.Frivilligid}, {item.Fornavn}), {item.Efternavn}, {item.Alder},{item.Email},{item.Tlf},{item.Adresse}";
                var Items = connection.Execute(sql);
            }

            //db.Items.InsertOne(item);
            //throw new NotImplementedException();

        }

        public bool DeleteFrivillige(int id)
        {
            throw new NotImplementedException();

            /*
            using (var connection = db.connection)
            {
                string sql = "DELETE FROM frivillige WHERE frivilligid " + id ;
                var Items = connection.Execute(sql);

            }
            */
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
                    Console.WriteLine($"{item.Frivilligid}, {item.Fornavn}, {item.Efternavn}, {item.Tlf}");

                }
                return Items.ToList();
            }

        }


    }
}
