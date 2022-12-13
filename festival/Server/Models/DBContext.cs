using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Driver;
using Dapper;
using Npgsql;

namespace festival.Server.Models
{
    public class DBContext
    {
        public DBContext()
        {
            var connString = "UserID=yirvpqjj;Password=IIMyzjDw47RJxavbso7sAwMv_CEvNMyr;Host=dumbo.db.elephantsql.com;Port=5432;Database=yirvpqjj";

            using (var connection = new NpgsqlConnection(connString))
            {
                var datas = connection.Query<DBContext>(sql);
                foreach (var data in datas)
                {
                    Console.WriteLine($"{data.arbejdspladsid}, {data.arbejdspladsnavn}, {data.antalpersoner}, {data.arbejdsbeskrivelse}");
                }
            }

        }

        //public int arbejdspladsid { get; set; }
        //public string? arbejdspladsnavn { get; set; }
        //public int? antalpersoner { get; set; }
        //public string? arbejdsbeskrivelse { get; set; }
    }
}

