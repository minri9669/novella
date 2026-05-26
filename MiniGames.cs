using System;
using System.Threading;

namespace BBBBBBBB.MiniGame
{
    public class MiniGames
    {
        public string name;
        public int id;
        public bool result;

        public MiniGames(string pname, int pid) { name = pname; id = pid; }
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
        public void Breathing() {
            Breath += 15;
            BloodDark += 10; }
    }

    public class EmmaDies : MiniGames
    {
        private Random random = new Random();
        private Patient patient = new Patient();
        private bool isGameRunning = false;

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
                    patient.BloodDark += random.Next(1, 11);
                }
                Thread.Sleep(5000);
            }
            Console.WriteLine("Он умер");
        }

        public EmmaDies(string name, int id) : base(name, id) { }

        public override void Game()
        {
            Console.WriteLine("Стабилизируйте пациента");
            DateTime startTime = DateTime.Now;
            isGameRunning = true;

            Thread statsThread = new Thread(UpdatePatientStats);
            statsThread.Start();

            while ((DateTime.Now - startTime).TotalSeconds < 60 && isGameRunning)
            {
                lock (lockObject)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("Температура: " + patient.Temperature);
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("Дыхание: " + patient.Breath + "%");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("Очернение крови: " + patient.BloodDark + "%");
                    Console.WriteLine("Смерть на: Температура > 41, Дыхание < 20, Очернение крови 80%");
                    Console.WriteLine("--------------------------------------------\n1 - Стимуляция/ОЧЕРНЕНИЕ КРОВИ/ (Очернение крови -15 | Температура + 0,5)\n2 - Охлаждение/ТЕМПЕРАТУРА/ (Температура -1 | Дыхание -10)\n3 - Искусственное дыхание/ДЫХАНИЕ/ (Дыхание +15 | Очернение крови +10)");
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

                if ((DateTime.Now - startTime).TotalSeconds >= 55)
                {
                    lock (lockObject)
                    {
                        patient.Temperature = 60; patient.Breath = 10; patient.BloodDark = 120;
                    }
                }

                Thread.Sleep(700);
            }
            isGameRunning = false;
            statsThread.Join();
        }
    }
}