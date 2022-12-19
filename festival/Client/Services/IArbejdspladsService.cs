using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using festival.Client.Services;
using festival.Shared.Models;
using System.Net.Http.Json;
using System.Net.Http;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Client;
using MongoDB.Driver;
using Npgsql;
using Dapper;

namespace festival.Client.Services
{
    //CRUD-funktion
    //'Task' vil vi gerne få koden til at være pakket ind i asynkron-programmering. (F.eks hvis app går i stå, så skal vi kunne få en fejlmeddelse)
    public interface IArbejdspladsService
    {
        Task<Arbejdsplads[]?> GetAllArbejdsplads();

        Task<Arbejdsplads?> GetItem(int id);

        Task<Arbejdsplads> AddItem(Arbejdsplads data);

        Task<int> DeleteItem(Arbejdsplads data);

        Task<int> UpdateArbejdsplads(Arbejdsplads data);
    }



}