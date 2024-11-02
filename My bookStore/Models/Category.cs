using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace My_bookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }  //  It's like to display another name (given on displayname() ) instead of the real name
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="The number should be between 1 to 100 only ")]
        public int Displayorder { get; set; }
    }
}
