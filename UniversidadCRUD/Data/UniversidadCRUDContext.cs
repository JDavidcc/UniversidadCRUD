using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversidadCRUD.Models;

namespace UniversidadCRUD.Data
{
    public class UniversidadCRUDContext : DbContext
    {
        public UniversidadCRUDContext (DbContextOptions<UniversidadCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<UniversidadCRUD.Models.Alumno> Alumno { get; set; } = default!;
    }
}
