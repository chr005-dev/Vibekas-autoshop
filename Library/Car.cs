namespace Library
{
    public class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool ForSale { get; set; }

        public Car(string maker, string model, int year)
        {
            Maker = maker;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Year} {Maker} {Model}";
        }

    }
}
