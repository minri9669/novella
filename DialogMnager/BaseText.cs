using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.DialogMnager
{
    using System.Collections.Generic;
    namespace бурмаджа_.dialogue

    {
        public class BaseText
        {
            private DialogueManager dm = new DialogueManager();

            public List<DialogueLine> GetDialog(int a)
            {
                return dm.GetDialog(a);
            }
            public BaseText()
            {
                DialogueLine a1 = new DialogueLine("Автор", "ХАНТАВИРУС: ЧЕРНОБЫЛЬСКАЯ ПЕТЛЯ", 1, 0); dm.AddText(a1, 0);
                DialogueLine a2 = new DialogueLine("Автор", "2067 год. Чернобыль. Восстановленный город.\nВертолёт МЧС приземлился на площадке у четвёртого энергоблока.\n" +
                    "\"Из него вышли четыре женщины в тактических куртках, с рюкзаками за плечами.\nЛучшие из лучших. Москва отправила их выяснить настоящую причину аварии 1986 года.\n" +
                    "Эмма, Диана, Роня и Динара знали друг друга не первый год.", 0, 1); dm.AddText(a2, 0);
                DialogueLine a3 = new DialogueLine("Автор", "Эмма — патологоанат, тихая и наблюдательная.\nДиана — фельдшер скорой, лидер, холодная и рациональная.\nРоня — хирург, резкая, физически сильная, с револьвером в кобуре. Динара — медсестра, циничная, золотые руки.", 0, 1); dm.AddText(a3, 0);
                DialogueLine a4 = new DialogueLine("Автор", "Никто туда не спускался полвека. Спуститься предстоит им.\nОни вошли внутрь.", 1, 0); dm.AddText(a4, 0);

                DialogueLine b = new DialogueLine("саиасипаси", "ывапываыва", 1, 0); dm.AddText(b, 1);
                DialogueLine b1 = new DialogueLine("чвапмвчап", "вввввввввввафыаввыа", 0, 1); dm.AddText(b1, 1);
                DialogueLine b2 = new DialogueLine("ыфваяваптва", "ываываывпаявчввпиваа", 1, 0); dm.AddText(b2, 1);
            }
        }
        public class DialogueLine
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public int indIm { get; set; }
            public int intImB { get; set; }

            public DialogueLine(string name, string text, int imageIndex, int backgroundIndex)
            {
                Text = text;
                Name = name;
                indIm = imageIndex;
                intImB = backgroundIndex;
            }

        }
        public class DialogueManager
        {
            private List<string> history = new List<string>();
            private List<List<DialogueLine>> listOfLists = new List<List<DialogueLine>>();
            public void AddText(DialogueLine line, int a)
            {
                if (listOfLists.Count - 1 < a)
                {
                    listOfLists.Add(new List<DialogueLine>());
                }
                listOfLists[a].Add(line);
            }

            public List<DialogueLine> GetDialog(int a)
            {
                return listOfLists[a];
            }
            public void TextWindow(DialogueLine line)
            {
                string kukaracha = line.Name + ": " + line.Text;
                history.Add(kukaracha);
            }
            public List<string> GetHistory()
            {
                return history;
            }
            public void ClearHistory()
            {
                history.Clear();
            }

        }
    }
}
