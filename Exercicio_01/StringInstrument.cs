namespace Exercicio_01
{
    internal abstract class StringInstrument : Instrument
    {
        public int NumString { get; }

        public StringInstrument( double price, string color, string maker, int numString) 
        : base(InstrumentType.String, price, color, maker)
        {
            NumString = numString;
        }
    }
}
