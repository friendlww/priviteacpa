using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace privateacpa.Models
{
    public class DBAccountInfo
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [MaxLength(50), Required]
        public int account { get; set; }

        [MaxLength(50), Required]
        public string pword { get; set; }

        
        public int dbuserid { get; set; }

        
        public int dbappid { get; set; }
    }
}
