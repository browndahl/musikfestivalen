using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace festival.Shared.Models
{
    public class Koordinator
    {
        public int Koordinatorid { get; set; }
        public string? Fornavn { get; set; }
        public string? Efternavn { get; set; }
        public string? Email { get; set; }
        public int? Tlf { get; set; }
        public string? Adresse { get; set; }

        //Constructor
        
        public Koordinator(int koordinatorid = 0, string fornavn = "", string efternavn = "", string email = "", int tlf = 0, string adresse ="") //Constructor 
        {
            this.Koordinatorid = koordinatorid;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Email = email;
            this.Tlf = tlf;
            this.Adresse = adresse;
           
        }

        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Koordinator()
        {

        }

    }


}

