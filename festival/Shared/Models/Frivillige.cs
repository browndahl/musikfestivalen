using System;
namespace festival.Shared.Models
{
    public class Frivillige
    {
        public int frivilligeid { get; set; }
        public string? fornavn { get; set; }
        public string? efternavn { get; set; }
        public string? email { get; set; }
        public int? tlf { get; set; }
        public string? adresse { get; set; }
        public int? arbejdspladsid { get; set; }

    }
}

