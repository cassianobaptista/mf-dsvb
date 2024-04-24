using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        [Display(Name = "Descrição")]
        public string? descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public Decimal valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quilometragem!")]
        public int km { get; set; }

        [Display(Name = "Tipo de combustível")]
        public TipoCombustivel tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o veículo!")]
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo? Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Alcool
    }
}
