using System;
using System.Net.NetworkInformation;
using MongoDB.Bson.Serialization.Attributes;
using festival.Client;
using festival.Shared.Models;
using festival.Shared;
using System.Net.Http.Json;



namespace festival.Shared.Models
{
    public class Vagt
    {
        //Skal kun kalde på Frivillige (info)
        public int? Vagtid { get; set; }
        public int? Arbejdspladsid { get; set; }
        public int Frivilligid { get; set; }
        public int? Koordinatorid { get; set; }
        public DateTime DateStart { get; set; } = DateTime.Now;
        public int Tidstart { get; set; }
        public int Tidslut { get; set; }
        public bool Optagetledig { get; set; }
        public int Antalpoint { get; set; }



        //Constructor
        public Vagt(int vagttid = 0, int arbejdspladsid = 0, int frivilligid = 0, int koordinatorid = 0, DateTime dateStart = new DateTime(), int tidstart = 0, int tidslut = 0, bool optagetledig = false, int antalpoint = 0)
        {
            this.Vagtid = vagttid;
            this.Arbejdspladsid = arbejdspladsid;
            this.Frivilligid = frivilligid;
            this.Koordinatorid = koordinatorid;
            this.DateStart = dateStart;
            this.Tidstart = tidstart;
            this.Tidslut = tidslut;
            this.Optagetledig = optagetledig;
            this.Antalpoint = antalpoint;

        }

        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Vagt()
        {

        }


    }
}

