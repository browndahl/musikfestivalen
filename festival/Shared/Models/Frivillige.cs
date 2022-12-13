using System;
namespace festival.Shared.Models
{
    public class Frivillige
    {
        public int frivilligeid { get; set; }
        public string? fornavn { get; set; }
        public string? efternavn { get; set; }
        public int alder { get; set; }
        public string? email { get; set; }
        public int? tlf { get; set; }
        public string? adresse { get; set; }
        public int samletantalpoint { get; set; }
        public bool aktivstatus { get; set; }
        public int arbejdspladsid { get; set; }



        //Constructor
        public Frivillige(int frivilligeid = 0, string fornavn = "", string efternavn = "", int alder = 0, string email = "", int tlf = 0, string adresse = "", int samletantalpoint = 0, bool aktivstatus = true ,int arbejdspladsid = 0) //Constructor 
        {
            this.frivilligeid = frivilligeid;
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.alder = alder;
            this.email = email;
            this.tlf = tlf;
            this.adresse = adresse;
            this.samletantalpoint = samletantalpoint;
            this.aktivstatus = aktivstatus;
            this.arbejdspladsid = arbejdspladsid;
        }

    }


}

