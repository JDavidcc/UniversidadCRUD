using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversidadCRUD.Data;
using UniversidadCRUD.Models;

namespace UniversidadCRUD.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        private readonly UniversidadCRUD.Data.UniversidadCRUDContext _context;

        public IndexModel(UniversidadCRUD.Data.UniversidadCRUDContext context)
        {
            _context = context;
        }

        public IList<Alumno> Alumnos { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Matrículas { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Matrícula { get; set; }

        public IList<Alumno> Alumno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Alumno
                                            orderby m.Nombre
                                            select m.Nombre;

            //Using System.Linq;
            var Alumnos = from m in _context.Alumno
                          select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Alumnos = Alumnos.Where(s => s.Nombre.Contains(SearchString));
            }
            Alumno = await Alumnos.ToListAsync();
        }
    }
}
