using System.Text.Json;

namespace Exercicio_01
{
    internal class Inventory
    {
        private static List<Guitar> guitarList = new List<Guitar>();
        private static List<SweetFlute> sweetFluteList = new List<SweetFlute>();
        private static List<Violin> violinList = new List<Violin>();
        private static List<Tambourine> tambourineList = new List<Tambourine>();

        private static string dbGuitar = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Guitar.json");
        private static string dbSweetFlute = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SweetFlute.json");
        private static string dbViolin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Violin.json");
        private static string dbTambourine = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tambourine.json");
        public static int Count { get => guitarList.Count + sweetFluteList.Count + violinList.Count + tambourineList.Count; }

        internal static void Include(Instrument instrument)
        {
            if(instrument is Guitar)
            {
                guitarList.Add(instrument as Guitar);
            }
            else if(instrument is SweetFlute)
            {
                sweetFluteList.Add(instrument as SweetFlute);
            }
            else if(instrument is Violin)
            {
                violinList.Add(instrument as Violin);
            }
            else
            {
                tambourineList.Add(instrument as Tambourine);
            }            
        }
        internal static void Save()
        {
            SaveGuitar();
            SaveSweetFlute();
            SaveViolin();
            SaveTambourine();
        }
        private static void SaveGuitar()
        {
            var content = JsonSerializer.Serialize(guitarList);
            File.WriteAllText(dbGuitar, content);
        }
        private static void SaveSweetFlute()
        {
            var content = JsonSerializer.Serialize(sweetFluteList);
            File.WriteAllText(dbSweetFlute, content);
        }
        private static void SaveViolin()
        {
            var content = JsonSerializer.Serialize(violinList);
            File.WriteAllText(dbViolin, content);
        }
        private static void SaveTambourine()
        {
            var content = JsonSerializer.Serialize(tambourineList);
            File.WriteAllText(dbTambourine, content);
        }


        internal static void Load()
        {
            LoadGuitar();
            LoadSweetFlute();
            LoadViolin();
            LoadTambourine();
        }
        internal static void LoadGuitar()
        {
            if (!File.Exists(dbGuitar))
                Save();

            var content = File.ReadAllText(dbGuitar);
            guitarList = JsonSerializer.Deserialize<List<Guitar>>(content);
        }
        internal static void LoadSweetFlute()
        {
            if (!File.Exists(dbSweetFlute))
                Save();

            var content = File.ReadAllText(dbSweetFlute);
            sweetFluteList = JsonSerializer.Deserialize<List<SweetFlute>>(content);
        }
        internal static void LoadViolin()
        {
            if (!File.Exists(dbViolin))
                Save();

            var content = File.ReadAllText(dbViolin);
            violinList = JsonSerializer.Deserialize<List<Violin>>(content);
        }
        internal static void LoadTambourine()
        {
            if (!File.Exists(dbTambourine))
                Save();

            var content = File.ReadAllText(dbTambourine);
            tambourineList = JsonSerializer.Deserialize<List<Tambourine>>(content);
        }
    }
}
