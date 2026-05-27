using System;
using System.IO;
using System.Threading;

namespace BBBBBBBB.MiniGame
{
    public class MiniGames
    {
        public string name;
        public int id;
        public bool result;
        public bool isGameRunning;

        public MiniGames(string pname, int pid) { name = pname; id = pid; isGameRunning = false; }
        public bool GetResult() { return result; }
        public virtual void Game() => Console.WriteLine();
    }

    public class Patient
    {
        public double Temperature;
        public int Breath;
        public int BloodDark;

        public Patient() { Temperature = 38; Breath = 100; BloodDark = 0; }
        public bool IsAlive() { return Temperature < 41 && Breath >= 20 && BloodDark < 80; }
        public void Stimulate() { BloodDark -= 15; Temperature += 0.5; if (BloodDark < 0) { BloodDark = 0; } }
        public void Cool() { Temperature -= 1; Breath -= 10; if (Breath < 0) { Breath = 0; } }
        public void Breathing()
        {
            Breath += 15;
            if (Breath > 100) { Breath = 100; }
            BloodDark += 10;
        }
    }
    public class EmmaDies : MiniGames
    {
        private Random random = new Random();
        private Patient patient = new Patient();

        private object lockObject = new object();

        private void UpdatePatientStats()
        {
            while (isGameRunning)
            {
                lock (lockObject)
                {
                    if (!patient.IsAlive())
                    {
                        isGameRunning = false;
                        break;
                    }
                    double randomval = random.Next(1, 10) / 10.0;
                    patient.Temperature += randomval;
                    patient.BloodDark += random.Next(1, 20);
                    patient.Breath -= random.Next(1, 20);
                }
                Thread.Sleep(5000);
            }
            Console.WriteLine("Он умер");
        }

        public EmmaDies(string name, int id) : base(name, id) { }

