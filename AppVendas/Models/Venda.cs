namespace AppVendas.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public int Notafiscal { get; set; }
        public DateTime DatasVenda { get; set; }
        public double TotalVenda { get; set; }
        /* Referencia para a Model Cliente */
        public Guid ClienteId { get; set; }
        public Cliente? Cliente
        {
            get; set;
        }
    }
}
