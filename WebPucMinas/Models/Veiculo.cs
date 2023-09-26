using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPucMinas.Models
{
    
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Placa é obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório")]
        public string Modelo { get; set; }
        
        [Required(ErrorMessage = "O campo Ano de Fabricação é obrigatório")]
                public int AnoFabricacao { get; set; }
        
        [Required(ErrorMessage = "O campo Ano do Modelo é obrigatório")]
        public int AnoModelo { get; set; }
    }
}
