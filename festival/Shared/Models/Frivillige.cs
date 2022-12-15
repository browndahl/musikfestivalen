using System;
using System.Net.NetworkInformation;
using MongoDB.Bson.Serialization.Attributes;
using festival.Client;
using festival.Shared.Models;
using festival.Shared;
using System.Net.Http.Json;



namespace festival.Shared.Models
{
    public class Frivillige
    {
        public int Frivilligid { get; set; }
        public string? Fornavn { get; set; }
        public string? Efternavn { get; set; }
        public int Alder { get; set; }
        public string? Email { get; set; }
        public int? Tlf { get; set; }
        public string? Adresse { get; set; }
        public int Samletantalpoint { get; set; }
        public bool Aktivstatus { get; set; }
        public int Arbejdspladsid { get; set; }
        //public DateTime DateStart { get; set; } = DateTime.Now;
        //public DateTime DateSlut { get; set; } = DateTime.Now;



        //Constructor
        public Frivillige(int frivilligid = 0, string fornavn = "", string efternavn = "", int alder = 0, string email = "", int tlf = 0, string adresse = "", int samletantalpoint = 0, bool aktivstatus = true ,int arbejdspladsid = 0) //Constructor 
        {
            this.Frivilligid = frivilligid;
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
            this.Alder = alder;
            this.Email = email;
            this.Tlf = tlf;
            this.Adresse = adresse;
            this.Samletantalpoint = samletantalpoint;
            this.Aktivstatus = aktivstatus;
            this.Arbejdspladsid = arbejdspladsid;
            //this.DateStart = dateStart;
            //this.DateSlut = dateSlut;
        }
        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Frivillige()
        {

        }


    }


}

