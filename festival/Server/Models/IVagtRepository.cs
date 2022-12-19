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
    public interface IVagtRepository
    {
        List<Vagt> GetAllVagt();
        Vagt FindItem(int id);
        void AddItem(Vagt item);
        bool DeleteVagt(int id);
        bool UpdateVagt(Vagt item);
        bool UpdateVagt2(Vagt item);


    }
}
