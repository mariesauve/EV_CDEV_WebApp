using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int Supplier { get; set; }
        [Required]
        [DisplayName("Item Name")]
        public int Product { get; set; }
        public string? VSN { get; set; }

        public string? Location { get; set; }
    }
}


