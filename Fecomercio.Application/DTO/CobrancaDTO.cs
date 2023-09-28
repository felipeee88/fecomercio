namespace Fecomercio.Application.DTO
{
    public class CobrancaDTO
    {
        private bool clienteEspecial;
        private decimal valorDesconto;

        public int Id { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public decimal Valor { get; set; }
        public string Emitente { get; set; }
        public string Pagador { get; set; }
        public string Descricao { get; set; }
        public bool ClienteEspecial
        {
            get => clienteEspecial;
            set
            {
                var random = new Random();
                clienteEspecial = random.Next(2) == 1;
            }
        }

        public decimal ValorDesconto
        {
            get => valorDesconto;
            set
            {
                var random = new Random();
                valorDesconto = random.Next(20);
            }
        }
    }
}
