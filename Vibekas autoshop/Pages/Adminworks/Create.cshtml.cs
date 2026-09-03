using Library;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Vibekas_autoshop.Pages.Adminworks
{
    public class CreateModel : PageModel
    {
        private readonly CarRepo _service;
        public CreateModel(CarRepo service) => _service = service;

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required, StringLength(200)]
            public string Name { get; set; } = string.Empty;

            [Range(0, 1_000_000)]
            public decimal Price { get; set; }
            public bool ForSale { get; set; }
            public string model { get; set; } = string.Empty;
            public int year { get; set; }
            public string Maker { get; set; } = string.Empty;
        }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _service.Create(Input.Name, Input.model, Input.year, Input.Price, Input.ForSale);
            return RedirectToPage("/Index");
        }
    }
}
