using System.ComponentModel.DataAnnotations;
using festival.Client.Models;
namespace festival.Client.Models
{
    //Kalender 
    public class Product
    {
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{PublishedDate}";
        }

    }
}