        public override void Game()
        {
            Console.Clear();
            Console.WriteLine("Стабилизируйте пациента\nХарактеристики будут постепенно подниматься\nВаша задача: Продержаться 60 секунд и не дать пациенту погибнуть\n\nИнструкция:\n1 - Стимуляция/ОЧЕРНЕНИЕ КРОВИ/ (Очернение крови -15 | Температура + 0,5)\n2 - Охлаждение/ТЕМПЕРАТУРА/ (Температура -1 | Дыхание -10)\n3 - Искусственное дыхание/ДЫХАНИЕ/ (Дыхание +15 | Очернение крови +10)\nСмерть на: Температура > 41, Дыхание < 20, Очернение крови 80%\n--------------------------------------------------------------------------\nНажмите Enter, чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
            DateTime startTime = DateTime.Now;
            isGameRunning = true;

            Thread statsThread = new Thread(UpdatePatientStats);
            statsThread.Start();

            while ((DateTime.Now - startTime).TotalSeconds < 30 && isGameRunning)
            {
                lock (lockObject)
                {
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("  " + (int)(DateTime.Now - startTime).TotalSeconds + " | 30");
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine(" Температура: " + patient.Temperature);
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(" Дыхание: " + patient.Breath + "%");
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine(" Очернение крови: " + patient.BloodDark + "%");
                    Console.WriteLine(" Смерть на: Температура > 41, Дыхание < 20, Очернение крови 80%");
                    Console.Write(" --------------------------------------------------------------------------\n 1 - Стимуляция/ОЧЕРНЕНИЕ КРОВИ/ (Очернение крови -15 | Температура + 0,5)\n 2 - Охлаждение/ТЕМПЕРАТУРА/ (Температура -1 | Дыхание -10)\n 3 - Искусственное дыхание/ДЫХАНИЕ/ (Дыхание +15 | Очернение крови +10)\n ");

                    if ((DateTime.Now - startTime).TotalSeconds >= 25)
                    {
                        //lock (lockObject)
                        //{
                            patient.Temperature = 60; patient.Breath = 10; patient.BloodDark = 120;
                        Console.WriteLine("\n !Резко подскочил уровень очернения крови!\n !Пациента вырвало чёрной субстанцией!");
                        //}
                        break;
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    lock (lockObject)
                    {
                        if (!patient.IsAlive()) break;
                        switch (key.KeyChar)
                        {
                            case '1': patient.Stimulate(); break;
                            case '2': patient.Cool(); break;
                            case '3': patient.Breathing(); break;
                        }
                    }
                }

                

                Thread.Sleep(700);
            }
            isGameRunning = false;
            statsThread.Join();
        }
    }
    public class React : MiniGames
    {
        private static List<ConsoleKey> Sybmoli = new List<ConsoleKey>()
        {
            ConsoleKey.UpArrow,ConsoleKey.DownArrow,ConsoleKey.LeftArrow, ConsoleKey.RightArrow
        };
        private Random random = new Random();
        private int streak;
        private object lockObject = new object();
        ConsoleKey nowSymbol;
        private DateTime lastChange;
        public React(string name, int id) : base(name, id) { streak = 0; }

        private string GetSymbol(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow: return "↑";
                case ConsoleKey.DownArrow: return "↓";
                case ConsoleKey.LeftArrow: return "←";
                case ConsoleKey.RightArrow: return "→";
                default: return " ";
            }
        }

        private void UpdateSymbole()
        {
            while (isGameRunning)
            {
                lock (lockObject)
                {
                    int randomsym = random.Next(0, 4);
                    while(nowSymbol == Sybmoli[randomsym])
                    { randomsym = random.Next(0, 4); }
                    nowSymbol = Sybmoli[randomsym];
                }
                Thread.Sleep(1000);
            }
        }

        public override void Game()
        {
            streak = 0;
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Попадайте по стрелкам\nВ центре экрана будет появляться стрелка\nВаша задача: Успевать нажимать на ту же стрелку на клавиатуре 25 раз подряд\nЕсли не нажали ту стрелку или не успели, то счёт начинается заново\nУ вас есть 60 секунд\n-------------------------------------------------\nНажмите Enter, чтобы продолжить");
            Console.ReadKey();
            isGameRunning = true;
            Console.Clear();
            Thread statsThread = new Thread(UpdateSymbole);
            statsThread.Start();
            ConsoleKey pressedKey = ConsoleKey.NoName;
            DateTime startTime = DateTime.Now;

            while ((DateTime.Now - startTime).TotalSeconds <= 61 && streak <= 25 && isGameRunning)
            {
                lock (lockObject)
                {
                    if (streak > 0 && (DateTime.Now - lastChange).TotalMilliseconds >= 1700)
                    {
                        streak = 0;
                    }
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("               " + (int)(DateTime.Now - startTime).TotalSeconds + " | 60");
                    Console.WriteLine("  -------------------------------");
                    Console.WriteLine(" |   -------------------------   |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |            " + GetSymbol(nowSymbol) + "            |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |  |                         |  |");
                    Console.WriteLine(" |   -------------------------   |");
                    Console.WriteLine("  ----------------------------+--");
                    Console.WriteLine("             ---------        |");
                    Console.WriteLine("            |         |-------");
                    Console.WriteLine("            |    " + GetSymbol(pressedKey) + "    |");
                    Console.WriteLine("            |         |");
                    Console.WriteLine("             ---------");
                    Console.WriteLine("\nКОМБО: " + streak + " | 25");
                    if (streak >= 25)
                    {
                        result = true;
                        isGameRunning = false;
                        break;
                    }
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    lock (lockObject)
                    {
                        if (key.Key == nowSymbol)
                        {
                            streak++;
                        }
                        else { streak = 0; }

                        if (!isGameRunning) break;

                        switch (key.Key)
                        {
                            case ConsoleKey.UpArrow: pressedKey = ConsoleKey.UpArrow; lastChange = DateTime.Now; break;
                            case ConsoleKey.LeftArrow: pressedKey = ConsoleKey.LeftArrow; lastChange = DateTime.Now; break;
                            case ConsoleKey.RightArrow: pressedKey = ConsoleKey.RightArrow; lastChange = DateTime.Now; break;
                            case ConsoleKey.DownArrow: pressedKey = ConsoleKey.DownArrow; lastChange = DateTime.Now; break;
                        }
                    }
                }
            }
            isGameRunning = false;
            statsThread.Join();
            Thread.Sleep(2500);
            Console.Clear();
            if (result) { Console.WriteLine(" |Замок открыт|"); }
            else
            {
                Console.WriteLine(" |Замок заблокирован.|\n|Повторите попытку через 5 минут.|");

            }
            Console.WriteLine("Нажмите Enter, чтобы продолжить");
            Console.ReadKey();
        }

    }
    internal class SkipDialogs
    {
        public void Waiting_Next()
        {
            Console.ReadKey(true);
            Console.Clear();
        }
        public void Typing(string text, int delayMs)
        {
            bool skipTyping = false;
            Thread StopText = new Thread(() =>
            {
                Console.ReadKey(true);
                skipTyping = true;
            });
            StopText.Start();

            foreach (char ch in text)
            {
                if (skipTyping)
                {
                    Console.Write(text.Substring(text.IndexOf(ch)));
                    break;
                }
                Console.Write(ch);
                Thread.Sleep(delayMs);
            }

            Console.WriteLine();
        }
    }
    public class ChoicesResultMG
    {
        SkipDialogs sd = new SkipDialogs();
        bool result;
        public ChoicesResultMG() {  result = false; }

