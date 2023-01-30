

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlaygroundMvcWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } = default!;
        [Required]
        public string Name { get; set; } = default!;
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; } = default!;
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
