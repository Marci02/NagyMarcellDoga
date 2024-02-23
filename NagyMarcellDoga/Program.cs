using System.Runtime.CompilerServices;

namespace NagyMarcellDoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taborok = new List<Tabor>();
            using (var sr = new StreamReader(@"taborok.txt"))
            {
                while (!sr.EndOfStream) taborok.Add(new Tabor(sr.ReadLine()));
            }

            Console.WriteLine("2. feladat:");
            Console.WriteLine($"Az adatsorok száma: {taborok.Count()}");
            Console.WriteLine($"Az első rögzített téma: {taborok[0].Tema}");
            Console.WriteLine($"Az utolsó rögzített téma: {taborok[taborok.Count - 1].Tema}");

            Console.WriteLine("3. feladat:");
            bool van = false;
            for (int i = 0; i < taborok.Count; i++)
            {
                if (taborok[i].Tema == "zenei")
                {
                    van = true;
                    Console.WriteLine($"Zenei tábor kezdődik {taborok[i].KezdHo}. hó {taborok[i].KezdNap}. napján!");
                }

            }

            if (!van)
            {
                Console.WriteLine("Nincsen zenei tábor!");
            }

            Console.WriteLine("4. feladat");
            int kezdh = 0, kezdn = 0;
            int max = 10;
            string tema = "";
            foreach (var tabor in taborok)
            {
                if (max < tabor.Kezdobetuk.Length)
                {
                    kezdh = tabor.KezdHo;
                    kezdn = tabor.KezdNap;
                    tema = tabor.Tema;
                }
            }

            Console.WriteLine("Legnépszerűbbek:");
            Console.WriteLine(kezdh + " " + kezdn + " " + tema);


            Console.WriteLine("6. feladat:");
            Console.Write("Hó: ");
            int ho = int.Parse(Console.ReadLine());
            Console.Write("Nap: ");
            int nap = int.Parse(Console.ReadLine());

            int count = 0;

            ////foreach (var tabor in taborok)
            ////{
            ////    if(sorszam(ho, nap))
            ////    {
            ////        count++;
            ////    }
            ////}

            Console.WriteLine($"Ekkor éppen {count} tábor zajlik");

            Console.ReadKey();
        }

        public int sorszam(int honap, int nap)
        {
            DateTime kezdes = new DateTime(2024, 6, 16);
            DateTime most = new DateTime(2024, honap, nap);

            TimeSpan kapott = most - kezdes;

            return kapott.Days;
        }
    }
}