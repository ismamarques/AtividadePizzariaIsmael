using System.ComponentModel.DataAnnotations;

namespace AtividadePizzariaIsmael.Models.ViewModels.RequestDTO
{
    public class PostTamanhoVM
    {

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome é obrigatório!")]
        public string Nome { get; set; }
    }
}
