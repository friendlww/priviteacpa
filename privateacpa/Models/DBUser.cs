using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace privateacpa.Models
{
    public class DBUser
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [MaxLength(50), Required]
        public string name { get; set; }
    }
}
