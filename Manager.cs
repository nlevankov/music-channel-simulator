using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_var11_Levankov
{
    public class Manager
    {
        List<Clip> _ClipsList = new List<Clip>(); // Список всех клипов
        List<Queue> _QueuesList = new List<Queue>(); // Список очередей клипов
        // Список фактов изменения популярности клипов
        List<LogItem> _LogList = new List<LogItem>(); 
        Generator _Generator; // Ссылка на генератор
        Broadcast _Broadcast; // Ссылка на эфир
        Random _Rnd = new Random(); // Генератор случайных чисел
        TextBox _Log_TB, _Stat_TB; // Визуальные компоненты
        int _Chance = 2; // Шанс поступления заявки
        int _CountOfApplications = 1; // Количество заявок на поступление
               
        public Manager(TextBox Log_TB, TextBox Stat_TB)
        {
            _Log_TB = Log_TB;
            _Stat_TB = Stat_TB;
        }

        public Manager() : this(null, null)
        {
            
        }

        public List<LogItem> LogList
        {
            get
            {
                return _LogList;
            }
        }

        public List<Queue> QueuesList
        {
            get
            {
                return _QueuesList;
            }
        }

        public int Chance
        {
            set
            {
                if (value >= 1 && value <= 5)
                    _Chance = value;
            }
        }

        public int CountOfApplications
        {
            set
            {
                if (value >= 1 && value <= 3)
                    _CountOfApplications = value;
            }
        }

        public List<Clip> ClipsList
        {
            get
            {
                return _ClipsList;
            }
        }

        // Метод добавления эфира
        public void AddBroadcast(Broadcast Broadcast)
        {
            _Broadcast = Broadcast;

            if (_Broadcast != null)
            {
                StepEvent += _Broadcast.StepHandler;

                _Broadcast.ClipPlaybackIsOverEvent += ClipPlaybackIsOverHandler;

                foreach (var Queue in _QueuesList)
                    _Broadcast.ClipPlaybackIsOverEvent += Queue.ClipPlaybackIsOverHandler;
            }            
        }

        // Метод удаления эфира
        public void RemoveBroadcast()
        {
            if (_Broadcast != null)
            {
                StepEvent -= _Broadcast.StepHandler;

                foreach (var Queue in _QueuesList)
                    _Broadcast.ClipPlaybackIsOverEvent -= Queue.ClipPlaybackIsOverHandler;

                _Broadcast.ClipPlaybackIsOverEvent -= ClipPlaybackIsOverHandler;

                _Broadcast = null;
            }            
        }

        // Метод добавления генератора
        public void AddGenerator(Generator Generator)
        {
            _Generator = Generator;

            if (_Generator != null)
                _Generator.NewApplication += NewApplicationHandler;
        }

        // Метод удаления генератора
        public void RemoveGenerator()
        {
            if (_Generator != null)
            {
                _Generator.NewApplication -= NewApplicationHandler;
                _Generator = null; 
            }
        }

        // Метод добавления очереди клипов
        public void AddQueue(Queue Queue)
        {
            if (Queue != null)
            {
                _QueuesList.Add(Queue);

                if (_Broadcast != null)
                    _Broadcast.ClipPlaybackIsOverEvent += Queue.ClipPlaybackIsOverHandler; 
            }
        }

        // Метод удаления очереди клипов
        public void RemoveQueue(Queue Queue)
        {
            if (Queue != null)
            {
                _QueuesList.Remove(Queue);

                if (_Broadcast != null)
                    _Broadcast.ClipPlaybackIsOverEvent -= Queue.ClipPlaybackIsOverHandler;
            }
        }

        // Метод для отображения выполненного действия в визуальном компоненте
        public void PrintResult(string s)
        {
            if (_Log_TB != null)
                _Log_TB.AppendText(s + Environment.NewLine);
        }

        //  Метод для генерации события «Шаг» и событий «Новая заявка»
        public void OnTimer()
        {
            _Log_TB.Clear();
            OnStep();
            if (_Generator != null && _Rnd.Next(_Chance) == 0)
                for (int i = 1; i <= _CountOfApplications; i++)
                    _Generator.OnNewApplication();
        }

        // Событие "Шаг" (получатель эфир)
        private event EventHandler<OnlyPrintArgs> StepEvent;
        // Активатор события "Шаг"
        private void OnStep() 
        {
            if (StepEvent != null)
            {
                OnlyPrintArgs E = new OnlyPrintArgs();
                E.PrintResult = PrintResult;
                StepEvent(this, E);
            }
        }

        // Обработчик события "Новая заявка" (генерирует генератор)
        private void NewApplicationHandler(object sender, OnlyClipArgs e)
        {
            PrintResult("Менеджер: получена заявка на клип <" + e.Clip + ">.");

            if (_Broadcast.Current != e.Clip)
            {
                if (e.Clip.Popularity != 10)
                {
                    // Удаляем клип из предыдущей очереди
                    _QueuesList[10 - e.Clip.Popularity].RemoveClip(e.Clip, PrintResult);

                    // Добавляем клип в очередь с популярностью выше текущей
                    _QueuesList[9 - e.Clip.Popularity].AddClip(e.Clip, _LogList, PrintResult);   
                }
                else
                {
                    // Попытка передвинуть клип ближе к началу
                    _QueuesList[0].BumpClip(e.Clip, PrintResult);
                }
            }
            else
            {
                PrintResult("Менеджер: так как клип <" + e.Clip + "> находится на воспроизведении, его популярность не может быть изменена.");
            }
        }

        // Обработчик события "Воспроизведение окончено" (генерирует эфир)
        private void ClipPlaybackIsOverHandler(object sender, BroadcastArgs e)
        {
            if (e.OldClip != null)
            {
                PrintResult("Менеджер: получен снятый с воспроизведения клип <" + e.OldClip + "> и передан очереди с популярностью 1.");
                _QueuesList[9].AddClip(e.OldClip, _LogList, PrintResult); 
            }                       
        }

        // Метод для расчета статистики назначений популярности
        // тому или иному клипу
        public void SetStat()
        {
            // Создадим коллекцию популярностей
            var Popularities = from queue in _QueuesList
                                orderby queue.Popularity
                                select queue.Popularity; 
           
            // Для каждого клипа отберём соответсвующую ему коллекцию 
            // файлов лога. Затем, из этой коллекции выберем файлы лога,
            // соответсвующие определенной популярности.
            var StatQuery = from clip in _ClipsList
                            join logItem in _LogList
                            on clip equals logItem.Clip
                            into Clip_LogItems
                            orderby clip.ID
                            select new
                            {
                                ClipName = clip.Name,

                                InnerQuery =    from pop in Popularities
                                                join logitem in Clip_LogItems
                                                on pop equals logitem.Popularity
                                                into Pop_LogItems
                                                orderby pop
                                                select new
                                                {
                                                    Popularity = pop,
                                                    Count = Pop_LogItems.Count()
                                                }
                            };

            _Stat_TB.Clear();

            foreach (var clip in StatQuery)
            {
                _Stat_TB.AppendText(clip.ClipName + Environment.NewLine);

                foreach (var pop in clip.InnerQuery)
                {
                    _Stat_TB.AppendText("  " + pop.Popularity + ": " + pop.Count + Environment.NewLine);
                }
            }
        }
    }
}

