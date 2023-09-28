namespace Fecomercio.Application.DTO
{
    public class ComissaoDTO
    {
        public int Id { get; set; }
        public string NomeVendedor { get; set; }
        public decimal ValorDaVenda { get; set; }
        public decimal PercentualDeComissao { get; set; }
        public decimal ValorDaComissao => ValorDaVenda * PercentualDeComissao / 100;
        public DateTime DataDaVenda { get; set; }
    }
}
