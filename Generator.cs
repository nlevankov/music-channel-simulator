using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_var11_Levankov
{
public class Generator
{
    static int Counter;
    int _ID;
    List<Clip> _ClipsList; // Ссылка на список всех клипов        
    Random _Rnd = new Random();

    public Generator(List<Clip> ClipsList)
    {
        _ID = ++Counter;
        _ClipsList = ClipsList;
    }

    public Generator() : this(null)
    {
            
    }

    public override string ToString()
    {
        return "Генератор №" + _ID;    
    }

    // Событие "Новая заявка" (получатель: менеджер)
    public event EventHandler<OnlyClipArgs> NewApplication;
    // Активатор
    public void OnNewApplication()
    {
        int temp = 0;

        if (_ClipsList != null && (temp = _ClipsList.Count) > 0)
        {
            OnlyClipArgs E = new OnlyClipArgs();
            E.Clip = _ClipsList[_Rnd.Next(temp)];

            if (NewApplication != null)
                NewApplication(this, E);
        }
    }
}
}