/*
 * 1. Событие "Шаг"
 * Генерирует: Менеджер
 * Параметры: 
 * 1) Ссылка на процедуру вывода строки описания действия
 * Заинтересованные классы/объекты классов:
 * Эфир
 * 
 * 2. Событие "Новая заявка" (новый автомобиль)
 * Генерирует: Генератор
 * Параметры: 
 * 1) Ссылка на клип
 * Заинтересованные классы/объекты классов:
 * Менеджер
 *  
 * 3. Событие "Воспроизведение окончено" (колонка свободна)
 * Генерирует: Эфир
 * Параметры: 
 * 1) Ссылка на процедуру вывода строки описания действия
 * 2) Ссылка на процедуру размещения клипа на воспроизведение
 * 3) Ссылка на отыгравший клип
 * Заинтересованные классы/объекты классов:
 * Менеджер, Очередь
 * ---
 * Когда происходит Событие "Воспроизведение окончено", новый клип размещается на воспроизведение,
 * а старый отдается менеджеру на расположение в очередь с приоритетом 1 с помощью данного события
 * ---
 * Далее, по мере заинтересованности очереди получают это событие. То есть
 * при создани очередей зарегестрировать их интерес в порядке популярности очередей
 * от 10 до 1, и тогда очередь с высшим приоритетом получит событие первым, обработает его
 * и возможно перекроет возможность его обработки другими очередями (как в случае с колонкой)
 * 
 * 
 * 
 *
 * 
 * -----------------------
 * 
 * //var StatQuery = from popularity in Popularities
            //                join logItem in _LogList
            //                on popularity equals logItem.Popularity
            //                into Popularity_LogItems

            //var StatQuery =    from queue in _QueuesList
            //                   orderby queue.Popularity
            //                   select queue.Popularity
            //                   into popularity
            //                   join logItem in _LogList
            //                   on popularity equals logItem.Popularity
            //                   into Popularity_LogItems
 * 
 * 
 * 
*/