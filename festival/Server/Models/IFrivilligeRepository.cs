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
    public interface IFrivilligeRepository
    {
        List<Frivillige> GetAllFrivillige();
        Frivillige FindItem(int id);
        void AddFrivillige(Frivillige item);
        bool DeleteFrivillige(int id);
        bool UpdateFrivillig(Frivillige item);

    }
}