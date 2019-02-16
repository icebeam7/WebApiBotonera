using System;
using Microsoft.EntityFrameworkCore;
using WebApi.Botonera.Models;

namespace WebApi.Botonera.Context
{
    public class Mikuni_BotoneraContext : DbContext
    {
        public virtual DbSet<Defecto> Defecto { get; set; }
        public virtual DbSet<EstacionTrabajoDefecto> EstacionTrabajoDefecto { get; set; }

        public Mikuni_BotoneraContext(DbContextOptions<Mikuni_BotoneraContext> options) : base(options)
        {

        }
    }
}
