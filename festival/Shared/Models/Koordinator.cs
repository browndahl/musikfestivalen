using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using festival.Shared.Models;
using festival.Client;
using MongoDB.Driver;


namespace festival.Shared.Models
{
    public class Koordinator
    {
        public int koordinatorid { get; set; }
        public string? fornavn { get; set; }
        public string? efternavn { get; set; }
        public string? email { get; set; }
        public int? tlf { get; set; }
        public string? adresse { get; set; }

        //Constructor
        public Koordinator(int koordinatorid = 0, string fornavn = "", string efternavn = "", string email = "", int tlf = 0, string adresse ="") //Constructor 
        {
            this.koordinatorid = koordinatorid;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.email = email;
            this.tlf = tlf;
            this.adresse = adresse;
           
        }

    }


}

