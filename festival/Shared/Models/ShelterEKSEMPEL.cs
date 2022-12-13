using System;
using System.Net.Http.Json;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
namespace festival.Shared.Models
{
    public class VagtData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? MongoId { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("adresse")]
        public string Adresse { get; set; }

        [BsonElement("haveBought")]
        public bool HaveBought { get; set; }

        [BsonElement("navn")]
        public string? Navn { get; set; }

        [BsonElement("dateStart")]
        public DateTime DateStart { get; set; } = DateTime.Now;

        [BsonElement("dateSlut")]
        public DateTime DateSlut { get; set; } = DateTime.Now;


        public VagtData(int id = 0, string name = "", int quantity = 0, string email = "", string adresse = "", bool haveBought = true, string navn = "", DateTime dateStart = new DateTime(), DateTime dateSlut = new DateTime()) //Constructor )
        { 
                this.Id = id;
                this.Name = name;
                this.Quantity = quantity;
                this.Email = email;
                this.Adresse = adresse;
                this.HaveBought = haveBought;
                this.Navn = navn;
                this.DateStart = dateStart;
                this.DateSlut = dateSlut;

        }
    }
}

