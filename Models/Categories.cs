using System.ComponentModel.DataAnnotations;

namespace ItemsApi.Models
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
