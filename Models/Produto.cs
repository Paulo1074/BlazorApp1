using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Produto
    {
        [Required(ErrorMessage ="Campo obrigatório")]
        public string Nome { get; set; }

        [Range(0,999999, ErrorMessage ="Informe um valor adequado")]
        public int Quantidade { get; set; }

        [Range(0.1,999999, ErrorMessage ="Informe um preço adequado")]
        public double Preco { get; set; }

        public double ValorEstoqueTotal()
        {
             return Quantidade;
        }
    }
}
