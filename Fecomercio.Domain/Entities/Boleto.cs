using System.ComponentModel.DataAnnotations.Schema;

namespace Fecomercio.Domain.Entities
{
    [Table("Boleto")]
    public class Boleto
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Cedente { get; set; }
        public string Documento { get; set; }
        public string Sacado { get; set; } 
        public string NossoNumero { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string CodigoDeBarras => GerarCodigo();
        public string LinhaDigitavel => GerarCodigo();

        public void DiferencaValor(decimal valorPagoAnteriormente)
        {
            this.Valor += this.Valor - valorPagoAnteriormente;
        }

        public string GerarCodigo()
        {
            var codigo = string.Empty;
            var random = new Random();
            for(int i = 0; i < 50; i++)
            {
                codigo += random.Next(9).ToString();
            }

            return codigo;
        }
    }
}
