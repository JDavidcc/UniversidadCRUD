using Microsoft.EntityFrameworkCore;
using UniversidadCRUD.Data;
using UniversidadCRUD.Models;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new UniversidadCRUDContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<UniversidadCRUDContext>>()))
        {
            if (context == null || context.Alumno == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Alumno.Any())
            {
                return;   // DB has been seeded
            }

            context.Alumno.AddRange(

                new Alumno
                {
                    Nombre = "Jesús David Cervantes Cañedo",
                    Matrícula = 1930083,
                    Carrera = "Ing. En Sistemas Computacionales",
                    Grupo = "SCOMM91"
                },
                new Alumno
                {
                    Nombre = "Ana angela García Carrazco",
                    Matrícula = 1930023,
                    Carrera = "Diseño Grafíco",
                    Grupo = "los de diseño"
                },

                new Alumno
                {
                    Nombre = "Jorge Gabriel Ochoa Ruvalcaba",
                    Matrícula = 1930074,
                    Carrera = "Ing. Industrial",
                    Grupo = "los de industrial"
                },

                new Alumno
                {
                    Nombre = "Erick Castro Soto",
                    Matrícula = 1930060,
                    Carrera = "Ing. En Sistemas Computacionales",
                    Grupo = "SCOMM91"
                }

            );
            context.SaveChanges();
        }
    }
}