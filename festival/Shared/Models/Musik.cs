using System;
namespace festival.Shared.Models
{
    public class Musik
    {
        public int Musikid { get; set; }
        public string? Musiknavn { get; set; }
        public string? Datodag { get; set; }



        //Constructor
        public Musik(int musikid = 0, string musiknavn = "", string datodag = "")  //Constructor 
        {
            this.Musikid = musikid;
            this.Musiknavn = musiknavn;
            this.Datodag = datodag;

        }


        //Tom constructor - for at undgå fejl? Tip fra Martin
        public Musik()
        {

        }


    }

}
