using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fecomercio.Domain.Entities
{
    [Table("Cobranca")]
    public class Cobranca
    {
        public int Id { get; set; }
        public DateTime DataDeEmissao => DateTime.Now;
        public DateTime DataDeVencimento { get; set; }
        public decimal Valor { get; set; }
        public string Emitente { get; set; } 
        public string Pagador { get; set; }
        public string Descricao { get; set; }
    }
}
