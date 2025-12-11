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
        {
        }

        public DbSet<BackEndAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Email> Email { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Endereco> Endereco { get; set; } = default!;
        public DbSet<BackEndAPI.Models.Telefone> Telefone { get; set; } = default!;
    }
}
