using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Carstica_Adrian_Lab8.Data;
using Carstica_Adrian_Lab8.Models;

namespace Carstica_Adrian_Lab8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Carstica_Adrian_Lab8.Data.Carstica_Adrian_Lab8Context _context;

        public IndexModel(Carstica_Adrian_Lab8.Data.Carstica_Adrian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
