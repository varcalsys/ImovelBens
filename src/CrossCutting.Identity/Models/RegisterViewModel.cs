using System.ComponentModel.DataAnnotations;

namespace ImovelBens.CrossCutting.Identity.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = " A {0} senha deve ter no m�nimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [Compare("Password", ErrorMessage = "A senhas digitadas s�o diferentes")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Campo obrigat�rio")]
        public int PessoaId { get; set; }
    }
}