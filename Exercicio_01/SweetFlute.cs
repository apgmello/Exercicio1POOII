namespace Exercicio_01
{
    internal class SweetFlute : WindInstrument
    {
        public string Clave { get; }
        public SweetFlute(double price, string color, string maker, double centimeters, string clave) : base(price, color, maker, centimeters)
        {
            Clave = clave;
        }
    }
}
