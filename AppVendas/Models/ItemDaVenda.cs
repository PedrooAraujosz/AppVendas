namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        public Guid VendaId { get; set; }
        public Venda? Venda { get; set; }

        /* Relacionando com a tabela Produtos */
        public Guid Produtoid { get; set; }
        public Produto? Produto { get; set; }

        public double QtdadeVendida { get; set; }
        public double ValoTotalDoitem { get; set; }

    }
}
