using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;

namespace festival.Server.Models
{
    public interface IFrivilligeRepository
    {
        List<Frivillige> GetAllFrivillige();
        Frivillige FindItem(int id);
        void AddItem(Frivillige item);
        bool DeleteItem(int id);
        bool UpdateItem(Frivillige item);

    }
}