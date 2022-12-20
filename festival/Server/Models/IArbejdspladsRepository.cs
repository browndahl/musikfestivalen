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
    public interface IArbejdspladsRepository
    {
        List<Arbejdsplads> GetAllArbejdsplads();
        Arbejdsplads FindItem(int id);
        void AddItem(Arbejdsplads item);
        bool DeleteItem(int id);
        bool UpdateArbejdsplads(Arbejdsplads item);

    }
}