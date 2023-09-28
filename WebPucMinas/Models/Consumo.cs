using MessagePack;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace WebPucMinas.Models
{
    [Tags("Consumo")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem")]
        public int KM { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel TipoCombustivel { get; set; }

        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }
   
        public Veiculo Veiculo { get; set; }


    }
    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
