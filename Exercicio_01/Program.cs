using System.Drawing;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory.Load();

            Inventory.Include(new Guitar(5000, Color.Black.Name, "Fender", 6, 24));
            Inventory.Include(new SweetFlute(300, Color.White.Name, "xxxx", 0.30, "Clave de Fá"));
            Inventory.Include(new Violin(7000, Color.Red.Name, "dddd", 4, "Arco"));
            Inventory.Include(new Tambourine(200, Color.White.Name, "ffff", "Couro", "xxxx"));

            Console.WriteLine(Inventory.Count);

            Inventory.Save();
        }
    }
}
