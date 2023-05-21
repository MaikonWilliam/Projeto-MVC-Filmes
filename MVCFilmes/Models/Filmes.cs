using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int ID { get; set; }
       
        [Required(ErrorMessage ="Este campo é obrigatório!")]
        public string Titulo { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [DataType(DataType.Date)]
        [Display(Name = "Data Lançamento")]     
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Este campo é obrigatório!"), StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$" , ErrorMessage ="Não deve inserir números!")]
        public string Genero { get; set; } = string.Empty;
        
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Display(Name ="Avaliação")]
        [Range(0,10 , ErrorMessage ="Apenas números de 1 a 10!")]
        public int ? Avaliacao { get; set; }


    }
}