        public bool GetResult() {  return result; }
        public void ChoiceA()
        {
            Console.Clear();
            sd.Typing("Эмма подошла к крыльцу,пнула половичок.\n\nПод ковриком было пусто,только\nзаполоный паук резко помчался прочь\n\n- Ничего, - сказала она.\n\n - Тогда проверяй дальше,-бросила Диана.", 50);
            Console.WriteLine("\n\nНажмите Enter, чтобы продолжить");
            sd.Waiting_Next();
        }
        public void ChoiceB()
        {
            Console.Clear();
            sd.Typing("Эмма потянулась к фонарю над дверью. Сняла с\nкрюка,заглянула внутрь.Среди паутины и сухих\nмух лежал старый чёрный ключ\n\n- Есть, - сказала она, вытряхивая находку.\n\n- Давай сюда,- Диана взяла ключ, вставила в замок.\nЗасов лязгнул", 50);
            Console.WriteLine("\n\nНажмите Enter, чтобы продолжить");
            sd.Waiting_Next();
            result = true;
        }
        public void ChoiceC()
        {
            Console.Clear();
            sd.Typing("Эмма отодвинула булыжник. Под ним - влажная земля,\nчерви, и больше ничего. На нижней стороне\nкамня она заметила какие-то странные царапины - символы,\nпохожие на детские каракули.\nПод ковриком было пусто,только\n\n- Ничего, - вздохнула она.- Только непонятные знаки\n\n- Не отвлекайся,- сказала Роня.", 50);
            Console.WriteLine("\n\nНажмите Enter, чтобы продолжить");
            sd.Waiting_Next();
        }
    }
    public class ChoicesMiniGame : MiniGames
    {
        private ChoicesResultMG chresult = new ChoicesResultMG();
        private object lockObject = new object();
        public ChoicesMiniGame(string name, int id) : base(name, id) { }

        public override void Game()
        {
            isGameRunning = true;
            while (isGameRunning)
            {
                Console.Clear();
                Console.WriteLine("A) Поднять коврик\nБ)Заглянуть в фонарь\nВ)Отодвинуть камень возле бочки");
                ConsoleKeyInfo key = Console.ReadKey(true);
                    lock (lockObject)
                    {
                        if (chresult.GetResult()) break;
                        switch (key.KeyChar)
                        {
                            case 'А': chresult.ChoiceA(); break;
                            case 'Б': chresult.ChoiceB(); break;
                            case 'В': chresult.ChoiceC(); break;
                        }
                    }
                if (chresult.GetResult()) { isGameRunning = false; }
            }

        }

    }

}