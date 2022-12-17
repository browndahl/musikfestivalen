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
        public string Arbejdspladsnavn { get; set; }
        public string DatoDag { get; set; }
        public string Dato { get; set; }





        //Constructor
        public Vagt(int vagtid = 0, int arbejdspladsid = 0, int frivilligid = 0, int koordinatorid = 0, DateTime dateStart = new DateTime(), int tidstart = 0, int tidslut = 0, bool optagetledig = false, int antalpoint = 0, string arbejdspladsnavn = "", string datoDag = "", string dato = "")

        {
            this.Vagtid = vagtid;
            this.Arbejdspladsid = arbejdspladsid;
            this.Frivilligid = frivilligid;
            this.Koordinatorid = koordinatorid;
            this.DateStart = dateStart;
            this.Tidstart = tidstart;
            this.Tidslut = tidslut;
            this.Optagetledig = optagetledig;
            this.Antalpoint = antalpoint;
            this.Arbejdspladsnavn = arbejdspladsnavn;
            this.DatoDag = datoDag;
            this.Dato = dato;



        }

        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Vagt()
        {

        }
        //public Vagt(int vagtid = 0)

        //public Vagt(int vagtid = 0, int arbejdspladsid = 0, int frivilligid = 0, int koordinatorid = 0, DateTime dateStart = new DateTime(), int tidstart = 0, int tidslut = 0, bool optagetledig = false, int antalpoint = 0, string arbejdspladsnavn = "")

    }
}

