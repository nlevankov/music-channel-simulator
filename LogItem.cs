using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_var11_Levankov
{
public class LogItem
{
    static int Counter;
    int _ID;
    Clip _Clip; // Ссылка на клип
    int _AppointedPopularity; // Назначенная клипу популярность

    public LogItem(Clip Clip, int AppointedPopularity)
    {
        _ID = ++Counter;
        _Clip = Clip;
        _AppointedPopularity = AppointedPopularity >= 1 && AppointedPopularity <= 10 ? AppointedPopularity : 1;
    }

    public LogItem() : this(null, 1)
    {
            
    }       

    public override string ToString()
    {
        if (_Clip != null)
            return "Объект лога №" + _ID + ", клип: <" + _Clip + ">, назначенная популярность: " + _AppointedPopularity + ".";
        else
            return "Объект лога №" + _ID;
    }

    public int Popularity
    {
        get
        {
            return _AppointedPopularity;
        }
    }

    public Clip Clip
    {
        get
        {
            return _Clip;
        }
    }
}
}
