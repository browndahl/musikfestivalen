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
        List<VagtData> GetAllItems();
        VagtData FindItem(int id);
        void AddItem(VagtData item);
        bool DeleteItem(int id);
        bool UpdateItem(VagtData item);

    }
}
