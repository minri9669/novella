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
        private int ChoiceResult;
        private List<List<AlexeyChoice>> sceneChoices = new List<List<AlexeyChoice>>();
        private HashSet<int> answeredQuestions = new HashSet<int>(); 
        private BaseText baseText;
        private int currentSceneIndex = 0;
        private bool questionsCompleted = false;
        public ChoiceManager(BaseText baseText)
        {
            this.baseText = baseText;
            AlexeyChoice a = new AlexeyChoice("Эмма поворачивает стрелки.", 1);
            AlexeyChoice b = new AlexeyChoice("Эмма закрывает шкатулку и отказывается от этой идеи.", 2);
            AddChoices(a, 0);
            AddChoices(b, 0);
            AlexeyChoice endF = new AlexeyChoice("Эмма остаётся с пациентом. Диана, Роня и Динара идут в церковь.", 2);
            AlexeyChoice z = new AlexeyChoice("Эмма идёт с девочками. Пациент остаётся один.", 3);
            AddChoices(endF, 1);
            AddChoices(z, 1);
            AlexeyChoice q = new AlexeyChoice("Что вы делаете здесь, в подвале?", 4);
            AlexeyChoice qq = new AlexeyChoice("Как нам вернуться в своё время?", 5);
            AlexeyChoice qqq = new AlexeyChoice("Зачем вам всё это?", 6);
            AlexeyChoice qqqq = new AlexeyChoice("Почему вы ждали именно нас?", 7);
            AddChoices(q, 2);
            AddChoices(qq, 2);
            AddChoices(qqq, 2);
            AddChoices(qqqq, 2);
            AlexeyChoice c = new AlexeyChoice("Согласиться помогать Фалексу.", 8);
            AlexeyChoice dEndR = new AlexeyChoice("Отказаться и действовать самостоятельно.", 9);
            AddChoices(c, 3);
            AddChoices(dEndR, 3);
            AlexeyChoice endD = new AlexeyChoice("Немедленно отступать, оставив компонент.", 11);
            AlexeyChoice endG = new AlexeyChoice("Прорываться к ящику и забирать компонент.", 12);
            AddChoices(endD, 4);
            AddChoices(endG, 4);
        }
        private void OpenReactGame()
        {
            using (ReactGame reactGame = new ReactGame())
            {
                // Открываем как диалоговое окно
                DialogResult result = reactGame.ShowDialog();

                // Проверяем результат
                if (result == DialogResult.OK)
                {
                    // Игрок выиграл
                    MessageBox.Show("Поздравляю! Вы выиграли мини-игру!");
                    // Здесь выполняем действия при победе
                }
                else if (result == DialogResult.Cancel)
                {
                    // Игрок проиграл
                    MessageBox.Show("Вы проиграли. Попробуйте снова.");
                    baseText.TeWin2(13);
                    // Здесь выполняем действия при поражении
                }
            }
        }
        public void AddChoices(AlexeyChoice scene, int a)
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
