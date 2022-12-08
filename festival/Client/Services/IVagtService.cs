using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;
namespace festival.Client.Services
{
    //CRUD-funktion
    //'Task' vil vi gerne få koden til at være pakket ind i asynkron-programmering. (F.eks hvis app går i stå, så skal vi kunne få en fejlmeddelse)
    public interface IVagtService
    {
        Task<VagtData[]?> GetAllItems();

        Task<VagtData?> GetItem(int id);

        Task<int> AddItem(VagtData data);

        Task<int> DeleteItem(VagtData data);

        Task<int> updateItem(VagtData data);
    }

}