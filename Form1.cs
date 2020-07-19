using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K_var11_Levankov
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        Manager MainManager;

        private void Main_F_Load(object sender, EventArgs e)
        {
            // Создание менеджера
            MainManager = new Manager(Log_TB, Stat_TB);

            //  Установка начальных параметров менеджера
            MainManager.Chance = Convert.ToInt32(Probability_NUD.Value);
            MainManager.CountOfApplications = Convert.ToInt32(CountOfApplications_NUD.Value);

            // Создание и добавление 20-и клипов в список клипов
            for (int i = 0; i < 20; i++)
                MainManager.ClipsList.Add(new Clip());

            // Создание и добавление генератора
            MainManager.AddGenerator(new Generator(MainManager.ClipsList));

            // Создание и добавление 10-и очередей
            MainManager.AddQueue(new Queue(10, TenQueue_LB));
            MainManager.AddQueue(new Queue(9, NineQueue_LB));
            MainManager.AddQueue(new Queue(8, EightQueue_LB));
            MainManager.AddQueue(new Queue(7, SevenQueue_LB));
            MainManager.AddQueue(new Queue(6, SixQueue_LB));
            MainManager.AddQueue(new Queue(5, FiveQueue_LB));
            MainManager.AddQueue(new Queue(4, FourQueue_LB));
            MainManager.AddQueue(new Queue(3, ThreeQueue_LB));
            MainManager.AddQueue(new Queue(2, TwoQueue_LB));
            MainManager.AddQueue(new Queue(1, OneQueue_LB));

            // Создание и добавление эфира
            MainManager.AddBroadcast(new Broadcast(Broadcast_TB));

            // Добавление в очередь с приоритетом 1 всех клипов
            for (int i = 0; i < MainManager.ClipsList.Count; i++)
                MainManager.QueuesList[9].AddClip(MainManager.ClipsList[i], MainManager.LogList, MainManager.PrintResult);
        }

        private void Timer_T_Tick(object sender, EventArgs e)
        {
            MainManager.OnTimer();
        }

        private void Manual_B_Click(object sender, EventArgs e)
        {
            Timer_T_Tick(this, e);
        }

        private void SetMode(object sender, EventArgs e)
        {
            Manual_B.Enabled = Stat_B.Enabled = Manual_RB.Checked;
            Timer_T.Enabled = Auto_RB.Checked;
        }

        private void Stat_B_Click(object sender, EventArgs e)
        {
            MainManager.SetStat();
        }

        private void Probability_NUD_ValueChanged(object sender, EventArgs e)
        {
            MainManager.Chance = Convert.ToInt32(Probability_NUD.Value);
        }

        private void CountOfApplications_NUD_ValueChanged(object sender, EventArgs e)
        {
            MainManager.CountOfApplications = Convert.ToInt32(CountOfApplications_NUD.Value);
        }
    }
}
