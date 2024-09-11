using AppVendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AppVendas.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cliente> Produtos { get; set; }
        public DbSet<Cliente> Categoria { get; set; }
        public DbSet<Cliente> Venda { get; set; }
        public DbSet<Cliente> ItemDaVenda { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Venda>().ToTable("Venda");
            modelBuilder.Entity<ItemDaVenda>().ToTable("ItemDaVenda");
        }
        public DbSet<AppVendas.Models.Categoria> Categoria_1 { get; set; } = default!;
        public DbSet<AppVendas.Models.ItemDaVenda> ItemDaVenda_1 { get; set; } = default!;
        public DbSet<AppVendas.Models.Produto> Produto { get; set; } = default!;
        public DbSet<AppVendas.Models.Venda> Venda_1 { get; set; } = default!;
    }
}
