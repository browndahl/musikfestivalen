using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    //CRUD-funktion
    //'Task' vil vi gerne få koden til at være pakket ind i asynkron-programmering. (F.eks hvis app går i stå, så skal vi kunne få en fejlmeddelse)
    public interface IFrivilligeService
    {
        Task<Frivillige[]?> GetAllFrivillige();

        Task<Frivillige?> GetItem(int id);

        Task<int> AddItem(Frivillige data);

        Task<int> DeleteItem(Frivillige data);

        Task<int> updateItem(Frivillige data);
    }

}