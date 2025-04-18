using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "obrigatório informar nome do Veículo!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "obrigatório informar placa do Veículo!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "obrigatório informar ano de fabricação do Veículo!")]

        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "obrigatório informar ano do modelo do Veículo!")]
        public int AnoModelo { get; set; }

        
    }
}
