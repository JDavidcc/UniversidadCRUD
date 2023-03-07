using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IList<Alumno> Alumno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Alumno != null)
            {
                Alumno = await _context.Alumno.ToListAsync();
            }
        }
    }
}
