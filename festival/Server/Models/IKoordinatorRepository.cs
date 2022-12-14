using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;

namespace festival.Server.Models
{
    public interface IKoordinatorRepository
    {
        List<Koordinator> GetAllKoordinator();
        Koordinator FindItem(int id);
        void AddItem(Koordinator item);
        bool DeleteItem(int id);
        bool UpdateItem(Koordinator item);

    }
}
