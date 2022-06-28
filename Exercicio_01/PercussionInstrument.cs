namespace Exercicio_01
{
    internal abstract class PercussionInstrument : Instrument
    {
        public string? Material { get; }
        public PercussionInstrument(double price, string color, string maker, string material)
        : base(InstrumentType.Percussion, price, color, maker)
        {
            Material = material;
        }
    }
}
