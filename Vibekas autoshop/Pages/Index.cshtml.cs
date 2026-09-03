using Library;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Vibekas_autoshop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CarRepo _carRepo;
        public List<Car> CarsForSale { get; set; } = new();

        public IndexModel(CarRepo carRepo)
        {
            _carRepo = carRepo;
        }

        public void OnGet()
        {
           
            var allCars = _carRepo.GetAllCars();
            CarsForSale = allCars.Where(c => c.ForSale).ToList();
        }
    }
}
