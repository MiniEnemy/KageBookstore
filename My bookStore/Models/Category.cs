using System.ComponentModel.DataAnnotations;

namespace My_bookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       public int Displayorder { get; set; }
    }
}
