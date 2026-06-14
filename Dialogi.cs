using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Linq;
using System.Diagnostics.Tracing;
using System.Collections.Generic;


namespace бурмаджа_.dialogue

{
    public class BaseText
    {
        private DialogueManager dm = new DialogueManager();
        public BaseText()
        {
            DialogueLine a1 = new DialogueLine("Автор", "ХАНТАВИРУС: ЧЕРНОБЫЛЬСКАЯ ПЕТЛЯ"); dm.AddText(a1, 0);
            DialogueLine a2 = new DialogueLine("Автор", "2067 год. Чернобыль. Восстановленный город.\nВертолёт МЧС приземлился на площадке у четвёртого энергоблока.\n" +
                "\"Из него вышли четыре женщины в тактических куртках, с рюкзаками за плечами.\nЛучшие из лучших. Москва отправила их выяснить настоящую причину аварии 1986 года.\n" +
                "Эмма, Диана, Роня и Динара знали друг друга не первый год."); dm.AddText(a2, 0);
            DialogueLine a3 = new DialogueLine("Автор", "Эмма — патологоанат, тихая и наблюдательная.\nДиана — фельдшер скорой, лидер, холодная и рациональная.\nРоня — хирург, резкая, физически сильная, с револьвером в кобуре. Динара — медсестра, циничная, золотые руки."); dm.AddText(a3, 0);
            DialogueLine a4 = new DialogueLine("Автор", "Никто туда не спускался полвека. Спуститься предстоит им.\nОни вошли внутрь."); dm.AddText(a4, 0);
            DialogueLine a5 = new DialogueLine("Автор", "ПОДВАЛ ЭНЕРГОБЛОКА"); dm.AddText(a5, 0);
            DialogueLine a6 = new DialogueLine("Автор", "Пахло бетонной пылью, старыми кабелями, сладковатой вонью формалина. Ступеньки уходили глубоко вниз.\nФонари выхватывали из тьмы ржавые трубы, облупившуюся краску.\n" +
                "В конце спуска оказалась комната. Метров двадцать."); dm.AddText(a6, 0);
            DialogueLine a7 = new DialogueLine("Автор", "В центре — стальной стол. На столе — резная шкатулка из тёмного дерева.\nОна выглядила так, как будто бы её оставили здесь пару лет назад."); dm.AddText(a7, 0);
            DialogueLine a8 = new DialogueLine("Автор", "Эмма подошла первой. Открыла.\nВнутри, на выцветшем бархате, лежали советские армейские часы, намертво соединённые с православным крестом.\n" +
                "Цепочка от часов обмотана вокруг креста, металл спекся воедино. Стрелки застыли на 26 апреля 1986 года, 01:23."); dm.AddText(a8, 0);
            DialogueLine a9 = new DialogueLine("Динара", "Момент взрыва"); dm.AddText(a9, 0);
            DialogueLine a10 = new DialogueLine("Диана", "Не трогай"); dm.AddText(a10, 0);
            DialogueLine a11 = new DialogueLine("Автор", "предупредила девушка с косичками\nНо Эмма уже взяла часы в руки. Металл был ледяным.\n" +
                "Она повернула стрелки вспять — на несколько дней, до 20 апреля. Просто чтобы посмотреть."); dm.AddText(a11, 0);
            DialogueLine a12 = new DialogueLine("Автор", "Часы затикали. Крест нагрелся. Воздух задрожал.\nВспышка. Провал."); dm.AddText(a12, 0);
            DialogueLine a13 = new DialogueLine("Автор", "1986 год. Та же ночь. Тот же подвал."); dm.AddText(a13, 0);
            DialogueLine a14 = new DialogueLine("Автор", "Они упали на бетонный пол. Но запах изменился — вместо пыли гарь, мазут, формалин.\nЗа окном — темнота, собачий лай, и где-то далеко гул грузовиков."); dm.AddText(a14, 0);
            DialogueLine a15 = new DialogueLine("Роня", "Это не наш Чернобыль"); dm.AddText(a15, 0);
            DialogueLine a16 = new DialogueLine("Автор", "Их заметил охранник. Крикнул, засвистел. Забегали тени.\nДевушки бросились бежать. Через ограду, через пустырь, через колючую проволоку.\n" +
                "Голоса стихли только у старого облупленного здания — бывшей лаборатории рядом с ЧАЭС.\nВнутри темно, холодно, разбитые окна."); dm.AddText(a16, 0);
            DialogueLine a17 = new DialogueLine("Диана", "Разделимся, обыщем здание"); dm.AddText(a17, 0);
            DialogueLine a18 = new DialogueLine("Автор", "Подвал лаборатории."); dm.AddText(a18, 0);
            DialogueLine a19 = new DialogueLine("Автор", "В подвале было сыро.\nСвет фонаря скользнул по ржавым трубам, стеллажам с пыльными склянками — и упёрся в скорченную фигуру в углу.\n" +
                "Человек. Мужчина в лабораторном халате. Бледный, с запёкшейся кровью на губах.\nДышал с хрипом. Умирал."); dm.AddText(a19, 0);
            DialogueLine a20 = new DialogueLine("Автор", "Эмма действовала быстро. Рюкзак, аптечка из 2067 года — антибиотики, стимуляторы.\nНо этого мало. На стеллаже рядом с трупом стоял флакон.\n" +
                "На этикетке — название, почти как у одного из её лекарств из будущего.\n«Пантостат-М».\nОна не задумалась. В лаборатории не хранят лекарств — но она не задумалась.\n" +
                "Смешала содержимое флакона с препаратом из будущего и ввела человеку."); dm.AddText(a20, 0);
            DialogueLine a21 = new DialogueLine("Автор", "День первый."); dm.AddText(a21, 0);
            DialogueLine a22 = new DialogueLine("Автор", "На утро человеку стало хуже. Температура под сорок, бред, чёрная корка на губах."); dm.AddText(a22, 0);
            DialogueLine a23 = new DialogueLine("Динара", "Надо в больницу"); dm.AddText(a23, 0);
            DialogueLine a24 = new DialogueLine("Автор", "Сказала медсестра, циничная, но сейчас в её голосе звучало непривычное беспокойство."); dm.AddText(a24, 0);
            DialogueLine a25 = new DialogueLine("Динара", "Он умрёт. Мы не можем просто сидеть."); dm.AddText(a25, 0);
            DialogueLine a26 = new DialogueLine("Роня", "Нет\nТы думаешь, в советской больнице нас встретят с распростёртыми объятиями?\nПосмотри на себя. На нашу одежду. На приборы в рюкзаках.\n" +
                "Нас арестуют в первую же минуту."); dm.AddText(a26, 0);
            DialogueLine a27 = new DialogueLine("Диана", "Роня права. Я только что нашла газету. «Правда», 24 апреля 1986 года.\nМы в прошлом, Динара.\n" +
                "И здесь нет наших законов. Если нас задержат — а задержат обязательно — допросы, КГБ, лагеря.\nНикто не узнает, где мы. Никто не придёт на помощь."); dm.AddText(a27, 0);
            DialogueLine a28 = new DialogueLine("Динара", "Но он же умирает"); dm.AddText(a28, 0);
            DialogueLine a29 = new DialogueLine("Роня", "Он умирал и до того, как Эмма его нашла.\nМы зря вмешались. Наша обязанность — помогать, да.\n" +
                "Но не ценой собственной жизни. И не ценой катастрофы,\nкоторую мы можем устроить, если раскроем себя."); dm.AddText(a29, 0);
            DialogueLine a30 = new DialogueLine("Диана", "Роня права насчёт второго\n\"Мы уже нарушили ход истории. Впутались туда, где нас быть не должно. Каждое лишнее действие — риск.\n" +
                "Больница — это гарантированный провал. Нас запрут, а он всё равно умрёт.\nИли не умрёт — и тогда что?\nКак мы объясним его выздоровление советским врачам? Лекарствами из будущего, которых в природе не существует?"); dm.AddText(a30, 0);
            DialogueLine a31 = new DialogueLine("Автор", "Динара замолчала. Она понимала, что они правы. Но цинизм не мог заглушить врачебную привычку."); dm.AddText(a31, 0);
            DialogueLine a32 = new DialogueLine("Динара", "И что нам делать?"); dm.AddText(a32, 0);
            DialogueLine a33 = new DialogueLine("Роня", "Остаёмся здесь\nНаблюдаем. У него либо иммунитет сработает, либо нет.\nЕсли выживет — будем решать дальше. Если умрёт…\nпохороним и будем искать способ вернуться."); dm.AddText(a33, 0);
            DialogueLine a34 = new DialogueLine("Автор", "Эмма всё это время сидела на корточках рядом с человеком, не поднимая глаз.\nОна слышала каждый спор. Она знала, что они правы.\n" +
                "Но смотреть на его лицо было невыносимо."); dm.AddText(a34, 0);
            DialogueLine a35 = new DialogueLine("Эмма", "Я остаюсь с ним\nБуду следить за температурой, давлением.\nЕсли станет совсем плохо…\nтогда подумаем про больницу. Но не раньше."); dm.AddText(a35, 0);
            DialogueLine a36 = new DialogueLine("Автор", "Диана посмотрела на неё долгим взглядом."); dm.AddText(a36, 0);
            DialogueLine a37 = new DialogueLine("Диана", "Но если он умрёт, мы уходим. Все.\nБез оглядки. И ты с нами."); dm.AddText(a37, 0);
            DialogueLine a38 = new DialogueLine("Динара", "А если выживет?"); dm.AddText(a38, 0);
            DialogueLine a39 = new DialogueLine("Автор", "Никто не ответил.\nЭмма достала из рюкзака шкатулку — ту самую, которую нашла в подвале энергоблока.\n" +
                "Открыла. Часы с крестом лежали на месте. Стрелки снова застыли на 26 апреля 1986 года.\nОна закрыла крышку и убрала шкатулку обратно.\nЧеловек застонал. На его губах выступила новая капля чёрной крови."); dm.AddText(a39, 0);
            DialogueLine a40 = new DialogueLine("Автор", "День второй. Утро."); dm.AddText(a40, 0);
            DialogueLine a41 = new DialogueLine("Автор", "Ночь прошла в тревожном забытьи.\nСпали по очереди: два человека на страже, два — на рюкзаках, подложив под головы свёрнутые лабораторные халаты.\n" +
                "Эмма почти не сомкнула глаз — сидела рядом с пациентом, следила за пульсом, стирала чёрную корку с его губ.\nК утру температура немного спала. Но ненадолго."); dm.AddText(a41, 0);
            DialogueLine a42 = new DialogueLine("Диана", "Надо поесть\nМы ничего не ели со вчерашнего утра.\nА впереди неизвестно сколько."); dm.AddText(a42, 0);
            DialogueLine a43 = new DialogueLine("Автор", "У них были сухпайки. Компактные брикеты, которые разбухали в горячей воде, превращаясь в подобие каши или супа.\nИ горелка — маленькая, на химическом топливе, из того же армейского набора."); dm.AddText(a43, 0);
            DialogueLine a44 = new DialogueLine("Динара", "Костер разведём?"); dm.AddText(a44, 0);
            DialogueLine a45 = new DialogueLine("Роня", "У нас нет дров"); dm.AddText(a45, 0);
            DialogueLine a46 = new DialogueLine("Диана", "У нас есть горелка, идиоты\nНе в пещере живём."); dm.AddText(a46, 0);
            DialogueLine a47 = new DialogueLine("Автор", "Они нашли укромный угол в дальней части подвала — за бетонной колонной, где сквозняк тянул воздух вверх по вентиляционной шахте.\n" +
                "Горелка зашипела, выпустив ровное синее пламя.\nДинара достала котелок, налила воды из своей фляги, бросила брикеты.\nЗапах еды — первый нормальный запах за два дня — разлился по подвалу.\n" +
                "Эмма не подошла к костру. Она осталась у постели пациента."); dm.AddText(a47, 0);
            DialogueLine a48 = new DialogueLine("Роня", "Эм, иди сюда\nОн не умрёт за пять минут А ты выглядишь хуже его."); dm.AddText(a48, 0);
            DialogueLine a49 = new DialogueLine("Автор", "Эмма покачала головой. Но Диана подошла, взяла её за плечо и почти силой оттащила к огню."); dm.AddText(a49, 0);
            DialogueLine a50 = new DialogueLine("Диана", "Ешь. Приказ.\n"); dm.AddText(a50, 0);
            DialogueLine a51 = new DialogueLine("Автор", "Эмма взяла кружку с горячей жижей. Вкуса не чувствовала."); dm.AddText(a51, 0);
            DialogueLine a52 = new DialogueLine("Автор", "День второй. Вечер."); dm.AddText(a52, 0);
            DialogueLine a53 = new DialogueLine("Автор", "Они обустроились.\nРасчистили угол, сложили рюкзаки в изголовье, натянули верёвку между трубами — повесили сушиться промокшие куртки.\n" +
                "Динара нашла в лаборатории несколько старых хирургических халатов — ими укрылись на ночь.\nРоня отодрала от стены доску и сделала подобие стола."); dm.AddText(a53, 0);
            DialogueLine a54 = new DialogueLine("Динара", "Прям квартира"); dm.AddText(a54, 0);
            DialogueLine a55 = new DialogueLine("Роня", "Дача мечты\nСо своим трупом в углу."); dm.AddText(a55, 0);
            DialogueLine a56 = new DialogueLine("Эмма", "Он не труп"); dm.AddText(a56, 0);
            DialogueLine a57 = new DialogueLine("Роня", "Пока нет.\n"); dm.AddText(a57, 0);
            DialogueLine a58 = new DialogueLine("Автор", "После ужина Диана достала карту — старую, советскую, нашла её в ящике стола вместе с какими-то протоколами.\nОни сидели у потухающей горелки, обсуждая, как попытаться вернуться.\n" +
                "Шкатулка с часами лежала на импровизированном столе. Но пока никто не решался к ней прикасаться."); dm.AddText(a58, 0);
            DialogueLine a59 = new DialogueLine("Автор", "И тут пациент зашевелился. Сначала тихо застонал. Потом громче.\nЭмма вскочила первой.\nОн изогнулся дугой — и его вырвало.\n" +
                "Чёрной, густой кровью. Она растеклась по полу под ним, воняя железом и ещё чем-то сладковатым, приторным."); dm.AddText(a59, 0);
            DialogueLine a60 = new DialogueLine("Динара", "Господи"); dm.AddText(a60, 0);
            DialogueLine a61 = new DialogueLine("Роня", "Отойдите!"); dm.AddText(a61, 0);
            DialogueLine a62 = new DialogueLine("Автор", "Она схватила Эмму за руку."); dm.AddText(a62, 0);
            DialogueLine a63 = new DialogueLine("Роня", "Не трогай его, Эмма. У него внутреннее кровотечение."); dm.AddText(a63, 0);
            DialogueLine a64 = new DialogueLine("Эмма", "Что делать?!"); dm.AddText(a64, 0);
            DialogueLine a65 = new DialogueLine("Диана", "Ничего. Мы не в операционной.\nУ нас нет ни капельниц, ни препаратов, ни возможности сделать переливание.\nОн истекает кровью изнутри. Ему конец."); dm.AddText(a65, 0);
            DialogueLine a66 = new DialogueLine("Автор", "Пациент забился в конвульсиях, потом затих.\nДыхание стало поверхностным, почти неощутимым."); dm.AddText(a66, 0);
            DialogueLine a67 = new DialogueLine("Динара", "Надо было в больницу"); dm.AddText(a67, 0);
            DialogueLine a68 = new DialogueLine("Роня", "В больнице ему бы поставили диагноз «неизвестная инфекция» и положили в изолятор\nА нас бы повязали в ту же минуту.\nТы это хочешь услышать?"); dm.AddText(a68, 0);
            DialogueLine a69 = new DialogueLine("Динара", "Я и без тебя знаю."); dm.AddText(a69, 0);
            DialogueLine a70 = new DialogueLine("Автор", "Они замолчали. Эмма опустилась на колени рядом с человеком, взяла его за руку.\n Ладонь была ледяной. И тогда Динара произнесла то,\n о чём все думали, но боялись сказать"); dm.AddText(a70, 0);
            DialogueLine a71 = new DialogueLine("Динара", "Мы говорили при нём. Вчера, когда он был в сознании. Помните?\n Я сказала «из 2067 года». Роня говорила про прошлое. Диана про КГБ. Он слышал.\n Если он выживет… что тогда?"); dm.AddText(a71, 0);
            DialogueLine a72 = new DialogueLine("Роня", "Не выживет"); dm.AddText(a72, 0);
            DialogueLine a73 = new DialogueLine("Динара", "А если?\n Если выживет — он будет знать про нас.\n Про будущее. Про то, откуда мы пришли\n И тогда нам придётся решать, что с ним делать.\n Убить?\n Ты это предлагаешь? "); dm.AddText(a73, 0);
            DialogueLine a74 = new DialogueLine("Диана", "Я предлагаю не загадывать.\n Пока он не выжил."); dm.AddText(a74, 0);
            DialogueLine a75 = new DialogueLine("Автор", "Эмма не обернулась. Она сжимала холодную ладонь умирающего и смотрела в потолок."); dm.AddText(a75, 0);
            DialogueLine a76 = new DialogueLine("Эмма", "Он выживет. Я сделаю так, чтобы он выжил."); dm.AddText(a76, 0);
            DialogueLine a77 = new DialogueLine("Роня", "Чем? У нас нет ничего.\nТолько твоя ошибка с лекарствами."); dm.AddText(a77, 0);
            DialogueLine a78 = new DialogueLine("Эмма", "Тогда я найду, чем."); dm.AddText(a78, 0);
            DialogueLine a79 = new DialogueLine("Автор", "В подвале стало тихо. Только горелка шипела, да где-то наверху ветер гулял по пустым коридорам лаборатории.\n А человек в углу снова застонал. "); dm.AddText(a79, 0);
            DialogueLine a80 = new DialogueLine("Автор", "День второй. Поздний вечер. Раздумья.\n Человек в углу метался в бреду. Чёрная корка на его губах треснула, и из трещины сочилась сукровица.\n Эмма сидела рядом, держа его за руку, но уже не пыталась измерить пульс — и так было ясно: сердце работало через раз.\n Остальные молча готовили нехитрый ужин.\n Динара грела воду на горелке, Роня размачивала сухпайки, Диана проверяла оружие.\n Никто не говорил вслух то, о чём все думали: он умирает, и ничем помочь нельзя.\n Эмма подняла глаза на стол, где лежала шкатулка. Та самая — тёмное дерево, потускневшая латунь.\n Внутри — часы с крестом. Ключ, который принёс их сюда.\n Может быть, он же и откроет дорогу назад.\n Она встала. Подошла к столу. Положила ладонь на крышку, но не открывала."); dm.AddText(a80, 0);
            DialogueLine a81 = new DialogueLine("Диана", "Ты что задумала?"); dm.AddText(a81, 0);
            DialogueLine a82 = new DialogueLine("Эмма", "Часы.\n Если я поверну стрелки снова… может, мы вернёмся.\n Или хотя бы я.\n Возьму лекарства из будущего, настоящие, и приду обратно.\n Спасу его."); dm.AddText(a82, 0);
            DialogueLine a83 = new DialogueLine("Роня", "Эмма, это опасно.\n Мы не знаем, как это работает. В прошлый раз выбросило сюда.\n В следующий может выбросить в сорок первом. Или разорвать на атомы.\n"); dm.AddText(a83, 0);
            DialogueLine a84 = new DialogueLine("Эмма", "А если не попробовать, он умрёт\n И мы останемся здесь навсегда."); dm.AddText(a84, 0);
            DialogueLine a85 = new DialogueLine("Динара", "Она права. Риск есть. Но что нам терять?\n У нас нет ни связи, ни карты, ни плана. Только эти часы.\n"); dm.AddText(a85, 0);
            DialogueLine a86 = new DialogueLine("Диана", "И неизвестность. Ты готова к тому, что ничего не получится?\n Или станет хуже?"); dm.AddText(a86, 0);
            DialogueLine a87 = new DialogueLine("Автор", "Эмма не ответила. Она открыла шкатулку. Часы лежали на бархате. Стрелки по-прежнему застыли на 26 апреля 1986, 01:23.\n Крест тускло блестел в свете горелки."); dm.AddText(a87, 0);
            DialogueLine a88 = new DialogueLine("Эмма", "Я попробую"); dm.AddText(a88, 0);
            //первый файл.
            DialogueLine b = new DialogueLine("саиасипаси", "ывапываыва"); dm.AddText(b, 1);
            DialogueLine b1 = new DialogueLine("чвапмвчап", "вввввввввввафыаввыа"); dm.AddText(b1, 1);
            DialogueLine b2 = new DialogueLine("ыфваяваптва", "ываываывпаявчввпиваа"); dm.AddText(b2, 1);

        }
        public void TeWin2(int b) { dm.PlayingDialogs(b); }
        public void Golub(string a) { dm.SetHistory(a); }
        public List<string> Golub2() { return dm.GetHistory(); }
    }
    public class DialogueLine
    {
        public string Character { get; set; } //персонаж.
        public string Text { get; set; } //что говорит.
        public DialogueLine(string character, string text)
        {
            Character = character;
            Text = text;
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
            Console.ReadKey(true);
            Console.Clear();
        }
        public void TextWindow(DialogueLine line)
        {
            if (line.Character != "Автор")
            {
                Console.Write(line.Character + "\n---------------------------------\n - ");
            }
            Typing(line.Text, 50);
            string kukaracha = line.Character + ": " + line.Text;
            history.Add(kukaracha);
        }
        public void PlayingDialogs(int a)
        {
            foreach (DialogueLine line in listOfLists[a])
            {
                TextWindow(line);
            }
        }
        public List<string> GetHistory() //возвращает историю диалогов.
        {
            return history; //возвращает копии.
        }
        public void SetHistory(string a)
        {
            history.Add(a);
        }
        public void ClearHistory() //очищает историю перед новой игрой.
        {
            history.Clear();
        }
        public void ShowFullHistory() // показывает все дталоги.
        {
            Console.WriteLine($"              [ИСТОРИЯ ДИАЛОГОВ:]\n");
            foreach (string line in history)
            {
                Console.WriteLine(line);
            }
        }
    }
}
