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
            AlexeyChoice b1 = new AlexeyChoice("Эмма поворачивает стрелки.",1); AddChoices(b1, 0); //начало - к выбору а1
            AlexeyChoice c = new AlexeyChoice("Эмма закрывает шкатулку и отказывается от этой идеи.", 2); AddChoices(c, 1); //начало - к выбору б1
            AlexeyChoice endF1 = new AlexeyChoice("Эмма остаётся с пациентом. Диана, Роня и Динара идут в церковь.", 1); AddChoices(endF1, 2); //выбор а->концовка фели.
            AlexeyChoice z1 = new AlexeyChoice("Эмма идёт с девочками. Пациент остаётся один.", 2); AddChoices(z1, 3); //выбор а1->загадка.
            AlexeyChoice q1 = new AlexeyChoice("Что вы делаете здесь, в подвале?", 1); AddChoices(q1, 4); //вопросы в загадке.
            AlexeyChoice qq1 = new AlexeyChoice("Как нам вернуться в своё время?", 2); AddChoices(qq1, 5); //вопросы в загадке.
            AlexeyChoice qqq1 = new AlexeyChoice("Зачем вам всё это?", 3); AddChoices(qqq1, 6); //вопросы в загадке.
            AlexeyChoice qqqq1 = new AlexeyChoice("Почему вы ждали именно нас?", 4); AddChoices(qqqq1, 7); //вопросы в загадке.
            AlexeyChoice с1 = new AlexeyChoice("Согласиться помогать Фалексу.", 1); AddChoices(с1, 8); //выбор а1->загадка->выбор а2.
            AlexeyChoice dEndR1 = new AlexeyChoice("Отказаться и действовать самостоятельно.", 2); AddChoices(dEndR1, 9); //выбор б1->загадка->концовка рони.
            AlexeyChoice lineB1 = new AlexeyChoice("Немедленно идти в церковь. Оставить тело в подвале.", 1); AddChoices(lineB1, 10); //выбор б1->загадка.
            AlexeyChoice endD1 = new AlexeyChoice("Немедленно отступать, оставив компонент.", 2); AddChoices(endD1, 11); //выбор б1->загадка->выбор а2(б)->концовка динары.
            AlexeyChoice endG1 = new AlexeyChoice("Прорываться к ящику и забирать компонент..", 1); AddChoices(endG1, 12); //выбор б1->загадка->выбор а2(а)->концовка г.
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
