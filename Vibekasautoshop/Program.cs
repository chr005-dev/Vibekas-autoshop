using Library;

CarRepo carrepo = new CarRepo();

carrepo.SetCarForSale(4, 150000);

foreach (var car in carrepo.carsForSale)
{
    Console.WriteLine($"Pris: {car.Price}, Til salg: {car.ForSale}");
}
