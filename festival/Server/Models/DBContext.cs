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
       public NpgsqlConnection connection;
        public DBContext()
        {
            var connString = "UserID=yirvpqjj;Password=IIMyzjDw47RJxavbso7sAwMv_CEvNMyr;Host=dumbo.db.elephantsql.com;Port=5432;Database=yirvpqjj";
            connection = new NpgsqlConnection(connString);
        }

    }
}

