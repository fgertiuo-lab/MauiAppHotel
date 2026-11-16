namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto? QuartoSelecionado { get; set; }
        public int QntdAdultos { get; set; }
        
        public int QntdCriancas { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                if (QuartoSelecionado == null)
                    return 0;

                double valor_adultos = QntdAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntdCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;

                return total;
            }
        }
    }
}
