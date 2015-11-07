using System.ComponentModel.DataAnnotations;

namespace ImovelBens.CrossCutting.Identity.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}