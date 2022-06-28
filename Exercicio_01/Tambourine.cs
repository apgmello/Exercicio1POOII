namespace Exercicio_01
{
    internal class Tambourine : PercussionInstrument
    {
        public string accessory { get; }
        public Tambourine(double price, string color, string maker, string material, string accessory) : base(price, color, maker, material)
        {
            this.accessory = accessory;
        }
    }
}
