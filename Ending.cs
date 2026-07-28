using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aRTcccccccCCcc____.Endings
{
    public class Ending
    {
        public string Name {  get; private set; }
        public bool IsUnlocked { get; private set; }

        public Ending(string name) { Name = name; IsUnlocked = false; }

        public void Unlock() { IsUnlocked = true; }
    }

    public class EndingUse
    {
        private int kolvo;
        private List<Ending> endings = new List<Ending>();

        public EndingUse() {  kolvo = 0; }
        public void Adding(Ending ending)
        {
            if (ending == null) { Ending e = new Ending("None"); ending = e; }
            endings.Add(ending);
            kolvo++;
        }
        public void Unlocking(Ending ending) { if (ending != null) { ending.Unlock(); } }

        public List<Ending> GetUnloched() { return endings.Where(e => e.IsUnlocked).ToList(); }
        public void ShowAll()
        {
            Console.Clear();
            Console.WriteLine("  ---------------ВСЕ КОНЦОВКИ---------------");
            int a = 0;

            foreach (Ending ending in endings)
            {
                string statusEnd;
                if (ending.IsUnlocked) { statusEnd = "ОТКРЫТО"; a++; } else { statusEnd = "ЗАКРЫТО"; }
                Console.WriteLine(" " + statusEnd + " | " + ending.Name);
            }
            Console.WriteLine("  ------------------------------------------");
            Console.WriteLine("Открыто: " + a + " концовок из " + kolvo);
            Console.WriteLine("\nНажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

        public void ShowAllUnlocked()
        {
            Console.Clear();
            Console.WriteLine("  ---------------ОТКРЫТЫЕ КОНЦОВКИ---------------");
            foreach (Ending ending in endings)
            {
                if (ending.IsUnlocked) { Console.WriteLine(" " + ending.Name); }
            }
            Console.WriteLine("\nНажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }
    }
}
