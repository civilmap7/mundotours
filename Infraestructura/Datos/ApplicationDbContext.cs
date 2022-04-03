using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //nuestro modelo o entidad tenemos que agregar a nuestro dbContext
        //para que luego se agrege como un tabla de base de datos

        public DbSet<Lugar> _lugar {get; set;}  
    }
}