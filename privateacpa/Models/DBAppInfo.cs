using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace privateacpa.Models
{
    public class DBAppInfo
    {
        [Key, DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [MaxLength(50), Required]
        public string appname { get; set; }

        [MaxLength(50), Required]
        public string remark { get; set; }
    }
}
