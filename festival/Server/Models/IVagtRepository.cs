using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;

namespace festival.Server.Models
{
    public interface IVagtRepository
    {
        List<Vagt> GetAllItems();
        Vagt FindItem(int id);
        void AddItem(Vagt item);
        bool DeleteItem(int id);
        bool UpdateItem(Vagt item);

    }
}
