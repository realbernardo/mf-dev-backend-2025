using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar senha")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Adm,
        User
    }
}
