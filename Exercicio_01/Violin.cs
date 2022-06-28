namespace Exercicio_01
{
    internal class Violin : StringInstrument
    {
        public string accessory { get; }
        public Violin(double price, string color, string maker, int numString, string accessory) : base(price, color, maker, numString)
        {
            this.accessory = accessory;
        }
    }
}
