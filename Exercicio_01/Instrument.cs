namespace Exercicio_01
{
    abstract class Instrument
    {
        public InstrumentType Type { get; }
        public double Price { get; }
        public string Color { get; }
        public string Maker { get; }

        public Instrument() { }
        public Instrument(InstrumentType type, double price, string color, string maker)
        {
            Type = type;
            Price = price;
            Color = color;
            Maker = maker;
        }
    }
}
