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
using System.Diagnostics.Metrics;
using System.Net;

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
                string sql2 = $"INSERT INTO frivillige (frivilligid, fornavn, efternavn, alder, email, tlf, adresse, samletantalpoint) VALUES ({item.Frivilligid}, '{item.Fornavn}', '{item.Efternavn}', {item.Alder}, '{item.Email}', '{item.Tlf}', '{item.Adresse}', {item.Samletantalpoint})";
                var items = connection.Execute(sql2);
            }
        }

        public bool DeleteFrivillige(int id)
        {
            string sql5 =$"DELETE FROM frivillige " +
                         $"WHERE frivilligid = {id}";
            using (var connection = db.connection)
            {
                int rows = db.connection.Execute(sql5);
                return rows > 0;
            }

        }
        
        public bool UpdateFrivillig(Frivillige item)
        {
            string sql4 = $"UPDATE frivillige " +
                $"SET fornavn = '{item.Fornavn}', efternavn = '{item.Efternavn}', adresse = '{item.Adresse}', tlf = '{item.Tlf}', alder = {item.Alder}, email = '{item.Email}', samletantalpoint = {item.Samletantalpoint} " +
                $"WHERE frivilligid = {item.Frivilligid}";
            int rows = db.connection.Execute(sql4);
            return rows > 0;

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
                string sql3 = "SELECT * FROM frivillige";
                var Items = connection.Query<Frivillige>(sql3);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Frivilligid}, {item.Fornavn}, {item.Efternavn}, {item.Tlf}");

                }
                return Items.ToList();
            }

        }


    }
}