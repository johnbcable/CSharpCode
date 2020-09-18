using System.ComponentModel.DataAnnotations;

namespace Packt.Shared
{
    public class Category
    {
        // these properties map to columns in the database
        public int CategoryID { get; set; }
        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}