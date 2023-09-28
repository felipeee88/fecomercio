namespace Fecomercio.Application.DTO
{
    public class BoletoDTO
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
        public string CodigoDeBarras { get; set; }
        public string LinhaDigitavel { get; set; }
    }
}
