namespace Exercicio_01
{
    internal class Guitar : StringInstrument
    {
        public int NumTraste { get; }
        public Guitar(double price, string color, string maker, int numString, int numTraste) 
        : base(price, color, maker, numString)
        {
            NumTraste = numTraste;
        }
    }
}
