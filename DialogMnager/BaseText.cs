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
                DialogueLine a5 = new DialogueLine("be", "aaaaaa", 0, 0); dm.AddText(a5, 0);
                DialogueLine a6 = new DialogueLine("be", "aaaaaa", 1, 0); dm.AddText(a6, 0);
                DialogueLine a7 = new DialogueLine("be", "aaaaaa", 2, 0); dm.AddText(a7, 0);
                DialogueLine a8 = new DialogueLine("be", "aaaaaa", 3, 0); dm.AddText(a8, 0);
                DialogueLine a9 = new DialogueLine("be", "aaaaaa", 4, 0); dm.AddText(a9, 0);
                DialogueLine a10 = new DialogueLine("be", "aaaaaa", 5, 0); dm.AddText(a10, 0);
                DialogueLine a11 = new DialogueLine("be", "aaaaaa", 6, 0); dm.AddText(a11, 0);
                DialogueLine a12 = new DialogueLine("be", "aaaaaa", 7, 0); dm.AddText(a12, 0);
                DialogueLine a13 = new DialogueLine("be", "aaaaaa", 8, 0); dm.AddText(a13, 0);
                DialogueLine a14 = new DialogueLine("be", "aaaaaa", 9, 0); dm.AddText(a14, 0);
                DialogueLine a15 = new DialogueLine("be", "aaaaaa", 10, 0); dm.AddText(a15, 0);
                DialogueLine a16 = new DialogueLine("be", "aaaaaa", 11, 0); dm.AddText(a16, 0);
                DialogueLine a17 = new DialogueLine("be", "aaaaaa", 12, 0); dm.AddText(a17, 0);
                DialogueLine a18 = new DialogueLine("be", "aaaaaa", 13, 0); dm.AddText(a18, 0);
                DialogueLine a19 = new DialogueLine("be", "aaaaaa", 14, 0); dm.AddText(a19, 0);
                DialogueLine a20 = new DialogueLine("be", "aaaaaa", 15, 0); dm.AddText(a20, 0);
                DialogueLine a21 = new DialogueLine("be", "aaaaaa", 16, 0); dm.AddText(a21, 0);
                DialogueLine a22 = new DialogueLine("be", "aaaaaa", 17, 0); dm.AddText(a22, 0);
                DialogueLine a23 = new DialogueLine("be", "aaaaaa", 18, 0); dm.AddText(a23, 0);
                DialogueLine a24 = new DialogueLine("be", "aaaaaa", 19, 0); dm.AddText(a24, 0);
                DialogueLine a25 = new DialogueLine("be", "aaaaaa", 20, 0); dm.AddText(a25, 0);
                DialogueLine a26 = new DialogueLine("be", "aaaaaa", 21, 0); dm.AddText(a26, 0);
                DialogueLine a27 = new DialogueLine("be", "aaaaaa", 22, 0); dm.AddText(a27, 0);
                DialogueLine a28 = new DialogueLine("be", "aaaaaa", 23, 0); dm.AddText(a28, 0);
                DialogueLine a29 = new DialogueLine("be", "aaaaaa", 24, 0); dm.AddText(a29, 0);
                DialogueLine a30 = new DialogueLine("be", "aaaaaa", 25, 0); dm.AddText(a30, 0);
                DialogueLine a31 = new DialogueLine("be", "aaaaaa", 26, 0); dm.AddText(a31, 0);
                DialogueLine a32 = new DialogueLine("be", "aaaaaa", 27, 0); dm.AddText(a32, 0);
                DialogueLine a33 = new DialogueLine("be", "aaaaaa", 28, 0); dm.AddText(a33, 0);
                DialogueLine a34 = new DialogueLine("be", "aaaaaa", 29, 0); dm.AddText(a34, 0);
                DialogueLine a35 = new DialogueLine("be", "aaaaaa", 30, 0); dm.AddText(a35, 0);
                DialogueLine a36 = new DialogueLine("be", "aaaaaa", 31, 0); dm.AddText(a36, 0);
                DialogueLine a37 = new DialogueLine("be", "aaaaaa", 32, 0); dm.AddText(a37, 0);
                DialogueLine a38 = new DialogueLine("be", "aaaaaa", 33, 0); dm.AddText(a38, 0);
                DialogueLine a39 = new DialogueLine("be", "aaaaaa", 34, 0); dm.AddText(a39, 0);

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
