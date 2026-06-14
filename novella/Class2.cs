using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using бурмаджа_.dialogue;

namespace бурмаджа_.choices
{
    public class AlexeyChoice
    {
        public string text;
        public int IdTyping;
        public AlexeyChoice(string txt, int idTypin)
        {
            text = txt;
            IdTyping = idTypin;
        }
    }
    public class ChoiceManager
    {
        int ChoiceResult;
        private List<List<AlexeyChoice>> sceneChoices = new List<List<AlexeyChoice>>();
        public ChoiceManager()
        {
            AlexeyChoice a1 = new AlexeyChoice("Эмма поворачивает стрелки",1); AddChoices(a1, 0); 
            AlexeyChoice b1 = new AlexeyChoice("Эмма закрывает шкатулку и отказывается от этой идеи",2); AddChoices(b1, 1);
        }
        public void AddChoices(AlexeyChoice scene, int a) //добавлять выборы.
        {
            if (sceneChoices.Count - 1 < a)
            {
                sceneChoices.Add(new List<AlexeyChoice>());
            }
            sceneChoices[a].Add(scene);
        }
        public void PrintChoices(int a)
        {
            bool flag = true;
            for (int i = 0; i < sceneChoices[a].Count; i++) 
            {
                Console.WriteLine(i + 1 + ". " + sceneChoices[a][i].text);
            }
            while (flag)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (sceneChoices[a].Count != 3)
                {
                    switch (key.KeyChar)
                    {
                        case '1': ChoiceResult = sceneChoices[a][0].IdTyping; flag = false; break;
                        case '2': ChoiceResult = sceneChoices[a][1].IdTyping; flag = false; break;
                    }
                }
                else
                {
                    switch (key.KeyChar)
                    {
                        case '1': ChoiceResult = sceneChoices[a][0].IdTyping; flag = false; break;
                        case '2': ChoiceResult = sceneChoices[a][1].IdTyping; flag = false; break;
                        case '3': ChoiceResult = sceneChoices[a][2].IdTyping; flag = false; break;
                    } 
                }
            }
        }
        public int GetB() { return ChoiceResult; }
    }
}
