using System.ComponentModel.DataAnnotations.Schema;

namespace Fecomercio.Domain.Entities
{
    [Table("Comissao")]
    public class Comissao
    {
        public int Id { get; set; }
        public string NomeVendedor { get; set; }
        public decimal ValorDaVenda { get; set; }
        public decimal PercentualDeComissao { get; set; }
        public decimal ValorDaComissao => ValorDaVenda * PercentualDeComissao / 100;
        public DateTime DataDaVenda { get; set; }
    }
}
