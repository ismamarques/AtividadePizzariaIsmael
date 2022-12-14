using AtividadePizzariaIsmael.Models.Intefaces;
using System;
using System.Collections.Generic;

namespace AtividadePizzariaIsmael.Models
{
    public class Tamanho : IEntidade
    {


        public Tamanho(string nome)
        {

            Nome = nome;


            DataCadastro = DateTime.Now;
            DataAlteracao = DataCadastro;

        }

        public int Id { get; set; }
        public string Nome { get; set; }


        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }


        public List<Pizza> Pizzas { get; set; }

        public void AtualizarDados(string nome)
        {
            if (Nome.Length < 1)
                return;

            Nome = nome;


            DataAlteracao = DateTime.Now;


        }



    }
}
