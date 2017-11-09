namespace zero_gravity_moover
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.mot1speed = new System.Windows.Forms.TextBox();
            this.mot1dist = new System.Windows.Forms.TextBox();
            this.mot2speed = new System.Windows.Forms.TextBox();
            this.mot3speed = new System.Windows.Forms.TextBox();
            this.mot2dist = new System.Windows.Forms.TextBox();
            this.mot3dist = new System.Windows.Forms.TextBox();
            this.mot4speed = new System.Windows.Forms.TextBox();
            this.mot4dist = new System.Windows.Forms.TextBox();
            this.mot5speed = new System.Windows.Forms.TextBox();
            this.mot5dist = new System.Windows.Forms.TextBox();
            this.mot6speed = new System.Windows.Forms.TextBox();
            this.mot6dist = new System.Windows.Forms.TextBox();
            this.mot1 = new System.Windows.Forms.Label();
            this.mot2 = new System.Windows.Forms.Label();
            this.mot3 = new System.Windows.Forms.Label();
            this.mot4 = new System.Windows.Forms.Label();
            this.mot5 = new System.Windows.Forms.Label();
            this.mot6 = new System.Windows.Forms.Label();
            this.openPort = new System.Windows.Forms.Button();
            this.portName = new System.Windows.Forms.TextBox();
            this.comPortName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.portStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.startMove = new System.Windows.Forms.Button();
            this.addValues = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.m1s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addString = new System.Windows.Forms.Button();
            this.Speed_front_bar = new System.Windows.Forms.TrackBar();
            this.Tilt_up_bar = new System.Windows.Forms.TrackBar();
            this.Position_up_bar = new System.Windows.Forms.TrackBar();
            this.Speed_up_bar = new System.Windows.Forms.TrackBar();
            this.Position_back_bar = new System.Windows.Forms.TrackBar();
            this.Till_back_bar = new System.Windows.Forms.TrackBar();
            this.Speed_back_bar = new System.Windows.Forms.TrackBar();
            this.Tilt_front_bar = new System.Windows.Forms.TrackBar();
            this.Position_front_bar = new System.Windows.Forms.TrackBar();
            this.Tilt_front_label = new System.Windows.Forms.Label();
            this.Position_front_label = new System.Windows.Forms.Label();
            this.Speed_front_label = new System.Windows.Forms.Label();
            this.Speed_up_label = new System.Windows.Forms.Label();
            this.Position_up_label = new System.Windows.Forms.Label();
            this.Tilt_up_label = new System.Windows.Forms.Label();
            this.Tilt_back_label = new System.Windows.Forms.Label();
            this.Position_back_label = new System.Windows.Forms.Label();
            this.Speed_back_label = new System.Windows.Forms.Label();
            this.Motor_group_1 = new System.Windows.Forms.GroupBox();
            this.Acc_back_bar = new System.Windows.Forms.TrackBar();
            this.Acc_back_label = new System.Windows.Forms.Label();
            this.Motor_group_2 = new System.Windows.Forms.GroupBox();
            this.Acc_up_label = new System.Windows.Forms.Label();
            this.Acc_up_bar = new System.Windows.Forms.TrackBar();
            this.Motor_group_3 = new System.Windows.Forms.GroupBox();
            this.Acc_front_label = new System.Windows.Forms.Label();
            this.Acc_front_bar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.closePort = new System.Windows.Forms.Button();
            this.mot5_6tilt = new System.Windows.Forms.TextBox();
            this.mot5_6acc = new System.Windows.Forms.TextBox();
            this.mot3_4tilt = new System.Windows.Forms.TextBox();
            this.mot1_2tilt = new System.Windows.Forms.TextBox();
            this.mot3_4acc = new System.Windows.Forms.TextBox();
            this.mot1_2acc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_front_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tilt_up_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_up_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_up_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_back_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Till_back_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_back_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tilt_front_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_front_bar)).BeginInit();
            this.Motor_group_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_back_bar)).BeginInit();
            this.Motor_group_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_up_bar)).BeginInit();
            this.Motor_group_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_front_bar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mot1speed
            // 
            this.mot1speed.Location = new System.Drawing.Point(78, 61);
            this.mot1speed.Name = "mot1speed";
            this.mot1speed.Size = new System.Drawing.Size(100, 20);
            this.mot1speed.TabIndex = 0;
            // 
            // mot1dist
            // 
            this.mot1dist.Location = new System.Drawing.Point(78, 87);
            this.mot1dist.Name = "mot1dist";
            this.mot1dist.Size = new System.Drawing.Size(100, 20);
            this.mot1dist.TabIndex = 1;
            // 
            // mot2speed
            // 
            this.mot2speed.Location = new System.Drawing.Point(184, 61);
            this.mot2speed.Name = "mot2speed";
            this.mot2speed.Size = new System.Drawing.Size(100, 20);
            this.mot2speed.TabIndex = 2;
            // 
            // mot3speed
            // 
            this.mot3speed.Location = new System.Drawing.Point(290, 61);
            this.mot3speed.Name = "mot3speed";
            this.mot3speed.Size = new System.Drawing.Size(100, 20);
            this.mot3speed.TabIndex = 3;
            // 
            // mot2dist
            // 
            this.mot2dist.Location = new System.Drawing.Point(184, 87);
            this.mot2dist.Name = "mot2dist";
            this.mot2dist.Size = new System.Drawing.Size(100, 20);
            this.mot2dist.TabIndex = 4;
            // 
            // mot3dist
            // 
            this.mot3dist.Location = new System.Drawing.Point(290, 87);
            this.mot3dist.Name = "mot3dist";
            this.mot3dist.Size = new System.Drawing.Size(100, 20);
            this.mot3dist.TabIndex = 5;
            // 
            // mot4speed
            // 
            this.mot4speed.Location = new System.Drawing.Point(396, 61);
            this.mot4speed.Name = "mot4speed";
            this.mot4speed.Size = new System.Drawing.Size(100, 20);
            this.mot4speed.TabIndex = 6;
            // 
            // mot4dist
            // 
            this.mot4dist.Location = new System.Drawing.Point(396, 87);
            this.mot4dist.Name = "mot4dist";
            this.mot4dist.Size = new System.Drawing.Size(100, 20);
            this.mot4dist.TabIndex = 7;
            // 
            // mot5speed
            // 
            this.mot5speed.Location = new System.Drawing.Point(502, 61);
            this.mot5speed.Name = "mot5speed";
            this.mot5speed.Size = new System.Drawing.Size(100, 20);
            this.mot5speed.TabIndex = 8;
            // 
            // mot5dist
            // 
            this.mot5dist.Location = new System.Drawing.Point(502, 87);
            this.mot5dist.Name = "mot5dist";
            this.mot5dist.Size = new System.Drawing.Size(100, 20);
            this.mot5dist.TabIndex = 9;
            // 
            // mot6speed
            // 
            this.mot6speed.Location = new System.Drawing.Point(608, 61);
            this.mot6speed.Name = "mot6speed";
            this.mot6speed.Size = new System.Drawing.Size(100, 20);
            this.mot6speed.TabIndex = 10;
            // 
            // mot6dist
            // 
            this.mot6dist.Location = new System.Drawing.Point(608, 87);
            this.mot6dist.Name = "mot6dist";
            this.mot6dist.Size = new System.Drawing.Size(100, 20);
            this.mot6dist.TabIndex = 11;
            // 
            // mot1
            // 
            this.mot1.AutoSize = true;
            this.mot1.Location = new System.Drawing.Point(75, 45);
            this.mot1.Name = "mot1";
            this.mot1.Size = new System.Drawing.Size(78, 13);
            this.mot1.TabIndex = 12;
            this.mot1.Text = "M низ правый";
            // 
            // mot2
            // 
            this.mot2.AutoSize = true;
            this.mot2.Location = new System.Drawing.Point(184, 45);
            this.mot2.Name = "mot2";
            this.mot2.Size = new System.Drawing.Size(72, 13);
            this.mot2.TabIndex = 13;
            this.mot2.Text = "М низ левый";
            // 
            // mot3
            // 
            this.mot3.AutoSize = true;
            this.mot3.Location = new System.Drawing.Point(290, 45);
            this.mot3.Name = "mot3";
            this.mot3.Size = new System.Drawing.Size(83, 13);
            this.mot3.TabIndex = 14;
            this.mot3.Text = "М верх правый";
            // 
            // mot4
            // 
            this.mot4.AutoSize = true;
            this.mot4.Location = new System.Drawing.Point(396, 45);
            this.mot4.Name = "mot4";
            this.mot4.Size = new System.Drawing.Size(77, 13);
            this.mot4.TabIndex = 15;
            this.mot4.Text = "М верх левый";
            // 
            // mot5
            // 
            this.mot5.AutoSize = true;
            this.mot5.Location = new System.Drawing.Point(502, 45);
            this.mot5.Name = "mot5";
            this.mot5.Size = new System.Drawing.Size(96, 13);
            this.mot5.TabIndex = 16;
            this.mot5.Text = "М дальний левый";
            // 
            // mot6
            // 
            this.mot6.AutoSize = true;
            this.mot6.Location = new System.Drawing.Point(608, 45);
            this.mot6.Name = "mot6";
            this.mot6.Size = new System.Drawing.Size(102, 13);
            this.mot6.TabIndex = 17;
            this.mot6.Text = "М дальний правый";
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(6, 62);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(188, 23);
            this.openPort.TabIndex = 18;
            this.openPort.Text = "Open port";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // portName
            // 
            this.portName.Location = new System.Drawing.Point(6, 36);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(188, 20);
            this.portName.TabIndex = 19;
            // 
            // comPortName
            // 
            this.comPortName.AutoSize = true;
            this.comPortName.Location = new System.Drawing.Point(6, 16);
            this.comPortName.Name = "comPortName";
            this.comPortName.Size = new System.Drawing.Size(55, 17);
            this.comPortName.TabIndex = 20;
            this.comPortName.Text = "PortName";
            this.comPortName.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Serial port status";
            // 
            // portStatus
            // 
            this.portStatus.Location = new System.Drawing.Point(6, 137);
            this.portStatus.Name = "portStatus";
            this.portStatus.Size = new System.Drawing.Size(188, 20);
            this.portStatus.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Скорость";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Положение";
            // 
            // startMove
            // 
            this.startMove.BackColor = System.Drawing.Color.Lime;
            this.startMove.FlatAppearance.BorderSize = 0;
            this.startMove.Location = new System.Drawing.Point(650, 166);
            this.startMove.Name = "startMove";
            this.startMove.Size = new System.Drawing.Size(165, 36);
            this.startMove.TabIndex = 25;
            this.startMove.Text = "Запуск";
            this.startMove.UseVisualStyleBackColor = false;
            this.startMove.Click += new System.EventHandler(this.startMove_Click);
            // 
            // addValues
            // 
            this.addValues.Location = new System.Drawing.Point(714, 61);
            this.addValues.Name = "addValues";
            this.addValues.Size = new System.Drawing.Size(159, 46);
            this.addValues.TabIndex = 38;
            this.addValues.Text = "Заполнить форму по 200";
            this.addValues.UseVisualStyleBackColor = true;
            this.addValues.Click += new System.EventHandler(this.addValues_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m1s,
            this.m1d,
            this.m2s,
            this.m2d,
            this.m3s,
            this.m3d,
            this.m4s,
            this.m4d,
            this.m5s,
            this.m5d,
            this.m6s,
            this.m6d});
            this.dataGridView1.Location = new System.Drawing.Point(10, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 394);
            this.dataGridView1.TabIndex = 39;
            // 
            // m1s
            // 
            this.m1s.HeaderText = "m1speed";
            this.m1s.Name = "m1s";
            this.m1s.Width = 35;
            // 
            // m1d
            // 
            this.m1d.HeaderText = "m1distance";
            this.m1d.Name = "m1d";
            this.m1d.Width = 35;
            // 
            // m2s
            // 
            this.m2s.HeaderText = "m2speed";
            this.m2s.Name = "m2s";
            this.m2s.Width = 35;
            // 
            // m2d
            // 
            this.m2d.HeaderText = "m2distance";
            this.m2d.Name = "m2d";
            this.m2d.Width = 35;
            // 
            // m3s
            // 
            this.m3s.HeaderText = "m3speed";
            this.m3s.Name = "m3s";
            this.m3s.Width = 35;
            // 
            // m3d
            // 
            this.m3d.HeaderText = "m3distance";
            this.m3d.Name = "m3d";
            this.m3d.Width = 35;
            // 
            // m4s
            // 
            this.m4s.HeaderText = "m4speed";
            this.m4s.Name = "m4s";
            this.m4s.Width = 35;
            // 
            // m4d
            // 
            this.m4d.HeaderText = "m4distance";
            this.m4d.Name = "m4d";
            this.m4d.Width = 35;
            // 
            // m5s
            // 
            this.m5s.HeaderText = "m5speed";
            this.m5s.Name = "m5s";
            this.m5s.Width = 35;
            // 
            // m5d
            // 
            this.m5d.HeaderText = "m5distance";
            this.m5d.Name = "m5d";
            this.m5d.Width = 35;
            // 
            // m6s
            // 
            this.m6s.HeaderText = "m6speed";
            this.m6s.Name = "m6s";
            this.m6s.Width = 35;
            // 
            // m6d
            // 
            this.m6d.HeaderText = "m6distance";
            this.m6d.Name = "m6d";
            this.m6d.Width = 35;
            // 
            // addString
            // 
            this.addString.BackColor = System.Drawing.Color.Fuchsia;
            this.addString.Location = new System.Drawing.Point(479, 165);
            this.addString.Name = "addString";
            this.addString.Size = new System.Drawing.Size(165, 37);
            this.addString.TabIndex = 40;
            this.addString.Text = "Добавить действие";
            this.addString.UseVisualStyleBackColor = false;
            this.addString.Click += new System.EventHandler(this.addString_Click);
            // 
            // Speed_front_bar
            // 
            this.Speed_front_bar.LargeChange = 200;
            this.Speed_front_bar.Location = new System.Drawing.Point(6, 32);
            this.Speed_front_bar.Maximum = 4000;
            this.Speed_front_bar.Name = "Speed_front_bar";
            this.Speed_front_bar.Size = new System.Drawing.Size(239, 45);
            this.Speed_front_bar.SmallChange = 100;
            this.Speed_front_bar.TabIndex = 41;
            this.Speed_front_bar.ValueChanged += new System.EventHandler(this.Speed_front_bar_ValueChanged);
            // 
            // Tilt_up_bar
            // 
            this.Tilt_up_bar.LargeChange = 200;
            this.Tilt_up_bar.Location = new System.Drawing.Point(6, 161);
            this.Tilt_up_bar.Maximum = 1000;
            this.Tilt_up_bar.Minimum = -1000;
            this.Tilt_up_bar.Name = "Tilt_up_bar";
            this.Tilt_up_bar.Size = new System.Drawing.Size(239, 45);
            this.Tilt_up_bar.SmallChange = 100;
            this.Tilt_up_bar.TabIndex = 42;
            this.Tilt_up_bar.ValueChanged += new System.EventHandler(this.Tilt_up_bar_ValueChanged);
            // 
            // Position_up_bar
            // 
            this.Position_up_bar.LargeChange = 200;
            this.Position_up_bar.Location = new System.Drawing.Point(6, 96);
            this.Position_up_bar.Maximum = 2700;
            this.Position_up_bar.Name = "Position_up_bar";
            this.Position_up_bar.Size = new System.Drawing.Size(239, 45);
            this.Position_up_bar.SmallChange = 100;
            this.Position_up_bar.TabIndex = 43;
            this.Position_up_bar.ValueChanged += new System.EventHandler(this.Position_up_bar_ValueChanged);
            // 
            // Speed_up_bar
            // 
            this.Speed_up_bar.LargeChange = 200;
            this.Speed_up_bar.Location = new System.Drawing.Point(6, 32);
            this.Speed_up_bar.Maximum = 4000;
            this.Speed_up_bar.Name = "Speed_up_bar";
            this.Speed_up_bar.Size = new System.Drawing.Size(239, 45);
            this.Speed_up_bar.SmallChange = 100;
            this.Speed_up_bar.TabIndex = 44;
            this.Speed_up_bar.ValueChanged += new System.EventHandler(this.Speed_up_bar_ValueChanged);
            // 
            // Position_back_bar
            // 
            this.Position_back_bar.LargeChange = 10;
            this.Position_back_bar.Location = new System.Drawing.Point(6, 96);
            this.Position_back_bar.Maximum = 80;
            this.Position_back_bar.Name = "Position_back_bar";
            this.Position_back_bar.Size = new System.Drawing.Size(239, 45);
            this.Position_back_bar.SmallChange = 5;
            this.Position_back_bar.TabIndex = 45;
            this.Position_back_bar.ValueChanged += new System.EventHandler(this.Position_back_bar_ValueChanged);
            // 
            // Till_back_bar
            // 
            this.Till_back_bar.LargeChange = 200;
            this.Till_back_bar.Location = new System.Drawing.Point(6, 161);
            this.Till_back_bar.Maximum = 1000;
            this.Till_back_bar.Minimum = -1000;
            this.Till_back_bar.Name = "Till_back_bar";
            this.Till_back_bar.Size = new System.Drawing.Size(239, 45);
            this.Till_back_bar.SmallChange = 100;
            this.Till_back_bar.TabIndex = 46;
            this.Till_back_bar.ValueChanged += new System.EventHandler(this.Till_back_bar_ValueChanged);
            // 
            // Speed_back_bar
            // 
            this.Speed_back_bar.LargeChange = 200;
            this.Speed_back_bar.Location = new System.Drawing.Point(6, 32);
            this.Speed_back_bar.Maximum = 4000;
            this.Speed_back_bar.Name = "Speed_back_bar";
            this.Speed_back_bar.Size = new System.Drawing.Size(239, 45);
            this.Speed_back_bar.SmallChange = 100;
            this.Speed_back_bar.TabIndex = 47;
            this.Speed_back_bar.ValueChanged += new System.EventHandler(this.Speed_back_bar_ValueChanged);
            // 
            // Tilt_front_bar
            // 
            this.Tilt_front_bar.LargeChange = 200;
            this.Tilt_front_bar.Location = new System.Drawing.Point(6, 161);
            this.Tilt_front_bar.Maximum = 1000;
            this.Tilt_front_bar.Minimum = -1000;
            this.Tilt_front_bar.Name = "Tilt_front_bar";
            this.Tilt_front_bar.Size = new System.Drawing.Size(239, 45);
            this.Tilt_front_bar.SmallChange = 100;
            this.Tilt_front_bar.TabIndex = 48;
            this.Tilt_front_bar.ValueChanged += new System.EventHandler(this.Tilt_front_bar_ValueChanged);
            // 
            // Position_front_bar
            // 
            this.Position_front_bar.LargeChange = 200;
            this.Position_front_bar.Location = new System.Drawing.Point(6, 96);
            this.Position_front_bar.Maximum = 3500;
            this.Position_front_bar.Name = "Position_front_bar";
            this.Position_front_bar.Size = new System.Drawing.Size(239, 45);
            this.Position_front_bar.SmallChange = 100;
            this.Position_front_bar.TabIndex = 49;
            this.Position_front_bar.ValueChanged += new System.EventHandler(this.Position_front_bar_ValueChanged);
            // 
            // Tilt_front_label
            // 
            this.Tilt_front_label.AutoSize = true;
            this.Tilt_front_label.Location = new System.Drawing.Point(6, 144);
            this.Tilt_front_label.Name = "Tilt_front_label";
            this.Tilt_front_label.Size = new System.Drawing.Size(45, 13);
            this.Tilt_front_label.TabIndex = 50;
            this.Tilt_front_label.Text = "Наклон";
            // 
            // Position_front_label
            // 
            this.Position_front_label.AutoSize = true;
            this.Position_front_label.Location = new System.Drawing.Point(6, 80);
            this.Position_front_label.Name = "Position_front_label";
            this.Position_front_label.Size = new System.Drawing.Size(65, 13);
            this.Position_front_label.TabIndex = 51;
            this.Position_front_label.Text = "Положение";
            // 
            // Speed_front_label
            // 
            this.Speed_front_label.AutoSize = true;
            this.Speed_front_label.Location = new System.Drawing.Point(6, 16);
            this.Speed_front_label.Name = "Speed_front_label";
            this.Speed_front_label.Size = new System.Drawing.Size(55, 13);
            this.Speed_front_label.TabIndex = 52;
            this.Speed_front_label.Text = "Скорость";
            // 
            // Speed_up_label
            // 
            this.Speed_up_label.AutoSize = true;
            this.Speed_up_label.Location = new System.Drawing.Point(6, 16);
            this.Speed_up_label.Name = "Speed_up_label";
            this.Speed_up_label.Size = new System.Drawing.Size(55, 13);
            this.Speed_up_label.TabIndex = 53;
            this.Speed_up_label.Text = "Скорость";
            // 
            // Position_up_label
            // 
            this.Position_up_label.AutoSize = true;
            this.Position_up_label.Location = new System.Drawing.Point(6, 80);
            this.Position_up_label.Name = "Position_up_label";
            this.Position_up_label.Size = new System.Drawing.Size(65, 13);
            this.Position_up_label.TabIndex = 54;
            this.Position_up_label.Text = "Положение";
            // 
            // Tilt_up_label
            // 
            this.Tilt_up_label.AutoSize = true;
            this.Tilt_up_label.Location = new System.Drawing.Point(6, 144);
            this.Tilt_up_label.Name = "Tilt_up_label";
            this.Tilt_up_label.Size = new System.Drawing.Size(45, 13);
            this.Tilt_up_label.TabIndex = 55;
            this.Tilt_up_label.Text = "Наклон";
            // 
            // Tilt_back_label
            // 
            this.Tilt_back_label.AutoSize = true;
            this.Tilt_back_label.Location = new System.Drawing.Point(6, 144);
            this.Tilt_back_label.Name = "Tilt_back_label";
            this.Tilt_back_label.Size = new System.Drawing.Size(45, 13);
            this.Tilt_back_label.TabIndex = 56;
            this.Tilt_back_label.Text = "Наклон";
            // 
            // Position_back_label
            // 
            this.Position_back_label.AutoSize = true;
            this.Position_back_label.Location = new System.Drawing.Point(6, 80);
            this.Position_back_label.Name = "Position_back_label";
            this.Position_back_label.Size = new System.Drawing.Size(65, 13);
            this.Position_back_label.TabIndex = 57;
            this.Position_back_label.Text = "Положение";
            // 
            // Speed_back_label
            // 
            this.Speed_back_label.AutoSize = true;
            this.Speed_back_label.Location = new System.Drawing.Point(6, 16);
            this.Speed_back_label.Name = "Speed_back_label";
            this.Speed_back_label.Size = new System.Drawing.Size(55, 13);
            this.Speed_back_label.TabIndex = 58;
            this.Speed_back_label.Text = "Скорость";
            // 
            // Motor_group_1
            // 
            this.Motor_group_1.Controls.Add(this.Acc_back_bar);
            this.Motor_group_1.Controls.Add(this.Position_back_label);
            this.Motor_group_1.Controls.Add(this.Speed_back_label);
            this.Motor_group_1.Controls.Add(this.Speed_back_bar);
            this.Motor_group_1.Controls.Add(this.Position_back_bar);
            this.Motor_group_1.Controls.Add(this.Acc_back_label);
            this.Motor_group_1.Controls.Add(this.Tilt_back_label);
            this.Motor_group_1.Controls.Add(this.Till_back_bar);
            this.Motor_group_1.Location = new System.Drawing.Point(479, 254);
            this.Motor_group_1.Name = "Motor_group_1";
            this.Motor_group_1.Size = new System.Drawing.Size(251, 281);
            this.Motor_group_1.TabIndex = 59;
            this.Motor_group_1.TabStop = false;
            this.Motor_group_1.Text = "Задний нижний";
            // 
            // Acc_back_bar
            // 
            this.Acc_back_bar.LargeChange = 200;
            this.Acc_back_bar.Location = new System.Drawing.Point(6, 225);
            this.Acc_back_bar.Maximum = 7000;
            this.Acc_back_bar.Name = "Acc_back_bar";
            this.Acc_back_bar.Size = new System.Drawing.Size(239, 45);
            this.Acc_back_bar.SmallChange = 100;
            this.Acc_back_bar.TabIndex = 65;
            this.Acc_back_bar.Value = 7000;
            this.Acc_back_bar.ValueChanged += new System.EventHandler(this.Acc_back_bar_ValueChanged);
            // 
            // Acc_back_label
            // 
            this.Acc_back_label.AutoSize = true;
            this.Acc_back_label.Location = new System.Drawing.Point(6, 209);
            this.Acc_back_label.Name = "Acc_back_label";
            this.Acc_back_label.Size = new System.Drawing.Size(63, 13);
            this.Acc_back_label.TabIndex = 61;
            this.Acc_back_label.Text = "Ускорение";
            // 
            // Motor_group_2
            // 
            this.Motor_group_2.Controls.Add(this.Acc_up_label);
            this.Motor_group_2.Controls.Add(this.Acc_up_bar);
            this.Motor_group_2.Controls.Add(this.Speed_up_bar);
            this.Motor_group_2.Controls.Add(this.Position_up_bar);
            this.Motor_group_2.Controls.Add(this.Tilt_up_bar);
            this.Motor_group_2.Controls.Add(this.Tilt_up_label);
            this.Motor_group_2.Controls.Add(this.Speed_up_label);
            this.Motor_group_2.Controls.Add(this.Position_up_label);
            this.Motor_group_2.Location = new System.Drawing.Point(736, 254);
            this.Motor_group_2.Name = "Motor_group_2";
            this.Motor_group_2.Size = new System.Drawing.Size(251, 281);
            this.Motor_group_2.TabIndex = 0;
            this.Motor_group_2.TabStop = false;
            this.Motor_group_2.Text = "Верхний средний";
            // 
            // Acc_up_label
            // 
            this.Acc_up_label.AutoSize = true;
            this.Acc_up_label.Location = new System.Drawing.Point(6, 209);
            this.Acc_up_label.Name = "Acc_up_label";
            this.Acc_up_label.Size = new System.Drawing.Size(63, 13);
            this.Acc_up_label.TabIndex = 62;
            this.Acc_up_label.Text = "Ускорение";
            // 
            // Acc_up_bar
            // 
            this.Acc_up_bar.LargeChange = 200;
            this.Acc_up_bar.Location = new System.Drawing.Point(6, 225);
            this.Acc_up_bar.Maximum = 7000;
            this.Acc_up_bar.Name = "Acc_up_bar";
            this.Acc_up_bar.Size = new System.Drawing.Size(239, 45);
            this.Acc_up_bar.SmallChange = 100;
            this.Acc_up_bar.TabIndex = 64;
            this.Acc_up_bar.Value = 7000;
            this.Acc_up_bar.ValueChanged += new System.EventHandler(this.Acc_up_bar_ValueChanged);
            // 
            // Motor_group_3
            // 
            this.Motor_group_3.Controls.Add(this.Acc_front_label);
            this.Motor_group_3.Controls.Add(this.Acc_front_bar);
            this.Motor_group_3.Controls.Add(this.Speed_front_bar);
            this.Motor_group_3.Controls.Add(this.Position_front_bar);
            this.Motor_group_3.Controls.Add(this.Tilt_front_bar);
            this.Motor_group_3.Controls.Add(this.Speed_front_label);
            this.Motor_group_3.Controls.Add(this.Tilt_front_label);
            this.Motor_group_3.Controls.Add(this.Position_front_label);
            this.Motor_group_3.Location = new System.Drawing.Point(993, 254);
            this.Motor_group_3.Name = "Motor_group_3";
            this.Motor_group_3.Size = new System.Drawing.Size(251, 281);
            this.Motor_group_3.TabIndex = 0;
            this.Motor_group_3.TabStop = false;
            this.Motor_group_3.Text = "Передний верхний";
            // 
            // Acc_front_label
            // 
            this.Acc_front_label.AutoSize = true;
            this.Acc_front_label.Location = new System.Drawing.Point(6, 209);
            this.Acc_front_label.Name = "Acc_front_label";
            this.Acc_front_label.Size = new System.Drawing.Size(63, 13);
            this.Acc_front_label.TabIndex = 60;
            this.Acc_front_label.Text = "Ускорение";
            // 
            // Acc_front_bar
            // 
            this.Acc_front_bar.LargeChange = 200;
            this.Acc_front_bar.Location = new System.Drawing.Point(6, 225);
            this.Acc_front_bar.Maximum = 7000;
            this.Acc_front_bar.Name = "Acc_front_bar";
            this.Acc_front_bar.Size = new System.Drawing.Size(239, 45);
            this.Acc_front_bar.SmallChange = 100;
            this.Acc_front_bar.TabIndex = 63;
            this.Acc_front_bar.Value = 7000;
            this.Acc_front_bar.ValueChanged += new System.EventHandler(this.Acc_front_bar_ValueChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.closePort);
            this.groupBox4.Controls.Add(this.comPortName);
            this.groupBox4.Controls.Add(this.portName);
            this.groupBox4.Controls.Add(this.openPort);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.portStatus);
            this.groupBox4.Location = new System.Drawing.Point(1054, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 165);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройки COM_порта";
            // 
            // closePort
            // 
            this.closePort.Enabled = false;
            this.closePort.Location = new System.Drawing.Point(6, 91);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(188, 23);
            this.closePort.TabIndex = 23;
            this.closePort.Text = "Close port";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.closePort_Click);
            // 
            // mot5_6tilt
            // 
            this.mot5_6tilt.Location = new System.Drawing.Point(502, 139);
            this.mot5_6tilt.Name = "mot5_6tilt";
            this.mot5_6tilt.Size = new System.Drawing.Size(206, 20);
            this.mot5_6tilt.TabIndex = 60;
            // 
            // mot5_6acc
            // 
            this.mot5_6acc.Location = new System.Drawing.Point(502, 114);
            this.mot5_6acc.Name = "mot5_6acc";
            this.mot5_6acc.Size = new System.Drawing.Size(206, 20);
            this.mot5_6acc.TabIndex = 61;
            // 
            // mot3_4tilt
            // 
            this.mot3_4tilt.Location = new System.Drawing.Point(290, 139);
            this.mot3_4tilt.Name = "mot3_4tilt";
            this.mot3_4tilt.Size = new System.Drawing.Size(206, 20);
            this.mot3_4tilt.TabIndex = 62;
            // 
            // mot1_2tilt
            // 
            this.mot1_2tilt.Location = new System.Drawing.Point(78, 139);
            this.mot1_2tilt.Name = "mot1_2tilt";
            this.mot1_2tilt.Size = new System.Drawing.Size(206, 20);
            this.mot1_2tilt.TabIndex = 63;
            // 
            // mot3_4acc
            // 
            this.mot3_4acc.Location = new System.Drawing.Point(290, 114);
            this.mot3_4acc.Name = "mot3_4acc";
            this.mot3_4acc.Size = new System.Drawing.Size(206, 20);
            this.mot3_4acc.TabIndex = 64;
            // 
            // mot1_2acc
            // 
            this.mot1_2acc.Location = new System.Drawing.Point(78, 113);
            this.mot1_2acc.Name = "mot1_2acc";
            this.mot1_2acc.Size = new System.Drawing.Size(206, 20);
            this.mot1_2acc.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Наклон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ускорение";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileBtn,
            this.SaveFileBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(66, 20);
            this.OpenFileBtn.Text = "Открыть";
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(77, 20);
            this.SaveFileBtn.Text = "Сохранить";
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(821, 166);
            this.Stop.Name = "Stop";
            this.Stop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Stop.Size = new System.Drawing.Size(227, 36);
            this.Stop.TabIndex = 69;
            this.Stop.Text = "СТОП!";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 566);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mot1_2acc);
            this.Controls.Add(this.mot3_4acc);
            this.Controls.Add(this.mot1_2tilt);
            this.Controls.Add(this.mot3_4tilt);
            this.Controls.Add(this.mot5_6acc);
            this.Controls.Add(this.mot5_6tilt);
            this.Controls.Add(this.Motor_group_2);
            this.Controls.Add(this.Motor_group_3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Motor_group_1);
            this.Controls.Add(this.addString);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addValues);
            this.Controls.Add(this.startMove);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mot6);
            this.Controls.Add(this.mot5);
            this.Controls.Add(this.mot4);
            this.Controls.Add(this.mot3);
            this.Controls.Add(this.mot2);
            this.Controls.Add(this.mot1);
            this.Controls.Add(this.mot6dist);
            this.Controls.Add(this.mot6speed);
            this.Controls.Add(this.mot5dist);
            this.Controls.Add(this.mot5speed);
            this.Controls.Add(this.mot4dist);
            this.Controls.Add(this.mot4speed);
            this.Controls.Add(this.mot3dist);
            this.Controls.Add(this.mot2dist);
            this.Controls.Add(this.mot3speed);
            this.Controls.Add(this.mot2speed);
            this.Controls.Add(this.mot1dist);
            this.Controls.Add(this.mot1speed);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_front_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tilt_up_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_up_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_up_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_back_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Till_back_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_back_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tilt_front_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Position_front_bar)).EndInit();
            this.Motor_group_1.ResumeLayout(false);
            this.Motor_group_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_back_bar)).EndInit();
            this.Motor_group_2.ResumeLayout(false);
            this.Motor_group_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_up_bar)).EndInit();
            this.Motor_group_3.ResumeLayout(false);
            this.Motor_group_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Acc_front_bar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox mot1speed;
        private System.Windows.Forms.TextBox mot1dist;
        private System.Windows.Forms.TextBox mot2speed;
        private System.Windows.Forms.TextBox mot3speed;
        private System.Windows.Forms.TextBox mot2dist;
        private System.Windows.Forms.TextBox mot3dist;
        private System.Windows.Forms.TextBox mot4speed;
        private System.Windows.Forms.TextBox mot4dist;
        private System.Windows.Forms.TextBox mot5speed;
        private System.Windows.Forms.TextBox mot5dist;
        private System.Windows.Forms.TextBox mot6speed;
        private System.Windows.Forms.TextBox mot6dist;
        private System.Windows.Forms.Label mot1;
        private System.Windows.Forms.Label mot2;
        private System.Windows.Forms.Label mot3;
        private System.Windows.Forms.Label mot4;
        private System.Windows.Forms.Label mot5;
        private System.Windows.Forms.Label mot6;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.TextBox portName;
        private System.Windows.Forms.Label comPortName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox portStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button startMove;
        private System.Windows.Forms.Button addValues;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addString;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1d;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2d;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3d;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4d;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5d;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6s;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6d;
        private System.Windows.Forms.TrackBar Speed_front_bar;
        private System.Windows.Forms.TrackBar Tilt_up_bar;
        private System.Windows.Forms.TrackBar Position_up_bar;
        private System.Windows.Forms.TrackBar Speed_up_bar;
        private System.Windows.Forms.TrackBar Position_back_bar;
        private System.Windows.Forms.TrackBar Till_back_bar;
        private System.Windows.Forms.TrackBar Speed_back_bar;
        private System.Windows.Forms.TrackBar Tilt_front_bar;
        private System.Windows.Forms.TrackBar Position_front_bar;
        private System.Windows.Forms.Label Tilt_front_label;
        private System.Windows.Forms.Label Position_front_label;
        private System.Windows.Forms.Label Speed_front_label;
        private System.Windows.Forms.Label Speed_up_label;
        private System.Windows.Forms.Label Position_up_label;
        private System.Windows.Forms.Label Tilt_up_label;
        private System.Windows.Forms.Label Tilt_back_label;
        private System.Windows.Forms.Label Position_back_label;
        private System.Windows.Forms.Label Speed_back_label;
        private System.Windows.Forms.GroupBox Motor_group_1;
        private System.Windows.Forms.GroupBox Motor_group_2;
        private System.Windows.Forms.GroupBox Motor_group_3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar Acc_back_bar;
        private System.Windows.Forms.Label Acc_back_label;
        private System.Windows.Forms.Label Acc_up_label;
        private System.Windows.Forms.TrackBar Acc_up_bar;
        private System.Windows.Forms.Label Acc_front_label;
        private System.Windows.Forms.TrackBar Acc_front_bar;
        private System.Windows.Forms.TextBox mot5_6tilt;
        private System.Windows.Forms.TextBox mot5_6acc;
        private System.Windows.Forms.TextBox mot3_4tilt;
        private System.Windows.Forms.TextBox mot1_2tilt;
        private System.Windows.Forms.TextBox mot3_4acc;
        private System.Windows.Forms.TextBox mot1_2acc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileBtn;
        private System.Windows.Forms.ToolStripMenuItem SaveFileBtn;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.Button Stop;
    }
}

