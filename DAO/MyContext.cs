using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace DAO
{
    public class MyContext : DbContext
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Facu\\bancoFacuTeste1.mdf;Integrated Security=True;Connect Timeout=30";

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Fornecedor> fornecedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, providerOptions => providerOptions.CommandTimeout(600));
        }

    }
}
