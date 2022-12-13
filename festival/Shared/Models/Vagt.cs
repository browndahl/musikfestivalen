using System;
namespace festival.Shared.Models
{
    public class Vagt
    {
        //Skal kun kalde på Frivillige (info)
        public string? fornavn { get; set; }
        public string? efternavn { get; set; }
        public int tlf { get; set; }
        public string? adresse { get; set; }
        public int frivilligeid { get; set; }
        public int arbejdspladsid { get; set; }
        public int samletantalpoint { get; set; }

        //Constructor
        public Vagt(string fornavn = "", string efternavn = "", int tlf = 0, string adresse = "", int frivilligeid = 0, int arbejdspladsid = 0, int samletantalpoint = 0)
        {

            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.tlf = tlf;
            this.adresse = adresse;
            this.frivilligeid = frivilligeid;
            this.arbejdspladsid = arbejdspladsid;
            this.samletantalpoint = samletantalpoint;
        }
    }
}

