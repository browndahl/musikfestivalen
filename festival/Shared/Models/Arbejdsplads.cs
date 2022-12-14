using System;
namespace festival.Shared.Models
{
    public class Arbejdsplads
    {
        public int Arbejdspladsid { get; set; }
        public string? Arbejdspladsnavn { get; set; }
        public int? Antalpersoner { get; set; }
        public string? Arbejdsbeskrivelse { get; set; }



        //Constructor
        public Arbejdsplads(int arbejdspladsid = 0, string arbejdspladsnavn = "", int antalpersoner = 0, string arbejdsbeskrivelse = "") //Constructor 
        {
            this.Arbejdspladsid = arbejdspladsid;
            this.Arbejdspladsnavn = arbejdspladsnavn;
            this.Antalpersoner = antalpersoner;
            this.Arbejdsbeskrivelse = arbejdsbeskrivelse;
        }


        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Arbejdsplads()
        {

        }


    }

}

