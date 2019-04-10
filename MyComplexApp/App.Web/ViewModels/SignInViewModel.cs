﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.ViewModels
{
    public class SignInViewModel
    {
        [Required]
        public string EMail { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
