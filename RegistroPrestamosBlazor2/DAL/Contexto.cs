using Microsoft.EntityFrameworkCore;
using RegistroPrestamosBlazor2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosBlazor2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
