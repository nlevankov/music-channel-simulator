using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_var11_Levankov
{
public class Queue
{
    static int Counter;
    int _ID;
    int _Popularity; // Популярность 1..10
    // Список клипов, находящихся в очереди
    List<Clip> _List = new List<Clip>(); 
    ListBox _LB; // Визуальный компонент
    // По той же причине, что и у класса клип, используется строковое одноименное поле
    string _StringRepresentation;

    public Queue(int Popularity, ListBox LB)
    {
        _ID = ++Counter;
        _Popularity = Popularity >= 1 && Popularity <= 10 ? Popularity : 1;
        _LB = LB;
        _StringRepresentation = "Очередь №" + _ID + ", популярность " + _Popularity;
    }

    public Queue() : this(1, null)
    {
            
    }        

    public override string ToString()
    {
        return _StringRepresentation;
    }

    public int Popularity
    {
        get
        {
            return _Popularity;
        }
    }

    // Этот метод нужен для корректного добавления клипа в очередь
    // и её визуальный компонент.
    public void AddClip(Clip Clip, List<LogItem> LogList, CalcBack PrintResult)
    {
        if (Clip != null)
        {
            int temp = -1;

            // Добавление производим только если в очереди нет этого клипа
            if ((temp = _List.IndexOf(Clip)) == -1)
            {
                _List.Add(Clip);
                Clip.Popularity = _Popularity;

                // Добавляем в визуальный компонент, если он есть
                if (_LB != null)
                    _LB.Items.Add(Clip);

                // Формируем файл лога, если есть ссылка на список
                if (LogList != null)
                    LogList.Add(new LogItem(Clip, _Popularity));

                if (PrintResult != null)
                    PrintResult("<" + this + ">: клип <" + Clip + "> был добавлен в очередь. Клипу назначена популярность " + _Popularity);
            }
            else
                if (PrintResult != null)
                    PrintResult("<" + this + ">: клип <" + Clip + "> не был добавлен в очередь, так как в ней он уже имеется.");
        }
        else
            if (PrintResult != null)
                PrintResult("<" + this + ">: не был передан клип для добавления.");
    }

    // А этот метод - для корректного удаления
    public void RemoveClip(Clip Clip, CalcBack PrintResult)
    {
        if (Clip != null)
        {
            int temp = -1;

            // А есть ли в этой очереди данный клип?
            if ((temp = _List.IndexOf(Clip)) != -1)
            {
                // Удаляем клип из очереди и её визуального компонента
                _List.RemoveAt(temp);
                if (_LB != null)
                    _LB.Items.Remove(Clip);

                if (PrintResult != null)
                    PrintResult("<" + this + ">: клип <" + Clip + "> был удален из очереди.");
            }
            else
                if (PrintResult != null)
                    PrintResult("<" + this + ">: клип <" + Clip + "> не был удален из очереди, так как он в ней не находится.");
        }
        else
            if (PrintResult != null)
                PrintResult("<" + this + ">: не был передан клип для удаления.");
    }   

    // Передвигает клип на одну позицию к началу очереди
    public void BumpClip(Clip Clip, CalcBack PrintResult)
    {
        if (Clip != null)
        {
            int temp = -1;

            // Если клип имеется в этой очереди и он находится не в начале
            if ((temp = _List.IndexOf(Clip)) != -1 && temp != 0)
            {
                _List.Insert(temp - 1, Clip);
                _List.RemoveAt(temp + 1);

                // Обновим представления клипов в визуальном компоненте
                _LB.Items[temp - 1] = Clip;
                _LB.Items[temp] = _List[temp];

                if (PrintResult != null)
                    PrintResult("<" + this + ">: клип <" + Clip + "> изменил свою позицию с " + (temp + 1) + " на " + temp);
            }
            else if (temp == 0)
                if (PrintResult != null)
                    PrintResult("<" + this + ">: так как клип <" + Clip + "> первый в очереди, то он не может быть смещен ближе к началу.");
                else
                    if (PrintResult != null)
                        PrintResult("<" + this + ">: клип <" + Clip + "> не изменил свою позицию в очереди, так как он в ней не находится.");
        }
        else
            if (PrintResult != null)
                PrintResult("<" + this + ">: не был передан клип для перемещения ближе к началу очереди.");
    }

    // Обработчик события "Воспроизведение окончено" (генерирует: "Эфир")
    public void ClipPlaybackIsOverHandler(object sender, BroadcastArgs e)
    {
        if (_List.Count > 0 && e.ClipPlaybackIsOver)
        {
            ClipArgs E = new ClipArgs();
            E.Clip = _List[0];

            RemoveClip(E.Clip, e.PrintResult);

            if (e.PrintResult != null)
                e.PrintResult("<" + this + ">: клип <" + E.Clip + "> передан на воспроизведение.");

            E.PrintResult = e.PrintResult;
            e.ClipPlaybackIsOver = e.SetBroadcast(E);
        }
    }        
}
}
