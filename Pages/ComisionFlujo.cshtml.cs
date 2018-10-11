using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MiFondoAFP.Pages
{
    public class ComisionFlujoModel : PageModel
    {

        public string Mensaje { get; set; } = "Hola";

        public void OnGet()
        {

        }
    }
}
