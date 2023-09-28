using MessagePack;
using System.ComponentModel.DataAnnotations;


namespace WebPucMinas.Models
{
    [Tags("Usuario")]
    public class Usuario
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Email { get; set; }
        
        [Required(ErrorMessage = "O campo perfil é obrigatório")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        Usuario

    }
}
