using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;

namespace festival.Client.Services
{
    //CRUD-funktion
    //'Task' vil vi gerne få koden til at være pakket ind i asynkron-programmering. (F.eks hvis app går i stå, så skal vi kunne få en fejlmeddelse)
    public interface IArbejdspladsService
    {
        Task<Arbejdsplads[]?> GetAllArbejdsplads();

        Task<Arbejdsplads?> GetItem(int id);

        Task<int> AddItem(Arbejdsplads data);

        Task<int> DeleteItem(Arbejdsplads data);

        Task<int> updateItem(Arbejdsplads data);
    }



}