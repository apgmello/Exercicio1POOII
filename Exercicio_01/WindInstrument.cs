namespace Exercicio_01
{
    internal abstract class WindInstrument : Instrument
    {
        public double Centimeters { get; }
        public WindInstrument(double price, string color, string maker, double centimeters) 
        : base(InstrumentType.WindInstruments, price, color, maker)
        {
            Centimeters = centimeters;
        }
    }
}
