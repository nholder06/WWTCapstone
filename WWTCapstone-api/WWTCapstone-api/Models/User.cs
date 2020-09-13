using System.Collections.Generic;
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

        [Column(TypeName = "varbinary(500)")]
        public byte[] PasswordHash { get; set; }

        [Column(TypeName = "varbinary(500)")]
        public byte[] PasswordSalt { get; set; }
        
        public ICollection<Pet> Pets { get; set;}
    }
}
