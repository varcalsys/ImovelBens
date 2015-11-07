﻿using System.ComponentModel.DataAnnotations;

namespace ImovelBens.CrossCutting.Identity.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}