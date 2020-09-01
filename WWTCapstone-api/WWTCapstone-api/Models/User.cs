using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WWTCapstone_api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
