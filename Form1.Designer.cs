namespace K_var11_Levankov
{
    partial class Main_F
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Management_GB = new System.Windows.Forms.GroupBox();
            this.Manual_B = new System.Windows.Forms.Button();
            this.Manual_RB = new System.Windows.Forms.RadioButton();
            this.Auto_RB = new System.Windows.Forms.RadioButton();
            this.NewApplications_GB = new System.Windows.Forms.GroupBox();
            this.CountOfApplications_NUD = new System.Windows.Forms.NumericUpDown();
            this.CountOfApplications_L = new System.Windows.Forms.Label();
            this.Probability_NUD = new System.Windows.Forms.NumericUpDown();
            this.Probability_L = new System.Windows.Forms.Label();
            this.Stat_GB = new System.Windows.Forms.GroupBox();
            this.Stat_L = new System.Windows.Forms.Label();
            this.Stat_TB = new System.Windows.Forms.TextBox();
            this.Stat_B = new System.Windows.Forms.Button();
            this.Log_TB = new System.Windows.Forms.TextBox();
            this.Broadcast_GB = new System.Windows.Forms.GroupBox();
            this.Broadcast_TB = new System.Windows.Forms.TextBox();
            this.Current_L = new System.Windows.Forms.Label();
            this.Queues_GB = new System.Windows.Forms.GroupBox();
            this.TenQueue_L = new System.Windows.Forms.Label();
            this.TenQueue_LB = new System.Windows.Forms.ListBox();
            this.NineQueue_L = new System.Windows.Forms.Label();
            this.NineQueue_LB = new System.Windows.Forms.ListBox();
            this.EightQueue_L = new System.Windows.Forms.Label();
            this.EightQueue_LB = new System.Windows.Forms.ListBox();
            this.SevenQueue_L = new System.Windows.Forms.Label();
            this.SevenQueue_LB = new System.Windows.Forms.ListBox();
            this.SixQueue_L = new System.Windows.Forms.Label();
            this.SixQueue_LB = new System.Windows.Forms.ListBox();
            this.FiveQueue_L = new System.Windows.Forms.Label();
            this.FiveQueue_LB = new System.Windows.Forms.ListBox();
            this.FourQueue_L = new System.Windows.Forms.Label();
            this.FourQueue_LB = new System.Windows.Forms.ListBox();
            this.ThreeQueue_L = new System.Windows.Forms.Label();
            this.ThreeQueue_LB = new System.Windows.Forms.ListBox();
            this.TwoQueue_L = new System.Windows.Forms.Label();
            this.TwoQueue_LB = new System.Windows.Forms.ListBox();
            this.Popularities_L = new System.Windows.Forms.Label();
            this.OneQueue_L = new System.Windows.Forms.Label();
            this.OneQueue_LB = new System.Windows.Forms.ListBox();
            this.Log_L = new System.Windows.Forms.Label();
            this.Timer_T = new System.Windows.Forms.Timer(this.components);
            this.Management_GB.SuspendLayout();
            this.NewApplications_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfApplications_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Probability_NUD)).BeginInit();
            this.Stat_GB.SuspendLayout();
            this.Broadcast_GB.SuspendLayout();
            this.Queues_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // Management_GB
            // 
            this.Management_GB.Controls.Add(this.Manual_B);
            this.Management_GB.Controls.Add(this.Manual_RB);
            this.Management_GB.Controls.Add(this.Auto_RB);
            this.Management_GB.Location = new System.Drawing.Point(1489, 12);
            this.Management_GB.Name = "Management_GB";
            this.Management_GB.Size = new System.Drawing.Size(401, 147);
            this.Management_GB.TabIndex = 0;
            this.Management_GB.TabStop = false;
            this.Management_GB.Text = "Управление";
            // 
            // Manual_B
            // 
            this.Manual_B.Location = new System.Drawing.Point(206, 81);
            this.Manual_B.Name = "Manual_B";
            this.Manual_B.Size = new System.Drawing.Size(148, 39);
            this.Manual_B.TabIndex = 2;
            this.Manual_B.Text = "&Выполнить шаг";
            this.Manual_B.UseVisualStyleBackColor = true;
            this.Manual_B.Click += new System.EventHandler(this.Manual_B_Click);
            // 
            // Manual_RB
            // 
            this.Manual_RB.AutoSize = true;
            this.Manual_RB.Location = new System.Drawing.Point(47, 88);
            this.Manual_RB.Name = "Manual_RB";
            this.Manual_RB.Size = new System.Drawing.Size(97, 24);
            this.Manual_RB.TabIndex = 1;
            this.Manual_RB.TabStop = true;
            this.Manual_RB.Text = "&Вручную";
            this.Manual_RB.UseVisualStyleBackColor = true;
            this.Manual_RB.CheckedChanged += new System.EventHandler(this.SetMode);
            // 
            // Auto_RB
            // 
            this.Auto_RB.AutoSize = true;
            this.Auto_RB.Location = new System.Drawing.Point(47, 44);
            this.Auto_RB.Name = "Auto_RB";
            this.Auto_RB.Size = new System.Drawing.Size(152, 24);
            this.Auto_RB.TabIndex = 0;
            this.Auto_RB.TabStop = true;
            this.Auto_RB.Text = "&Автоматически";
            this.Auto_RB.UseVisualStyleBackColor = true;
            this.Auto_RB.CheckedChanged += new System.EventHandler(this.SetMode);
            // 
            // NewApplications_GB
            // 
            this.NewApplications_GB.Controls.Add(this.CountOfApplications_NUD);
            this.NewApplications_GB.Controls.Add(this.CountOfApplications_L);
            this.NewApplications_GB.Controls.Add(this.Probability_NUD);
            this.NewApplications_GB.Controls.Add(this.Probability_L);
            this.NewApplications_GB.Location = new System.Drawing.Point(1489, 170);
            this.NewApplications_GB.Name = "NewApplications_GB";
            this.NewApplications_GB.Size = new System.Drawing.Size(401, 134);
            this.NewApplications_GB.TabIndex = 1;
            this.NewApplications_GB.TabStop = false;
            this.NewApplications_GB.Text = "Новые заявки";
            // 
            // CountOfApplications_NUD
            // 
            this.CountOfApplications_NUD.Location = new System.Drawing.Point(275, 83);
            this.CountOfApplications_NUD.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CountOfApplications_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountOfApplications_NUD.Name = "CountOfApplications_NUD";
            this.CountOfApplications_NUD.Size = new System.Drawing.Size(120, 26);
            this.CountOfApplications_NUD.TabIndex = 3;
            this.CountOfApplications_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountOfApplications_NUD.ValueChanged += new System.EventHandler(this.CountOfApplications_NUD_ValueChanged);
            // 
            // CountOfApplications_L
            // 
            this.CountOfApplications_L.AutoSize = true;
            this.CountOfApplications_L.Location = new System.Drawing.Point(43, 89);
            this.CountOfApplications_L.Name = "CountOfApplications_L";
            this.CountOfApplications_L.Size = new System.Drawing.Size(159, 20);
            this.CountOfApplications_L.TabIndex = 2;
            this.CountOfApplications_L.Text = "&Количество от 1 до";
            // 
            // Probability_NUD
            // 
            this.Probability_NUD.Location = new System.Drawing.Point(275, 41);
            this.Probability_NUD.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Probability_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Probability_NUD.Name = "Probability_NUD";
            this.Probability_NUD.Size = new System.Drawing.Size(120, 26);
            this.Probability_NUD.TabIndex = 1;
            this.Probability_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Probability_NUD.ValueChanged += new System.EventHandler(this.Probability_NUD_ValueChanged);
            // 
            // Probability_L
            // 
            this.Probability_L.AutoSize = true;
            this.Probability_L.Location = new System.Drawing.Point(43, 43);
            this.Probability_L.Name = "Probability_L";
            this.Probability_L.Size = new System.Drawing.Size(229, 20);
            this.Probability_L.TabIndex = 0;
            this.Probability_L.Text = "В&ероятность появления 1 из";
            // 
            // Stat_GB
            // 
            this.Stat_GB.Controls.Add(this.Stat_L);
            this.Stat_GB.Controls.Add(this.Stat_TB);
            this.Stat_GB.Controls.Add(this.Stat_B);
            this.Stat_GB.Location = new System.Drawing.Point(1489, 310);
            this.Stat_GB.Name = "Stat_GB";
            this.Stat_GB.Size = new System.Drawing.Size(401, 557);
            this.Stat_GB.TabIndex = 2;
            this.Stat_GB.TabStop = false;
            this.Stat_GB.Text = "Отчёт";
            // 
            // Stat_L
            // 
            this.Stat_L.AutoSize = true;
            this.Stat_L.Location = new System.Drawing.Point(72, 63);
            this.Stat_L.Name = "Stat_L";
            this.Stat_L.Size = new System.Drawing.Size(158, 20);
            this.Stat_L.TabIndex = 2;
            this.Stat_L.Text = "&Результаты отчета";
            // 
            // Stat_TB
            // 
            this.Stat_TB.BackColor = System.Drawing.Color.White;
            this.Stat_TB.Location = new System.Drawing.Point(76, 86);
            this.Stat_TB.Multiline = true;
            this.Stat_TB.Name = "Stat_TB";
            this.Stat_TB.ReadOnly = true;
            this.Stat_TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Stat_TB.Size = new System.Drawing.Size(249, 447);
            this.Stat_TB.TabIndex = 1;
            // 
            // Stat_B
            // 
            this.Stat_B.Location = new System.Drawing.Point(76, 25);
            this.Stat_B.Name = "Stat_B";
            this.Stat_B.Size = new System.Drawing.Size(249, 33);
            this.Stat_B.TabIndex = 0;
            this.Stat_B.Text = "&Построить отчет";
            this.Stat_B.UseVisualStyleBackColor = true;
            this.Stat_B.Click += new System.EventHandler(this.Stat_B_Click);
            // 
            // Log_TB
            // 
            this.Log_TB.BackColor = System.Drawing.Color.White;
            this.Log_TB.Location = new System.Drawing.Point(12, 651);
            this.Log_TB.Multiline = true;
            this.Log_TB.Name = "Log_TB";
            this.Log_TB.ReadOnly = true;
            this.Log_TB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_TB.Size = new System.Drawing.Size(1458, 216);
            this.Log_TB.TabIndex = 3;
            // 
            // Broadcast_GB
            // 
            this.Broadcast_GB.Controls.Add(this.Broadcast_TB);
            this.Broadcast_GB.Controls.Add(this.Current_L);
            this.Broadcast_GB.Location = new System.Drawing.Point(12, 12);
            this.Broadcast_GB.Name = "Broadcast_GB";
            this.Broadcast_GB.Size = new System.Drawing.Size(405, 118);
            this.Broadcast_GB.TabIndex = 4;
            this.Broadcast_GB.TabStop = false;
            this.Broadcast_GB.Text = "Эфир";
            // 
            // Broadcast_TB
            // 
            this.Broadcast_TB.BackColor = System.Drawing.Color.White;
            this.Broadcast_TB.Location = new System.Drawing.Point(46, 61);
            this.Broadcast_TB.Name = "Broadcast_TB";
            this.Broadcast_TB.ReadOnly = true;
            this.Broadcast_TB.Size = new System.Drawing.Size(268, 26);
            this.Broadcast_TB.TabIndex = 1;
            // 
            // Current_L
            // 
            this.Current_L.AutoSize = true;
            this.Current_L.Location = new System.Drawing.Point(42, 32);
            this.Current_L.Name = "Current_L";
            this.Current_L.Size = new System.Drawing.Size(113, 20);
            this.Current_L.TabIndex = 0;
            this.Current_L.Text = "Текущий клип";
            // 
            // Queues_GB
            // 
            this.Queues_GB.Controls.Add(this.TenQueue_L);
            this.Queues_GB.Controls.Add(this.TenQueue_LB);
            this.Queues_GB.Controls.Add(this.NineQueue_L);
            this.Queues_GB.Controls.Add(this.NineQueue_LB);
            this.Queues_GB.Controls.Add(this.EightQueue_L);
            this.Queues_GB.Controls.Add(this.EightQueue_LB);
            this.Queues_GB.Controls.Add(this.SevenQueue_L);
            this.Queues_GB.Controls.Add(this.SevenQueue_LB);
            this.Queues_GB.Controls.Add(this.SixQueue_L);
            this.Queues_GB.Controls.Add(this.SixQueue_LB);
            this.Queues_GB.Controls.Add(this.FiveQueue_L);
            this.Queues_GB.Controls.Add(this.FiveQueue_LB);
            this.Queues_GB.Controls.Add(this.FourQueue_L);
            this.Queues_GB.Controls.Add(this.FourQueue_LB);
            this.Queues_GB.Controls.Add(this.ThreeQueue_L);
            this.Queues_GB.Controls.Add(this.ThreeQueue_LB);
            this.Queues_GB.Controls.Add(this.TwoQueue_L);
            this.Queues_GB.Controls.Add(this.TwoQueue_LB);
            this.Queues_GB.Controls.Add(this.Popularities_L);
            this.Queues_GB.Controls.Add(this.OneQueue_L);
            this.Queues_GB.Controls.Add(this.OneQueue_LB);
            this.Queues_GB.Location = new System.Drawing.Point(12, 176);
            this.Queues_GB.Name = "Queues_GB";
            this.Queues_GB.Size = new System.Drawing.Size(1458, 449);
            this.Queues_GB.TabIndex = 5;
            this.Queues_GB.TabStop = false;
            this.Queues_GB.Text = "Очереди клипов";
            // 
            // TenQueue_L
            // 
            this.TenQueue_L.AutoSize = true;
            this.TenQueue_L.Location = new System.Drawing.Point(1328, 42);
            this.TenQueue_L.Name = "TenQueue_L";
            this.TenQueue_L.Size = new System.Drawing.Size(27, 20);
            this.TenQueue_L.TabIndex = 20;
            this.TenQueue_L.Text = "10";
            // 
            // TenQueue_LB
            // 
            this.TenQueue_LB.FormattingEnabled = true;
            this.TenQueue_LB.HorizontalScrollbar = true;
            this.TenQueue_LB.ItemHeight = 20;
            this.TenQueue_LB.Location = new System.Drawing.Point(1307, 79);
            this.TenQueue_LB.Name = "TenQueue_LB";
            this.TenQueue_LB.Size = new System.Drawing.Size(128, 344);
            this.TenQueue_LB.TabIndex = 19;
            // 
            // NineQueue_L
            // 
            this.NineQueue_L.AutoSize = true;
            this.NineQueue_L.Location = new System.Drawing.Point(1194, 42);
            this.NineQueue_L.Name = "NineQueue_L";
            this.NineQueue_L.Size = new System.Drawing.Size(18, 20);
            this.NineQueue_L.TabIndex = 18;
            this.NineQueue_L.Text = "9";
            // 
            // NineQueue_LB
            // 
            this.NineQueue_LB.FormattingEnabled = true;
            this.NineQueue_LB.HorizontalScrollbar = true;
            this.NineQueue_LB.ItemHeight = 20;
            this.NineQueue_LB.Location = new System.Drawing.Point(1173, 79);
            this.NineQueue_LB.Name = "NineQueue_LB";
            this.NineQueue_LB.Size = new System.Drawing.Size(128, 344);
            this.NineQueue_LB.TabIndex = 17;
            // 
            // EightQueue_L
            // 
            this.EightQueue_L.AutoSize = true;
            this.EightQueue_L.Location = new System.Drawing.Point(1063, 42);
            this.EightQueue_L.Name = "EightQueue_L";
            this.EightQueue_L.Size = new System.Drawing.Size(18, 20);
            this.EightQueue_L.TabIndex = 16;
            this.EightQueue_L.Text = "8";
            // 
            // EightQueue_LB
            // 
            this.EightQueue_LB.FormattingEnabled = true;
            this.EightQueue_LB.HorizontalScrollbar = true;
            this.EightQueue_LB.ItemHeight = 20;
            this.EightQueue_LB.Location = new System.Drawing.Point(1042, 79);
            this.EightQueue_LB.Name = "EightQueue_LB";
            this.EightQueue_LB.Size = new System.Drawing.Size(128, 344);
            this.EightQueue_LB.TabIndex = 15;
            // 
            // SevenQueue_L
            // 
            this.SevenQueue_L.AutoSize = true;
            this.SevenQueue_L.Location = new System.Drawing.Point(932, 42);
            this.SevenQueue_L.Name = "SevenQueue_L";
            this.SevenQueue_L.Size = new System.Drawing.Size(18, 20);
            this.SevenQueue_L.TabIndex = 14;
            this.SevenQueue_L.Text = "7";
            // 
            // SevenQueue_LB
            // 
            this.SevenQueue_LB.FormattingEnabled = true;
            this.SevenQueue_LB.HorizontalScrollbar = true;
            this.SevenQueue_LB.ItemHeight = 20;
            this.SevenQueue_LB.Location = new System.Drawing.Point(911, 79);
            this.SevenQueue_LB.Name = "SevenQueue_LB";
            this.SevenQueue_LB.Size = new System.Drawing.Size(128, 344);
            this.SevenQueue_LB.TabIndex = 13;
            // 
            // SixQueue_L
            // 
            this.SixQueue_L.AutoSize = true;
            this.SixQueue_L.Location = new System.Drawing.Point(790, 42);
            this.SixQueue_L.Name = "SixQueue_L";
            this.SixQueue_L.Size = new System.Drawing.Size(18, 20);
            this.SixQueue_L.TabIndex = 12;
            this.SixQueue_L.Text = "6";
            // 
            // SixQueue_LB
            // 
            this.SixQueue_LB.FormattingEnabled = true;
            this.SixQueue_LB.HorizontalScrollbar = true;
            this.SixQueue_LB.ItemHeight = 20;
            this.SixQueue_LB.Location = new System.Drawing.Point(762, 79);
            this.SixQueue_LB.Name = "SixQueue_LB";
            this.SixQueue_LB.Size = new System.Drawing.Size(143, 344);
            this.SixQueue_LB.TabIndex = 11;
            // 
            // FiveQueue_L
            // 
            this.FiveQueue_L.AutoSize = true;
            this.FiveQueue_L.Location = new System.Drawing.Point(649, 42);
            this.FiveQueue_L.Name = "FiveQueue_L";
            this.FiveQueue_L.Size = new System.Drawing.Size(18, 20);
            this.FiveQueue_L.TabIndex = 10;
            this.FiveQueue_L.Text = "5";
            // 
            // FiveQueue_LB
            // 
            this.FiveQueue_LB.FormattingEnabled = true;
            this.FiveQueue_LB.HorizontalScrollbar = true;
            this.FiveQueue_LB.ItemHeight = 20;
            this.FiveQueue_LB.Location = new System.Drawing.Point(628, 79);
            this.FiveQueue_LB.Name = "FiveQueue_LB";
            this.FiveQueue_LB.Size = new System.Drawing.Size(128, 344);
            this.FiveQueue_LB.TabIndex = 9;
            // 
            // FourQueue_L
            // 
            this.FourQueue_L.AutoSize = true;
            this.FourQueue_L.Location = new System.Drawing.Point(498, 42);
            this.FourQueue_L.Name = "FourQueue_L";
            this.FourQueue_L.Size = new System.Drawing.Size(18, 20);
            this.FourQueue_L.TabIndex = 8;
            this.FourQueue_L.Text = "4";
            // 
            // FourQueue_LB
            // 
            this.FourQueue_LB.FormattingEnabled = true;
            this.FourQueue_LB.HorizontalScrollbar = true;
            this.FourQueue_LB.ItemHeight = 20;
            this.FourQueue_LB.Location = new System.Drawing.Point(477, 79);
            this.FourQueue_LB.Name = "FourQueue_LB";
            this.FourQueue_LB.Size = new System.Drawing.Size(145, 344);
            this.FourQueue_LB.TabIndex = 7;
            // 
            // ThreeQueue_L
            // 
            this.ThreeQueue_L.AutoSize = true;
            this.ThreeQueue_L.Location = new System.Drawing.Point(344, 42);
            this.ThreeQueue_L.Name = "ThreeQueue_L";
            this.ThreeQueue_L.Size = new System.Drawing.Size(18, 20);
            this.ThreeQueue_L.TabIndex = 6;
            this.ThreeQueue_L.Text = "3";
            // 
            // ThreeQueue_LB
            // 
            this.ThreeQueue_LB.FormattingEnabled = true;
            this.ThreeQueue_LB.HorizontalScrollbar = true;
            this.ThreeQueue_LB.ItemHeight = 20;
            this.ThreeQueue_LB.Location = new System.Drawing.Point(323, 79);
            this.ThreeQueue_LB.Name = "ThreeQueue_LB";
            this.ThreeQueue_LB.Size = new System.Drawing.Size(148, 344);
            this.ThreeQueue_LB.TabIndex = 5;
            // 
            // TwoQueue_L
            // 
            this.TwoQueue_L.AutoSize = true;
            this.TwoQueue_L.Location = new System.Drawing.Point(188, 42);
            this.TwoQueue_L.Name = "TwoQueue_L";
            this.TwoQueue_L.Size = new System.Drawing.Size(18, 20);
            this.TwoQueue_L.TabIndex = 4;
            this.TwoQueue_L.Text = "2";
            // 
            // TwoQueue_LB
            // 
            this.TwoQueue_LB.FormattingEnabled = true;
            this.TwoQueue_LB.HorizontalScrollbar = true;
            this.TwoQueue_LB.ItemHeight = 20;
            this.TwoQueue_LB.Location = new System.Drawing.Point(177, 79);
            this.TwoQueue_LB.Name = "TwoQueue_LB";
            this.TwoQueue_LB.Size = new System.Drawing.Size(140, 344);
            this.TwoQueue_LB.TabIndex = 3;
            // 
            // Popularities_L
            // 
            this.Popularities_L.AutoSize = true;
            this.Popularities_L.Location = new System.Drawing.Point(17, 22);
            this.Popularities_L.Name = "Popularities_L";
            this.Popularities_L.Size = new System.Drawing.Size(142, 20);
            this.Popularities_L.TabIndex = 2;
            this.Popularities_L.Text = "С популярностью";
            // 
            // OneQueue_L
            // 
            this.OneQueue_L.AutoSize = true;
            this.OneQueue_L.Location = new System.Drawing.Point(42, 42);
            this.OneQueue_L.Name = "OneQueue_L";
            this.OneQueue_L.Size = new System.Drawing.Size(18, 20);
            this.OneQueue_L.TabIndex = 1;
            this.OneQueue_L.Text = "1";
            // 
            // OneQueue_LB
            // 
            this.OneQueue_LB.FormattingEnabled = true;
            this.OneQueue_LB.HorizontalScrollbar = true;
            this.OneQueue_LB.ItemHeight = 20;
            this.OneQueue_LB.Location = new System.Drawing.Point(21, 79);
            this.OneQueue_LB.Name = "OneQueue_LB";
            this.OneQueue_LB.Size = new System.Drawing.Size(150, 344);
            this.OneQueue_LB.TabIndex = 0;
            // 
            // Log_L
            // 
            this.Log_L.AutoSize = true;
            this.Log_L.Location = new System.Drawing.Point(8, 628);
            this.Log_L.Name = "Log_L";
            this.Log_L.Size = new System.Drawing.Size(192, 20);
            this.Log_L.TabIndex = 6;
            this.Log_L.Text = "Выполненные действия";
            // 
            // Timer_T
            // 
            this.Timer_T.Interval = 60000;
            this.Timer_T.Tick += new System.EventHandler(this.Timer_T_Tick);
            // 
            // Main_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 882);
            this.Controls.Add(this.Log_L);
            this.Controls.Add(this.Queues_GB);
            this.Controls.Add(this.Broadcast_GB);
            this.Controls.Add(this.Log_TB);
            this.Controls.Add(this.Stat_GB);
            this.Controls.Add(this.NewApplications_GB);
            this.Controls.Add(this.Management_GB);
            this.Name = "Main_F";
            this.Text = "Музыкальный канал";
            this.Load += new System.EventHandler(this.Main_F_Load);
            this.Management_GB.ResumeLayout(false);
            this.Management_GB.PerformLayout();
            this.NewApplications_GB.ResumeLayout(false);
            this.NewApplications_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfApplications_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Probability_NUD)).EndInit();
            this.Stat_GB.ResumeLayout(false);
            this.Stat_GB.PerformLayout();
            this.Broadcast_GB.ResumeLayout(false);
            this.Broadcast_GB.PerformLayout();
            this.Queues_GB.ResumeLayout(false);
            this.Queues_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Management_GB;
        private System.Windows.Forms.Button Manual_B;
        private System.Windows.Forms.RadioButton Manual_RB;
        private System.Windows.Forms.RadioButton Auto_RB;
        private System.Windows.Forms.GroupBox NewApplications_GB;
        private System.Windows.Forms.NumericUpDown CountOfApplications_NUD;
        private System.Windows.Forms.Label CountOfApplications_L;
        private System.Windows.Forms.NumericUpDown Probability_NUD;
        private System.Windows.Forms.Label Probability_L;
        private System.Windows.Forms.GroupBox Stat_GB;
        private System.Windows.Forms.TextBox Stat_TB;
        private System.Windows.Forms.Button Stat_B;
        private System.Windows.Forms.TextBox Log_TB;
        private System.Windows.Forms.GroupBox Broadcast_GB;
        private System.Windows.Forms.TextBox Broadcast_TB;
        private System.Windows.Forms.Label Current_L;
        private System.Windows.Forms.GroupBox Queues_GB;
        private System.Windows.Forms.Label TenQueue_L;
        private System.Windows.Forms.ListBox TenQueue_LB;
        private System.Windows.Forms.Label NineQueue_L;
        private System.Windows.Forms.ListBox NineQueue_LB;
        private System.Windows.Forms.ListBox EightQueue_LB;
        private System.Windows.Forms.Label SevenQueue_L;
        private System.Windows.Forms.ListBox SevenQueue_LB;
        private System.Windows.Forms.Label SixQueue_L;
        private System.Windows.Forms.ListBox SixQueue_LB;
        private System.Windows.Forms.Label FiveQueue_L;
        private System.Windows.Forms.ListBox FiveQueue_LB;
        private System.Windows.Forms.Label FourQueue_L;
        private System.Windows.Forms.ListBox FourQueue_LB;
        private System.Windows.Forms.Label ThreeQueue_L;
        private System.Windows.Forms.ListBox ThreeQueue_LB;
        private System.Windows.Forms.Label TwoQueue_L;
        private System.Windows.Forms.ListBox TwoQueue_LB;
        private System.Windows.Forms.Label Popularities_L;
        private System.Windows.Forms.Label OneQueue_L;
        private System.Windows.Forms.ListBox OneQueue_LB;
        private System.Windows.Forms.Label Log_L;
        private System.Windows.Forms.Timer Timer_T;
        private System.Windows.Forms.Label Stat_L;
        private System.Windows.Forms.Label EightQueue_L;
    }
}

