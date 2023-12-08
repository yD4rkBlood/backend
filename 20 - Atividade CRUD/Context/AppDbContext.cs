using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _20___Atividade_CRUD.Models;
using App.Models;

namespace _20___Atividade_CRUD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}