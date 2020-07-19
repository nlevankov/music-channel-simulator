using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_var11_Levankov
{
    public class Broadcast
    {
        static int Counter;
        int _ID;
        Clip _Current; // Текущий транслируемый клип
        int _RemainingDuration; // Сколько осталось минут еще транслировать текущий клип
        TextBox _TB; // Визуальный компонент

        public Broadcast(TextBox TB)
        {
            _ID = ++Counter;
            _TB = TB;
            _Current = null;
            _RemainingDuration = 0;
        }

        public Broadcast() : this(null)
        {
            
        }        

        public override string ToString()
        {
            if (_Current != null)
                return "Эфир №" + _ID + ", транслируемый клип <" + _Current + ">, осталось воспроизводить " + _RemainingDuration + " минут.";
            else
                return "Эфир №" + _ID + ", никакой клип в данный момент не транслируется.";
        }

        public Clip Current
        {
            get
            {
                return _Current;
            }
        }
        
        // Обработчик события "Шаг" (генерирует менеджер)
        public void StepHandler(object sender, OnlyPrintArgs e) 
        {
            if (_Current != null)
            {
                _RemainingDuration--;

                if (e.PrintResult != null)
                    e.PrintResult("Эфир: клип <" + _Current + "> проиграл одну минуту, осталось " + _RemainingDuration + " мин.");

                if (_RemainingDuration == 0)
                {
                    if (_TB != null)
                        _TB.Clear();

                    if (e.PrintResult != null)
                        e.PrintResult("Эфир: окончено воспроизведение клипа <" + _Current + ">.");

                    // Размещаем новый клип
                    OnClipPlaybackIsOver(e.PrintResult, _Current);
                }
            }
            else
            {
                // Размещаем новый клип
                OnClipPlaybackIsOver(e.PrintResult, null);
            }
        }

        // Событие "Воспроизведение окончено" (получатели: очереди клипов, менеджер)
        public event EventHandler<BroadcastArgs> ClipPlaybackIsOverEvent;
        // Активатор
        private void OnClipPlaybackIsOver(CalcBack PrintResult, Clip OldClip)
        {
            if (ClipPlaybackIsOverEvent != null)
            {
                BroadcastArgs E = new BroadcastArgs();
                E.PrintResult = PrintResult;
                E.SetBroadcast = SetClip;
                E.ClipPlaybackIsOver = true;
                E.OldClip = OldClip;
                _Current = null;
                ClipPlaybackIsOverEvent(this, E);
            }
        }

        // Метод размещения клипа на воспроизведение
        private bool SetClip(ClipArgs E) 
        {
            if (E.Clip != null)
            {
                if (_Current == null)
                {
                    _Current = E.Clip;
                    _RemainingDuration = E.Clip.Duration;

                    if (_TB != null)
                        _TB.Text = E.Clip.ToString();

                    if (E.PrintResult != null)
                        E.PrintResult("Эфир: клип <" + E.Clip + "> размещён на воспроизведение.");
                }
                else
                {
                    if (E.PrintResult != null)
                        E.PrintResult("Эфир: клип <" + E.Clip + "> не был размещен, так как проигрывается <" + _Current + ">.");
                }
            }
            else
                if (E.PrintResult != null)
                    E.PrintResult("Эфир: не был передан клип для размещения.");

            return _Current == null;
        }
    }
}
