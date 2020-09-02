using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WWTCapstone_api.Models
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        //[Column(TypeName = "nvarchar(100)")]
        //public string NickNames { get; set; }

        [Column(TypeName = "int")]
        public string Age { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public DateTime Birthday { get; set; }
        


    }
}

