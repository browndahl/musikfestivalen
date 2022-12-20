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

//[BEMÆRK] Repository for vagt 
namespace festival.Server.Models
{
    internal class VagtRepository : IVagtRepository
    {
        DBContext db = new DBContext();

        //Vi tilføjer en  ny vagt
        public void AddItem(Vagt item)
        {
            using (var connection = db.connection)
            {
                string sql1 = $"INSERT INTO vagt (vagtid, arbejdspladsid, koordinatorid, antalpoint, tidstart, tidslut, datodag) values ({item.Vagtid}, {item.Arbejdspladsid}, {item.Koordinatorid},{item.Antalpoint}, {item.Tidstart},{item.Tidslut}, '{item.Datodag}')";
                var Items = connection.Execute(sql1);
            }


        }
        //Query = Select
        //Execute = Insert, delete og de andre
        //Vi sletter vagter hernede
        public bool DeleteVagt(int id)
        {
            string sql6 = $"DELETE FROM vagt " +
                         $"WHERE vagtid = {id}";
            using (var connection = db.connection)
            {
                int rows = db.connection.Execute(sql6);
                return rows > 0;
            }

        }

        //Her opdaterer vi en vagt 
        public bool UpdateVagt(Vagt item)
        {
            string sql7 = $"UPDATE vagt " +
            $"SET tidstart = {item.Tidstart}, tidslut = {item.Tidslut}, antalpoint ={item.Antalpoint}, arbejdspladsid = {item.Arbejdspladsid}, frivilligid ={item.Frivilligid}" + $" WHERE vagtid = {item.Vagtid}";
            Console.WriteLine("repository vagt sql: " + sql7);

            int rows = db.connection.Execute(sql7);
            Console.WriteLine("rows changed : "+rows);
            return rows > 0;

        }
  

        //Her kan vi finde en vagt
        public Vagt FindItem(int id)
        {
            //Vi implementerer ikke denne funktion.
            throw new NotImplementedException();

        }

        //Her henter vi alle vagter
        public List<Vagt> GetAllVagt()
        {
            using (var connection = db.connection)
            {
                string sql = "SELECT * FROM vagt";
                var Items = connection.Query<Vagt>(sql);

                foreach (var item in Items)
                {
                    Console.WriteLine($"{item.Vagtid}");
                }
                return Items.ToList();
            }

        }


    }
}