﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WWTCapstone_api.Models
{
    public class UserDto
    {
        
        public int Id { get; set; }
        
        public string FullName { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
