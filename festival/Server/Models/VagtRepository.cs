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


        public void AddItem(Vagt item)
        {

            using (var connection = db.connection)
            {
                string sql1 = $"INSERT INTO vagt (vagtid, arbejdspladsid, frivilligid, koordinatorid, antalpoint, tidstart, tidslut, datodag) values ({item.Vagtid}, {item.Arbejdspladsid}, {item.Frivilligid}, {item.Koordinatorid},{item.Antalpoint}, {item.Tidstart},{item.Tidslut}, '{item.Datodag}')";
                var Items = connection.Execute(sql1);
            }

            //throw new NotImplementedException();

        }
        //Query = Select
        //Execute = Insert, delete og de andre 
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

        public bool UpdateVagt(Vagt item)
        {
            string sql7 = $"UPDATE vagt " +
            $"SET tidstart = {item.Tidstart}, tidslut = {item.Tidslut}, antalpoint ={item.Antalpoint}, arbejdspladsid = {item.Arbejdspladsid}" + $"WHERE vagtid = {item.Vagtid}";
            int rows = db.connection.Execute(sql7);
            return rows > 0;

        }

        //$"SET vagtid = {item.Vagtid}, arbejdspladsid = {item.Arbejdspladsid}, frivilligid = {item.Frivilligid}, koordinatorid = {item.Koordinatorid}, tidstart = {item.Tidstart}, tidslut = {item.Tidslut}, optagetledig = {item.Optagetledig}, antalpoint ={item.Antalpoint}, arbejdspladsnavn ='{item.Arbejdspladsnavn}',datodag='{item.Datodag}', dato='{item.Dato}'" +
        // $"SET tidstart = {item.Tidstart}, tidslut = {item.Tidslut}, antalpoint ={item.Antalpoint}" +


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
                    Console.WriteLine($"{item.Vagtid}");
                    //Console.WriteLine($"{item.Vagtid}, {item.Arbejdspladsid}, {item.Frivilligid}, {item.Koordinatorid}");

                }
                return Items.ToList();
            }



        }


    }
}