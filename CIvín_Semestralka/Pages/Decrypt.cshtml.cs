using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIvín_Semestralka.Logic;
using CIvín_Semestralka.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CIvín_Semestralka.Logic;
using CIvín_Semestralka.Model;

namespace CIvín_Semestralka.Pages
{
    public class DecryptModel : PageModel
    {
        [BindProperty]
        public ItemPage ItemPage { get; set; }

        public IActionResult OnGet()
        {
            ItemPage = new ItemPage();
            return Page();
        }

        public IActionResult OnPost()
        {
            ItemPage.Text = CryptoService.Decipher(ItemPage.Cipher, ItemPage.Key);
            return Page();
        }
    }
}
