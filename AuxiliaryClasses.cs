using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K_var11_Levankov
{
    public delegate void CalcBack(string s);

    public class OnlyPrintArgs : EventArgs
    {
        public CalcBack PrintResult;
    }    

    public class OnlyClipArgs : EventArgs
    {
        public Clip Clip;
    }

    public class ClipArgs : OnlyPrintArgs
    {
        public Clip Clip;
    }    

    public delegate bool BroadcastCalcBack(ClipArgs e);

    public class BroadcastArgs : OnlyPrintArgs
    {
        public BroadcastCalcBack SetBroadcast;
        public bool ClipPlaybackIsOver;
        public Clip OldClip;
    }
}
