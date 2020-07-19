using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_var11_Levankov
{
public class Clip // Клип
{
    // Счетчик для уникальной нумерации объектов
    static int Counter;
    int _ID; // Уникальный идентификатор        
    string _Name; // Имя клипа. По умолчанию "Клип №_ID"
    int _Duration; // Длительность звучания 2..7
    int _Popularity; // Популярность клипа 1..10 
    //Так как отображаемая информация о клипе меняться не будет, 
    //то имеет смысл в наличии поля, отвечающего за строковое предсталение клипа.
    string _StringRepresentation; 
    // Генератор случайных чисел, используемый для задания длительности 
    // звучания клипа по умолчанию.
    static Random Rnd = new Random();         

    // Основной конструктор, проверяющий значения параметров
    public Clip(string Name, int Duration)
    {
        _ID = ++Counter;
        string temp = "";
        _Name = (Name != null) && ((temp = Name.Trim()) != "") ? Name : "Клип №" + _ID;

        _Duration = Duration >= 2 && Duration <= 7 ? Duration : Rnd.Next(2, 8);

        _StringRepresentation = String.Format("\"{0}\" ({1} мин) ", _Name, _Duration);
    }

    // Конструктор «по умолчанию»
    public Clip() : this(null, Rnd.Next(2, 8))
    {
            
    }

    // Строковое представление объекта
    public override string ToString()
    {
        return _StringRepresentation;
    }

    /* Параметры клипа определяются в момент создания и
        не могут быть произвольно изменены. Для доступа к ним
        реализованы свойства. Исключением является популярность        клипа, которую назначает очередь при добавлении в неё        клипа. */
    public int ID
    {
        get
        {
            return _ID;
        }
    }

    public string Name
    {
        get
        {
            return _Name;
        }
    }

    public int Duration
    {
        get
        {
            return _Duration;
        }
    }       

    public int Popularity
    {
        get
        {
            return _Popularity;
        }
        set
        {
            if (value >= 1 && value <= 10)
                _Popularity = value;
        }
    }               
}
}

