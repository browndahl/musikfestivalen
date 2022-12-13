using System;
namespace festival.Shared.Models
{
    public class Arbejdsplads
    {
        public int arbejdspladsid { get; set; }
        public string? arbejdspladsnavn { get; set; }
        public int? antalpersoner { get; set; }
        public string? arbejdsbeskrivelse { get; set; }



        //Constructor
        public Arbejdsplads(int arbejdspladsid = 0, string arbejdspladsnavn = "", int antalpersoner = 0, string arbejdsbeskrivelse = "") //Constructor 
        {
            this.arbejdspladsid = arbejdspladsid;
            this.arbejdspladsnavn = arbejdspladsnavn;
            this.antalpersoner = antalpersoner;
            this.arbejdsbeskrivelse = arbejdsbeskrivelse;
        }

    }

}

