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
            DialogueLine a1 = new DialogueLine("Автор", "ХАНТАВИРУС: ЧЕРНОБЫЛЬСКАЯ ПЕТЛЯ"); dm.AddText(a1,0);
            DialogueLine a2 = new DialogueLine("Автор", "2067 год. Чернобыль. Восстановленный город."); dm.AddText(a2, 0);
            DialogueLine a3 = new DialogueLine("Автор", "Вертолёт МЧС приземлился на площадке у четвёртого энергоблока."); dm.AddText(a3, 0);
            DialogueLine a4 = new DialogueLine("Автор", "Из него вышли четыре женщины в тактических куртках, с рюкзаками за плечами."); dm.AddText(a4, 0);
            DialogueLine a5 = new DialogueLine("Автор", "Лучшие из лучших. Москва отправила их выяснить настоящую причину аварии 1986 года."); dm.AddText(a5, 0);
            DialogueLine a6 = new DialogueLine("Автор", "Эмма, Диана, Роня и Динара знали друг друга не первый год."); dm.AddText(a6, 0);
            DialogueLine a7 = new DialogueLine("Автор", "Эмма — патологоанат, тихая и наблюдательная. Диана — фельдшер скорой, лидер, холодная и рациональная."); dm.AddText(a7, 0);
            DialogueLine a8 = new DialogueLine("Автор", "Роня — хирург, резкая, физически сильная, с револьвером в кобуре. Динара — медсестра, циничная, золотые руки."); dm.AddText(a8, 0);
            DialogueLine a9 = new DialogueLine("Автор", "Никто туда не спускался полвека. Спуститься предстоит им."); dm.AddText(a9, 0);
            DialogueLine a10 = new DialogueLine("Автор", "Они вошли внутрь."); dm.AddText(a10, 0);
            DialogueLine a11 = new DialogueLine("Автор", "ПОДВАЛ ЭНЕРГОБЛОКА"); dm.AddText(a11, 0);
            DialogueLine a12 = new DialogueLine("Автор", "Пахло бетонной пылью, старыми кабелями, сладковатой вонью формалина. Ступеньки уходили глубоко вниз."); dm.AddText(a12, 0); 
            DialogueLine a13 = new DialogueLine("Автор", "Фонари выхватывали из тьмы ржавые трубы, облупившуюся краску."); dm.AddText(a13, 0);
            DialogueLine a14 = new DialogueLine("Автор", "В конце спуска оказалась комната. Метров двадцать."); dm.AddText(a14, 0);
            DialogueLine a15 = new DialogueLine("Автор", "В центре — стальной стол. На столе — резная шкатулка из тёмного дерева."); dm.AddText(a15, 0);
            DialogueLine a16 = new DialogueLine("Автор", "Она выглядила так, как будто бы её оставили здесь пару лет назад."); dm.AddText(a16, 0);
            DialogueLine a17 = new DialogueLine("Автор", "Эмма подошла первой. Открыла."); dm.AddText(a17, 0);
            DialogueLine a18 = new DialogueLine("Автор", "Внутри, на выцветшем бархате, лежали советские армейские часы, намертво соединённые с православным крестом."); dm.AddText(a18, 0);
            DialogueLine a19 = new DialogueLine("Автор", "Цепочка от часов обмотана вокруг креста, металл спекся воедино. Стрелки застыли на 26 апреля 1986 года, 01:23.\n"); dm.AddText(a19, 0); 
            DialogueLine a20 = new DialogueLine("Динара", "Момент взрыва"); dm.AddText(a20, 0);
            DialogueLine a21 = new DialogueLine("Диана", "Не трогай"); dm.AddText(a21, 0);
            DialogueLine a22 = new DialogueLine("Автор", "предупредила девушка с косичками"); dm.AddText(a22, 0);
            DialogueLine a23 = new DialogueLine("Автор", "Но Эмма уже взяла часы в руки. Металл был ледяным."); dm.AddText(a23, 0);
            DialogueLine a24 = new DialogueLine("Автор", "Она повернула стрелки вспять — на несколько дней, до 20 апреля. Просто чтобы посмотреть."); dm.AddText(a24, 0);
            DialogueLine a25 = new DialogueLine("Автор", "Часы затикали. Крест нагрелся. Воздух задрожал."); dm.AddText(a25, 0);
            DialogueLine a26 = new DialogueLine("Автор", "Вспышка. Провал."); dm.AddText(a26, 0);
            DialogueLine a27 = new DialogueLine("Автор", "1986 год. Та же ночь. Тот же подвал."); dm.AddText(a27, 0);
            DialogueLine a28 = new DialogueLine("Автор", "Они упали на бетонный пол. Но запах изменился — вместо пыли гарь, мазут, формалин."); dm.AddText(a28, 0);
            DialogueLine a29 = new DialogueLine("Автор", "За окном — темнота, собачий лай, и где-то далеко гул грузовиков.\n"); dm.AddText(a29, 0);
            DialogueLine a30 = new DialogueLine("Роня", "Это не наш Чернобыль"); dm.AddText(a30, 0);
            DialogueLine a31 = new DialogueLine("Автор", "Их заметил охранник. Крикнул, засвистел. Забегали тени."); dm.AddText(a31, 0);
            DialogueLine a32 = new DialogueLine("Автор", "Девушки бросились бежать. Через ограду, через пустырь, через колючую проволоку."); dm.AddText(a32, 0);
            DialogueLine a33 = new DialogueLine("Автор", "Голоса стихли только у старого облупленного здания — бывшей лаборатории рядом с ЧАЭС."); dm.AddText(a33, 0);
            DialogueLine a34 = new DialogueLine("Автор", "Внутри темно, холодно, разбитые окна.\n"); dm.AddText(a34, 0);
            DialogueLine a35 = new DialogueLine("Диана", "Разделимся"); dm.AddText(a35, 0);
            DialogueLine a36 = new DialogueLine("Диана", "Обыщем здание\n"); dm.AddText(a36, 0);
            DialogueLine a37 = new DialogueLine("Автор", "Подвал лаборатории. Умирающий человек."); dm.AddText(a37, 0);
            DialogueLine a38 = new DialogueLine("Автор", "В подвале было сыро."); dm.AddText(a38, 0);
            DialogueLine a39 = new DialogueLine("Автор", "Свет фонаря скользнул по ржавым трубам, стеллажам с пыльными склянками — и упёрся в скорченную фигуру в углу."); dm.AddText(a39, 0);
            DialogueLine a40 = new DialogueLine("Автор", "Человек. Мужчина в лабораторном халате. Бледный, с запёкшейся кровью на губах."); dm.AddText(a40, 0);
            DialogueLine a41 = new DialogueLine("Автор", "Дышал с хрипом. Умирал."); dm.AddText(a41, 0);
            DialogueLine a42 = new DialogueLine("Автор", "мма действовала быстро. Рюкзак, аптечка из 2067 года — антибиотики, стимуляторы."); dm.AddText(a42, 0);
            DialogueLine a43 = new DialogueLine("Автор", "Но этого мало. На стеллаже рядом с трупом стоял флакон."); dm.AddText(a43, 0);
            DialogueLine a44 = new DialogueLine("Автор", "На этикетке — название, почти как у одного из её лекарств из будущего."); dm.AddText(a44, 0);
            DialogueLine a45 = new DialogueLine("Автор", "«Пантостат-М». Она не задумалась. В лаборатории не хранят лекарств — но она не задумалась."); dm.AddText(a45, 0);
            DialogueLine a46 = new DialogueLine("Автор", "Она смешала содержимое флакона с препаратом из будущего и ввела человеку."); dm.AddText(a46, 0);
            DialogueLine a47 = new DialogueLine("Автор", "День первый. Температура."); dm.AddText(a47, 0);
            DialogueLine a48 = new DialogueLine("Автор", "На утро человеку стало хуже. Температура под сорок, бред, чёрная корка на губах.\n"); dm.AddText(a48, 0);
            DialogueLine a49 = new DialogueLine("Динара", "Надо в больницу"); dm.AddText(a49, 0);
            DialogueLine a50 = new DialogueLine("Автор", "сказала медсестра, циничная, но сейчас в её голосе звучало непривычное беспокойство."); dm.AddText(a50, 0);
            DialogueLine a51 = new DialogueLine("Динара", "Он умрёт. Мы не можем просто сидеть."); dm.AddText(a51, 0);
            DialogueLine a52 = new DialogueLine("Роня", "Нет"); dm.AddText(a52, 0);
            DialogueLine a53 = new DialogueLine("Роня", "Ты думаешь, в советской больнице нас встретят с распростёртыми объятиями?"); dm.AddText(a53, 0);
            DialogueLine a54 = new DialogueLine("Роня", "Ты думаешь, в советской больнице нас встретят с распростёртыми объятиями?"); dm.AddText(a54, 0);
            DialogueLine a55 = new DialogueLine("Роня", "Посмотри на себя. На нашу одежду. На приборы в рюкзаках."); dm.AddText(a55, 0);
            DialogueLine a56 = new DialogueLine("Роня", "Нас арестуют в первую же минуту."); dm.AddText(a56, 0);
            DialogueLine a57 = new DialogueLine("Диана", "Роня права"); dm.AddText(a57, 0);
            DialogueLine a58 = new DialogueLine("Диана", "Я только что нашла газету. «Правда», 24 апреля 1986 года."); dm.AddText(a57, 0);
            DialogueLine a59 = new DialogueLine("Диана", "Мы в прошлом, Динара."); dm.AddText(a58, 0);
            DialogueLine a60 = new DialogueLine("Диана", "И здесь нет наших законов."); dm.AddText(a59, 0);
            DialogueLine a61 = new DialogueLine("Диана", "Если нас задержат — а задержат обязательно — допросы, КГБ, лагеря."); dm.AddText(a60, 0);
            DialogueLine a62 = new DialogueLine("Диана", "Никто не узнает, где мы. Никто не придёт на помощь."); dm.AddText(a61, 0);
            DialogueLine a63 = new DialogueLine("Динара", "Но он же умирает"); dm.AddText(a62, 0);
            DialogueLine a64 = new DialogueLine("Роня", "Он умирал и до того, как Эмма его нашла"); dm.AddText(a63, 0);
            DialogueLine a65 = new DialogueLine("Роня", "Мы зря вмешались. Наша обязанность — помогать, да."); dm.AddText(a64, 0);
            DialogueLine a66 = new DialogueLine("Роня", "Но не ценой собственной жизни. И не ценой катастрофы, которую мы можем устроить, если раскроем себя."); dm.AddText(a65, 0);
            DialogueLine a67 = new DialogueLine("Диана", "Роня права насчёт второго"); dm.AddText(a66, 0);
            DialogueLine a68 = new DialogueLine("Диана", "Мы уже нарушили ход истории. Впутались туда, где нас быть не должно. Каждое лишнее действие — риск."); dm.AddText(a67, 0);
            DialogueLine a69 = new DialogueLine("Диана", "Больница — это гарантированный провал. Нас запрут, а он всё равно умрёт."); dm.AddText(a68, 0);
            DialogueLine a70 = new DialogueLine("Диана", "Или не умрёт — и тогда что?"); dm.AddText(a69, 0);
            DialogueLine a71 = new DialogueLine("Диана", "Как мы объясним его выздоровление советским врачам? Лекарствами из будущего, которых в природе не существует?"); dm.AddText(a70, 0);
            DialogueLine a72 = new DialogueLine("Автор", "Динара замолчала. Она понимала, что они правы. Но цинизм не мог заглушить врачебную привычку."); dm.AddText(a71, 0);
            DialogueLine a73 = new DialogueLine("Динара", "И что нам делать?"); dm.AddText(a72, 0);
            DialogueLine a74 = new DialogueLine("Роня", "Остаёмся здесь"); dm.AddText(a73, 0);
            DialogueLine a75 = new DialogueLine("Роня", "Наблюдаем. У него либо иммунитет сработает, либо нет."); dm.AddText(a74, 0);
            DialogueLine a76 = new DialogueLine("Роня", "Если выживет — будем решать дальше. Если умрёт…"); dm.AddText(a75, 0);
            DialogueLine a77 = new DialogueLine("Роня", "похороним и будем искать способ вернуться."); dm.AddText(a76, 0);
            DialogueLine a78 = new DialogueLine("Автор", "Эмма всё это время сидела на корточках рядом с человеком, не поднимая глаз."); dm.AddText(a77, 0);
            DialogueLine a79 = new DialogueLine("Автор", "Она слышала каждый спор. Она знала, что они правы."); dm.AddText(a78, 0);
            DialogueLine a80 = new DialogueLine("Автор", "Но смотреть на его лицо было невыносимо."); dm.AddText(a79, 0);
            DialogueLine a81 = new DialogueLine("Эмма", "Я остаюсь с ним"); dm.AddText(a80, 0);
            DialogueLine a82 = new DialogueLine("Эмма", "Буду следить за температурой, давлением."); dm.AddText(a81, 0);
            DialogueLine a83 = new DialogueLine("Эмма", "Если станет совсем плохо…"); dm.AddText(a82, 0);
            DialogueLine a84 = new DialogueLine("Эмма", "тогда подумаем про больницу. Но не раньше."); dm.AddText(a83, 0);
            DialogueLine a85 = new DialogueLine("Автор", "Диана посмотрела на неё долгим взглядом."); dm.AddText(a84, 0);
            DialogueLine a86 = new DialogueLine("Диана", "Но если он умрёт, мы уходим. Все."); dm.AddText(a85, 0);
            DialogueLine a87 = new DialogueLine("Диана", "Без оглядки. И ты с нами."); dm.AddText(a86, 0);
            DialogueLine a88 = new DialogueLine("Динара", "А если выживет?\n"); dm.AddText(a87, 0);
            DialogueLine a89 = new DialogueLine("Автор", "Никто не ответил."); dm.AddText(a88, 0);
            DialogueLine a90 = new DialogueLine("Автор", "Эмма достала из рюкзака шкатулку — ту самую, которую нашла в подвале энергоблока."); dm.AddText(a89, 0);
            DialogueLine a91 = new DialogueLine("Автор", "Открыла. Часы с крестом лежали на месте. Стрелки снова застыли на 26 апреля 1986 года."); dm.AddText(a90, 0);
            DialogueLine a92 = new DialogueLine("Автор", "Она закрыла крышку и убрала шкатулку обратно."); dm.AddText(a91, 0);
            DialogueLine a93 = new DialogueLine("Автор", "Человек застонал. На его губах выступила новая капля чёрной крови."); dm.AddText(a92, 0);
            DialogueLine a94 = new DialogueLine("Автор", "День второй. Утро."); dm.AddText(a93, 0);
            DialogueLine a95 = new DialogueLine("Автор", "Ночь прошла в тревожном забытьи."); dm.AddText(a94, 0);
            DialogueLine a96 = new DialogueLine("Автор", "Спали по очереди: два человека на страже, два — на рюкзаках, подложив под головы свёрнутые лабораторные халаты."); dm.AddText(a95, 0);
            DialogueLine a97 = new DialogueLine("Автор", "Эмма почти не сомкнула глаз — сидела рядом с пациентом, следила за пульсом, стирала чёрную корку с его губ."); dm.AddText(a96, 0);
            DialogueLine a98 = new DialogueLine("Автор", "К утру температура немного спала. Но ненадолго.\n"); dm.AddText(a97, 0);
            DialogueLine a99 = new DialogueLine("Диана", "Надо поесть"); dm.AddText(a98, 0);
            DialogueLine a100 = new DialogueLine("Автор", "говорила она, растирая затекшую шею."); dm.AddText(a99, 0);
            DialogueLine a101 = new DialogueLine("Диана", "Мы ничего не ели со вчерашнего утра."); dm.AddText(a101, 0);
            DialogueLine a102 = new DialogueLine("Диана", "А впереди неизвестно сколько.\n"); dm.AddText(a102, 0);
            DialogueLine a103 = new DialogueLine("Автор", "У них были сухпайки. Компактные брикеты, которые разбухали в горячей воде, превращаясь в подобие каши или супа.\""); dm.AddText(a103, 0);
            DialogueLine a104 = new DialogueLine("Автор", "И горелка — маленькая, на химическом топливе, из того же армейского набора."); dm.AddText(a104, 0);
            DialogueLine a105 = new DialogueLine("Динара", "Костер разведём?"); dm.AddText(a105, 0);
            DialogueLine a106 = new DialogueLine("Динара", "В подвале? Дыма на всю округу."); dm.AddText(a106, 0);
            DialogueLine a107 = new DialogueLine("Роня", "У нас нет дров"); dm.AddText(a107, 0);
            DialogueLine a108 = new DialogueLine("иана", "У нас есть горелка, идиоты"); dm.AddText(a108, 0);
            DialogueLine a109 = new DialogueLine("иана", "Не в пещере живём.\n"); dm.AddText(a109, 0);
            DialogueLine a110 = new DialogueLine("Автор", "Они нашли укромный угол в дальней части подвала — за бетонной колонной, где сквозняк тянул воздух вверх по вентиляционной шахте."); dm.AddText(a110, 0);
            DialogueLine a111 = new DialogueLine("Автор", "Горелка зашипела, выпустив ровное синее пламя."); dm.AddText(a111, 0);
            DialogueLine a112 = new DialogueLine("Автор", "Динара достала котелок, налила воды из своей фляги, бросила брикеты."); dm.AddText(a112, 0);
            DialogueLine a113 = new DialogueLine("Автор", "Запах еды — первый нормальный запах за два дня — разлился по подвалу."); dm.AddText(a113, 0);
            DialogueLine a114 = new DialogueLine("Автор", "Эмма не подошла к костру. Она осталась у постели пациента.\n"); dm.AddText(a114, 0);
            DialogueLine a115 = new DialogueLine("Роня", "Эм, иди сюда"); dm.AddText(a115, 0);
            DialogueLine a116 = new DialogueLine("Роня", "Он не умрёт за пять минут А ты выглядишь хуже его."); dm.AddText(a116, 0);
            DialogueLine a117 = new DialogueLine("Автор", "Эмма покачала головой. Но Диана подошла, взяла её за плечо и почти силой оттащила к огню."); dm.AddText(a117, 0);
            DialogueLine a118 = new DialogueLine("Диана", "Ешь. Приказ.\n"); dm.AddText(a118, 0);
            DialogueLine a119 = new DialogueLine("Автор", "Эмма взяла кружку с горячей жижей. Вкуса не чувствовала."); dm.AddText(a119, 0);
            DialogueLine a120 = new DialogueLine("Автор", "День второй. Вечер."); dm.AddText(a120, 0);
            DialogueLine a121 = new DialogueLine("Автор", "Они обустроились."); dm.AddText(a121, 0);
            DialogueLine a122 = new DialogueLine("Автор", "Расчистили угол, сложили рюкзаки в изголовье, натянули верёвку между трубами — повесили сушиться промокшие куртки."); dm.AddText(a122, 0);
            DialogueLine a123 = new DialogueLine("Автор", "Динара нашла в лаборатории несколько старых хирургических халатов — ими укрылись на ночь."); dm.AddText(a123, 0);
            DialogueLine a124 = new DialogueLine("Автор", "Роня отодрала от стены доску и сделала подобие стола.\n"); dm.AddText(a124, 0);
            DialogueLine a125 = new DialogueLine("Динара", "Прям квартира"); dm.AddText(a125, 0);
            DialogueLine a126 = new DialogueLine("Автор", "буркнула, развешивая носки над горелкой."); dm.AddText(a126, 0);
            DialogueLine a127 = new DialogueLine("Роня", "Дача мечты"); dm.AddText(a127, 0);
            DialogueLine a128 = new DialogueLine("Роня", "Со своим трупом в углу."); dm.AddText(a128, 0);
            DialogueLine a129 = new DialogueLine("Эмма", "Он не труп"); dm.AddText(a129, 0);
            DialogueLine a130 = new DialogueLine("Роня", "Пока нет.\n"); dm.AddText(a130, 0);
            DialogueLine a131 = new DialogueLine("Автор", "После ужина Диана достала карту — старую, советскую, нашла её в ящике стола вместе с какими-то протоколами."); dm.AddText(a131, 0);
            DialogueLine a132 = new DialogueLine("Автор", "Они сидели у потухающей горелки, обсуждая, как попытаться вернуться."); dm.AddText(a132, 0);
            DialogueLine a134 = new DialogueLine("Автор", "Шкатулка с часами лежала на импровизированном столе. Но пока никто не решался к ней прикасаться."); dm.AddText(a134, 0);
            DialogueLine a135 = new DialogueLine("Автор", "И тут пациент зашевелился. Сначала тихо застонал. Потом громче."); dm.AddText(a135, 0);
            DialogueLine a136 = new DialogueLine("Автор", "Эмма вскочила первой."); dm.AddText(a136, 0);
            DialogueLine a137 = new DialogueLine("Автор", "Он изогнулся дугой — и его вырвало."); dm.AddText(a137, 0);
            DialogueLine a138 = new DialogueLine("Автор", "Чёрной, густой кровью. Она растеклась по полу под ним, воняя железом и ещё чем-то сладковатым, приторным.\n"); dm.AddText(a138, 0);
            DialogueLine a139 = new DialogueLine("Динара", "Господи"); dm.AddText(a139, 0);
            DialogueLine a140 = new DialogueLine("Роня", "Отойдите!"); dm.AddText(a140, 0);
            DialogueLine a141 = new DialogueLine("Автор", "Она схватила Эмму за руку."); dm.AddText(a141, 0);
            DialogueLine a142 = new DialogueLine("Роня", "Не трогай его, Эмма. У него внутреннее кровотечение."); dm.AddText(a142, 0);
            DialogueLine a143 = new DialogueLine("Эмма", "Что делать?!"); dm.AddText(a143, 0);
            DialogueLine a144 = new DialogueLine("Диана", "Ничего"); dm.AddText(a144, 0);
            DialogueLine a145 = new DialogueLine("Диана", "Мы не в операционной."); dm.AddText(a145, 0);
            DialogueLine a146 = new DialogueLine("Диана", "У нас нет ни капельниц, ни препаратов, ни возможности сделать переливание."); dm.AddText(a146, 0);
            DialogueLine a147 = new DialogueLine("Диана", "Он истекает кровью изнутри. Ему конец."); dm.AddText(a147, 0);
            DialogueLine a148 = new DialogueLine("Автор", "Пациент забился в конвульсиях, потом затих."); dm.AddText(a148, 0);
            DialogueLine a149 = new DialogueLine("Автор", "Дыхание стало поверхностным, почти неощутимым."); dm.AddText(a149, 0);
            DialogueLine a150 = new DialogueLine("Динара", "Надо было в больницу"); dm.AddText(a150, 0);
            DialogueLine a151 = new DialogueLine("Автор", "прошептала она, глядя на лужу чёрной крови."); dm.AddText(a151, 0);
            DialogueLine a152 = new DialogueLine("Роня", "В больнице ему бы поставили диагноз «неизвестная инфекция» и положили в изолятор"); dm.AddText(a152, 0);
            DialogueLine a153 = new DialogueLine("Роня", "А нас бы повязали в ту же минуту."); dm.AddText(a153, 0);
            DialogueLine a154 = new DialogueLine("Роня", "Ты это хочешь услышать?"); dm.AddText(a154, 0);
            DialogueLine a155 = new DialogueLine("Динара", "Я и без тебя знаю."); dm.AddText(a155, 0);
            DialogueLine a156 = new DialogueLine("Автор", "Они замолчали. Эмма опустилась на колени рядом с человеком, взяла его за руку.\n Ладонь была ледяной. И тогда Динара произнесла то,\n о чём все думали, но боялись сказать"); dm.AddText(a156, 0);
            DialogueLine a157 = new DialogueLine("Динара", "Мы говорили при нём. Вчера, когда он был в сознании. Помните?\n Я сказала «из 2067 года». Роня говорила про прошлое. Диана про КГБ. Он слышал.\n Если он выживет… что тогда?"); dm.AddText(a157, 0);
            DialogueLine a158 = new DialogueLine("Роня", "Не выживет"); dm.AddText(a158, 0);
            DialogueLine a159 = new DialogueLine("Динара", "А если?\n Если выживет — он будет знать про нас.\n Про будущее. Про то, откуда мы пришли\n И тогда нам придётся решать, что с ним делать.\n Убить?\n Ты это предлагаешь? "); dm.AddText(a159, 0);
            DialogueLine a160 = new DialogueLine("Диана", "Я предлагаю не загадывать.\n Пока он не выжил."); dm.AddText(a160, 0);
            DialogueLine a161 = new DialogueLine("Автор", "Эмма не обернулась. Она сжимала холодную ладонь умирающего и смотрела в потолок."); dm.AddText(a161, 0);
            DialogueLine a162 = new DialogueLine("Эмма", "Он выживет. Я сделаю так, чтобы он выжил."); dm.AddText(a162, 0);
            DialogueLine a163 = new DialogueLine("Роня", "Чем?\n У нас нет ничего. Только твоя ошибка с лекарствами."); dm.AddText(a163, 0);
            DialogueLine a164 = new DialogueLine("Эмма", "Тогда я найду, чем."); dm.AddText(a164, 0);
            DialogueLine a165 = new DialogueLine("Автор", "В подвале стало тихо. Только горелка шипела, да где-то наверху ветер гулял по пустым коридорам лаборатории.\n А человек в углу снова застонал. "); dm.AddText(a165, 0);
            DialogueLine a166 = new DialogueLine("Автор", "ХАНТАВИРУС: ЧЕРНОБЫЛЬСКАЯ ПЕТЛЯ"); dm.AddText(a166, 0);
            DialogueLine a167 = new DialogueLine("Автор", "День второй. Поздний вечер. Раздумья.\n Человек в углу метался в бреду. Чёрная корка на его губах треснула, и из трещины сочилась сукровица.\n Эмма сидела рядом, держа его за руку, но уже не пыталась измерить пульс — и так было ясно: сердце работало через раз.\n Остальные молча готовили нехитрый ужин.\n Динара грела воду на горелке, Роня размачивала сухпайки, Диана проверяла оружие.\n Никто не говорил вслух то, о чём все думали: он умирает, и ничем помочь нельзя.\n Эмма подняла глаза на стол, где лежала шкатулка. Та самая — тёмное дерево, потускневшая латунь.\n Внутри — часы с крестом. Ключ, который принёс их сюда.\n Может быть, он же и откроет дорогу назад.\n Она встала. Подошла к столу. Положила ладонь на крышку, но не открывала."); dm.AddText(a167, 0);
            DialogueLine a168 = new DialogueLine("Диана", "Ты что задумала?"); dm.AddText(a168, 0);
            DialogueLine a169 = new DialogueLine("Эмма", "Часы.\n Если я поверну стрелки снова… может, мы вернёмся.\n Или хотя бы я.\n Возьму лекарства из будущего, настоящие, и приду обратно.\n Спасу его."); dm.AddText(a169, 0);
            DialogueLine a170 = new DialogueLine("Роня", "Эмма, это опасно.\n Мы не знаем, как это работает. В прошлый раз выбросило сюда.\n В следующий может выбросить в сорок первом. Или разорвать на атомы.\n"); dm.AddText(a170, 0);
            DialogueLine a171 = new DialogueLine("Эмма", "А если не попробовать, он умрёт\n И мы останемся здесь навсегда."); dm.AddText(a171, 0);
            DialogueLine a172 = new DialogueLine("Динара", "Она права. Риск есть. Но что нам терять?\n У нас нет ни связи, ни карты, ни плана. Только эти часы.\n"); dm.AddText(a172, 0);
            DialogueLine a173 = new DialogueLine("Диана", "И неизвестность. Ты готова к тому, что ничего не получится?\n Или станет хуже?"); dm.AddText(a173, 0);
            DialogueLine a174 = new DialogueLine("Автор", "Эмма не ответила. Она открыла шкатулку. Часы лежали на бархате. Стрелки по-прежнему застыли на 26 апреля 1986, 01:23.\n Крест тускло блестел в свете горелки."); dm.AddText(a174, 0);
            DialogueLine a175 = new DialogueLine("Эмма", "Я попробую"); dm.AddText(a175, 0);
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
//дальше только с богом.
    