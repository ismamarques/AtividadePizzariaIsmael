using System.Collections.Generic;

namespace AtividadePizzariaIsmael.Models.ViewModels.RequestDTO
{
    public class PostPizzaDropdownVM
    {
        public PostPizzaDropdownVM()
        {
            Sabores = new List<Sabor>();
            Tamanhos = new List<Tamanho>();
        }

        public List<Sabor> Sabores { get; set; }
        public List<Tamanho> Tamanhos { get; set; }

    }
}
