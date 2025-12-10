using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BackEndAPI.Models;

namespace BackEndAPI.Data
{
    public class BackEndAPIContext : DbContext
    {
        public BackEndAPIContext(DbContextOptions<BackEndAPIContext> options)
            : base(options)
        {
        }

        // DbSets das suas entidades
        public DbSet<Cliente> Cliente { get; set; } = default!;
        public DbSet<PessoaFisica> PessoaFisica { get; set; } = default!;
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; } = default!;
        public DbSet<Email> Email { get; set; } = default!;
        public DbSet<Endereco> Endereco { get; set; } = default!;
        public DbSet<Telefone> Telefone { get; set; } = default!;
        public DbSet<Veiculo> Veiculo { get; set; } = default!;
        public DbSet<Pedido> Pedido { get; set; } = default!;
        public DbSet<Modelo> Modelo { get; set; } = default!;
        public DbSet<VeiculoAcessorio> VeiculoAcessorio { get; set; } = default!;
        public DbSet<Acessorio> Acessorio { get; set; } = default!;
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    // Veiculo 1:1 Pedido
    modelBuilder.Entity<Veiculo>()
        .HasOne(v => v.Pedido)
        .WithOne(p => p.Veiculo)
        .HasForeignKey<Pedido>(p => p.IdVeiculo);

    // Pedido 1:N Cliente
    modelBuilder.Entity<Pedido>()
        .HasMany(p => p.Clientes)
        .WithOne(c => c.Pedido)
        .HasForeignKey(c => c.IdPedido);

    // Modelo 1:N Veiculo
    modelBuilder.Entity<Modelo>()
        .HasMany(m => m.Veiculos)
        .WithOne(v => v.Modelo)
        .HasForeignKey(v => v.IdModelo);

    // VeiculoAcessorio N:N
    modelBuilder.Entity<VeiculoAcessorio>()
        .HasKey(va => new { va.IdVeiculo, va.IdAcessorio });

    modelBuilder.Entity<VeiculoAcessorio>()
        .HasOne(va => va.Veiculo)
        .WithMany(v => v.VeiculosAcessorios)
        .HasForeignKey(va => va.IdVeiculo);

    modelBuilder.Entity<VeiculoAcessorio>()
        .HasOne(va => va.Acessorio)
        .WithMany(a => a.VeiculosAcessorios)
        .HasForeignKey(va => va.IdAcessorio);

    // AcessorioModelo N:N
    modelBuilder.Entity<AcessorioModelo>()
        .HasKey(am => new { am.IdAcessorio, am.IdModelo });

    modelBuilder.Entity<AcessorioModelo>()
        .HasOne(am => am.Acessorio)
        .WithMany(a => a.ModelosAcessorios)
        .HasForeignKey(am => am.IdAcessorio);

    modelBuilder.Entity<AcessorioModelo>()
        .HasOne(am => am.Modelo)
        .WithMany(m => m.AcessoriosModelos)
        .HasForeignKey(am => am.IdModelo);
}

    }
}
