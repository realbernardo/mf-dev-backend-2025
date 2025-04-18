using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Data Obrigatória")]
        public DateTime Data { get; set; }
        
        [Required(ErrorMessage = "Valor Obrigatório")]
        public decimal Valor { get; set; }
        
        [Required(ErrorMessage = "Km Obrigatório")]
        public int Km { get; set; }

        [DisplayName("Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [DisplayName("Veiculo")]
        [Required(ErrorMessage = "Obrigatório informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel,
        GNV
    }
}
