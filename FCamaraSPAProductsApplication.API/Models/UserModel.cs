using System.ComponentModel.DataAnnotations;

namespace FCamaraSPAProductsApplication.API
{
    public class UserModel
    {
        [Required]
        [Display(Name = "Nome do usuario")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} characteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "As senhas nao sao as mesmas.")]
        public string ConfirmPassword { get; set; }
    }
}