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

namespace festival.Server.Models
{
    public interface IMusikRepository
    {
        List<Musik> GetAllMusik();
        Musik FindItem(int id);
        void AddItem(Musik item);
        bool DeleteItem(int id);
        bool UpdateItem(Musik item);

    }
}
