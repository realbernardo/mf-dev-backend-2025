using System.ComponentModel;
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
        [DisplayName("Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "obrigatório informar ano do modelo do Veículo!")]
        [DisplayName("Ano do Modelo")]
        public int AnoModelo { get; set; }

        
    }
}
