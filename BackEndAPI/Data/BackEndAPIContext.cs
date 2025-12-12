using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Models;

namespace BackEndAPI.Data
{
    public class BackEndAPIContext : DbContext
    {
        public BackEndAPIContext (DbContextOptions<BackEndAPIContext> options)
            : base(options)
        { }

        public DbSet<BackEndAPI.Models.Contato> Contato { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Endereco> Endereco { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Veiculo> Veiculo { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ------------------------------
            // Relacionamento Pedido -> Cliente
            // ------------------------------
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(u => u.Compras)
                .HasForeignKey(p => p.ClienteId) 
                .OnDelete(DeleteBehavior.Restrict);

            // ------------------------------
            // Relacionamento Pedido -> Vendedor
            // ------------------------------
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Vendedor)
                .WithMany(u => u.Vendas)
                .HasForeignKey(p => p.VendedorId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
