using System.ComponentModel.DataAnnotations;

namespace CRUDApp.Models
{
    public class Product
    {
        [Key]
         public int productId { get; set; }
        [Required]
        public string productName { get; set; }
        public  int price { get; set; }
        public string prodDesc { get; set; }

    }
}
