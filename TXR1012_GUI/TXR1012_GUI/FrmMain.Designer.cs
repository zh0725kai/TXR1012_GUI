namespace TXR1012_GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_PortsSet = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EthernetSet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SetType = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Instruction = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_SlaveAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ComNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_BaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RunTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_kV = new System.Windows.Forms.GroupBox();
            this.txt_kVSet = new System.Windows.Forms.TextBox();
            this.aGauge_kV = new MyControls.AGauge();
            this.btn_kVSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_kV = new System.Windows.Forms.Label();
            this.groupBox_mA = new System.Windows.Forms.GroupBox();
            this.txt_mASet = new System.Windows.Forms.TextBox();
            this.btn_mASet = new System.Windows.Forms.Button();
            this.aGauge_mA = new MyControls.AGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.label_mA = new System.Windows.Forms.Label();
            this.groupBox_FilPreHeat = new System.Windows.Forms.GroupBox();
            this.txt_FilPreHeat = new System.Windows.Forms.TextBox();
            this.label_Filment = new System.Windows.Forms.Label();
            this.btn_FilPreHeatSet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_FilLimitHiden = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FilLimitSet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar_FilLimitSet = new System.Windows.Forms.TrackBar();
            this.btn_FilLimitSet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_InterLockError = new System.Windows.Forms.Label();
            this.label_InterLockOK = new System.Windows.Forms.Label();
            this.label_StateError = new System.Windows.Forms.Label();
            this.label_StateOK = new System.Windows.Forms.Label();
            this.label_Temp = new System.Windows.Forms.Label();
            this.label_Power = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_OpenHV = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_CloseHV = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape_CloseHV = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape_OpenHV = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox_kV.SuspendLayout();
            this.groupBox_mA.SuspendLayout();
            this.groupBox_FilPreHeat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FilLimitSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_PortsSet,
            this.ToolStripMenuItem_Set,
            this.ToolStripMenuItem_Help,
            this.ToolStripMenuItem_Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_PortsSet
            // 
            this.ToolStripMenuItem_PortsSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM口设置ToolStripMenuItem,
            this.ToolStripMenuItem_EthernetSet});
            this.ToolStripMenuItem_PortsSet.Name = "ToolStripMenuItem_PortsSet";
            this.ToolStripMenuItem_PortsSet.Size = new System.Drawing.Size(59, 21);
            this.ToolStripMenuItem_PortsSet.Text = "端口(&P)";
            // 
            // cOM口设置ToolStripMenuItem
            // 
            this.cOM口设置ToolStripMenuItem.Name = "cOM口设置ToolStripMenuItem";
            this.cOM口设置ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cOM口设置ToolStripMenuItem.Text = "COM口设置(&S)";
            this.cOM口设置ToolStripMenuItem.Click += new System.EventHandler(this.tsmi_COMSet_Click);
            // 
            // ToolStripMenuItem_EthernetSet
            // 
            this.ToolStripMenuItem_EthernetSet.Enabled = false;
            this.ToolStripMenuItem_EthernetSet.Name = "ToolStripMenuItem_EthernetSet";
            this.ToolStripMenuItem_EthernetSet.Size = new System.Drawing.Size(157, 22);
            this.ToolStripMenuItem_EthernetSet.Text = "以太网设置(&L)";
            // 
            // ToolStripMenuItem_Set
            // 
            this.ToolStripMenuItem_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SetType});
            this.ToolStripMenuItem_Set.Name = "ToolStripMenuItem_Set";
            this.ToolStripMenuItem_Set.Size = new System.Drawing.Size(59, 21);
            this.ToolStripMenuItem_Set.Text = "设置(&S)";
            // 
            // ToolStripMenuItem_SetType
            // 
            this.ToolStripMenuItem_SetType.Enabled = false;
            this.ToolStripMenuItem_SetType.Name = "ToolStripMenuItem_SetType";
            this.ToolStripMenuItem_SetType.Size = new System.Drawing.Size(163, 22);
            this.ToolStripMenuItem_SetType.Text = "设置机型规格(&T)";
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_About,
            this.ToolStripMenuItem_Instruction});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(61, 21);
            this.ToolStripMenuItem_Help.Text = "帮助(&H)";
            // 
            // ToolStripMenuItem_About
            // 
            this.ToolStripMenuItem_About.Name = "ToolStripMenuItem_About";
            this.ToolStripMenuItem_About.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_About.Text = "关于(&A)";
            this.ToolStripMenuItem_About.Click += new System.EventHandler(this.tsmi_About_Click);
            // 
            // ToolStripMenuItem_Instruction
            // 
            this.ToolStripMenuItem_Instruction.Name = "ToolStripMenuItem_Instruction";
            this.ToolStripMenuItem_Instruction.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Instruction.Text = "使用说明(&I)";
            this.ToolStripMenuItem_Instruction.Click += new System.EventHandler(this.tsmi_Intruction_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(62, 21);
            this.ToolStripMenuItem_Exit.Text = "关闭(&Q)";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_SlaveAddress,
            this.toolStripStatusLabel_ComNum,
            this.toolStripStatusLabel_BaudRate,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_RunTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(584, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_SlaveAddress
            // 
            this.toolStripStatusLabel_SlaveAddress.Name = "toolStripStatusLabel_SlaveAddress";
            this.toolStripStatusLabel_SlaveAddress.Size = new System.Drawing.Size(66, 20);
            this.toolStripStatusLabel_SlaveAddress.Text = "从机地址:1";
            // 
            // toolStripStatusLabel_ComNum
            // 
            this.toolStripStatusLabel_ComNum.Name = "toolStripStatusLabel_ComNum";
            this.toolStripStatusLabel_ComNum.Size = new System.Drawing.Size(129, 20);
            this.toolStripStatusLabel_ComNum.Text = "当前使用串口:COMXX";
            // 
            // toolStripStatusLabel_BaudRate
            // 
            this.toolStripStatusLabel_BaudRate.AutoSize = false;
            this.toolStripStatusLabel_BaudRate.Name = "toolStripStatusLabel_BaudRate";
            this.toolStripStatusLabel_BaudRate.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel_BaudRate.Text = "当前波特率:9600";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel1.Text = "软件运行时长:";
            // 
            // toolStripStatusLabel_RunTime
            // 
            this.toolStripStatusLabel_RunTime.Name = "toolStripStatusLabel_RunTime";
            this.toolStripStatusLabel_RunTime.Size = new System.Drawing.Size(32, 20);
            this.toolStripStatusLabel_RunTime.Text = "1:23";
            // 
            // groupBox_kV
            // 
            this.groupBox_kV.Controls.Add(this.txt_kVSet);
            this.groupBox_kV.Controls.Add(this.aGauge_kV);
            this.groupBox_kV.Controls.Add(this.btn_kVSet);
            this.groupBox_kV.Controls.Add(this.label2);
            this.groupBox_kV.Controls.Add(this.label_kV);
            this.groupBox_kV.Location = new System.Drawing.Point(14, 36);
            this.groupBox_kV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_kV.Name = "groupBox_kV";
            this.groupBox_kV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_kV.Size = new System.Drawing.Size(215, 318);
            this.groupBox_kV.TabIndex = 3;
            this.groupBox_kV.TabStop = false;
            this.groupBox_kV.Text = "管电压";
            // 
            // txt_kVSet
            // 
            this.txt_kVSet.Location = new System.Drawing.Point(76, 255);
            this.txt_kVSet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kVSet.Name = "txt_kVSet";
            this.txt_kVSet.Size = new System.Drawing.Size(63, 21);
            this.txt_kVSet.TabIndex = 5;
            this.txt_kVSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aGauge_kV
            // 
            this.aGauge_kV.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_kV.BaseArcRadius = 80;
            this.aGauge_kV.BaseArcStart = 135;
            this.aGauge_kV.BaseArcSweep = 270;
            this.aGauge_kV.BaseArcWidth = 2;
            this.aGauge_kV.Cap_Idx = ((byte)(0));
            this.aGauge_kV.CapColor = System.Drawing.Color.Red;
            this.aGauge_kV.CapFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge_kV.CapPosition = new System.Drawing.Point(93, 120);
            this.aGauge_kV.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(93, 120),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_kV.CapsText = new string[] {
        "kV",
        "",
        "",
        "",
        ""};
            this.aGauge_kV.CapText = "kV";
            this.aGauge_kV.Center = new System.Drawing.Point(105, 100);
            this.aGauge_kV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aGauge_kV.Location = new System.Drawing.Point(4, 82);
            this.aGauge_kV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aGauge_kV.MaxValue = 50F;
            this.aGauge_kV.MinValue = 0F;
            this.aGauge_kV.Name = "aGauge_kV";
            this.aGauge_kV.NeedleColor1 = MyControls.AGauge.NeedleColorEnum.Gray;
            this.aGauge_kV.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_kV.NeedleRadius = 80;
            this.aGauge_kV.NeedleType = 0;
            this.aGauge_kV.NeedleWidth = 3;
            this.aGauge_kV.Range_Idx = ((byte)(1));
            this.aGauge_kV.RangeColor = System.Drawing.Color.Red;
            this.aGauge_kV.RangeEnabled = true;
            this.aGauge_kV.RangeEndValue = 0.001F;
            this.aGauge_kV.RangeInnerRadius = 70;
            this.aGauge_kV.RangeOuterRadius = 80;
            this.aGauge_kV.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_kV.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge_kV.RangesEndValue = new float[] {
        300F,
        0.001F,
        0F,
        0F,
        0F};
            this.aGauge_kV.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_kV.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_kV.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge_kV.RangeStartValue = 0F;
            this.aGauge_kV.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_kV.ScaleLinesInterInnerRadius = 73;
            this.aGauge_kV.ScaleLinesInterOuterRadius = 80;
            this.aGauge_kV.ScaleLinesInterWidth = 1;
            this.aGauge_kV.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_kV.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_kV.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_kV.ScaleLinesMajorStepValue = 5F;
            this.aGauge_kV.ScaleLinesMajorWidth = 2;
            this.aGauge_kV.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_kV.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_kV.ScaleLinesMinorNumOf = 9;
            this.aGauge_kV.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_kV.ScaleLinesMinorWidth = 1;
            this.aGauge_kV.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_kV.ScaleNumbersFormat = null;
            this.aGauge_kV.ScaleNumbersRadius = 95;
            this.aGauge_kV.ScaleNumbersRotation = 0;
            this.aGauge_kV.ScaleNumbersStartScaleLine = 0;
            this.aGauge_kV.ScaleNumbersStepScaleLines = 1;
            this.aGauge_kV.Size = new System.Drawing.Size(205, 181);
            this.aGauge_kV.TabIndex = 4;
            this.aGauge_kV.Value = 0F;
            this.aGauge_kV.ValueInRangeChanged += new MyControls.AGauge.ValueInRangeChangedDelegate(this.aGauge_kV_ValueInRangeChanged);
            this.aGauge_kV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aGauge_kV_MouseDown);
            this.aGauge_kV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aGauge_kV_MouseMove);
            this.aGauge_kV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aGauge_kV_MouseUp);
            // 
            // btn_kVSet
            // 
            this.btn_kVSet.Location = new System.Drawing.Point(76, 280);
            this.btn_kVSet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kVSet.Name = "btn_kVSet";
            this.btn_kVSet.Size = new System.Drawing.Size(62, 27);
            this.btn_kVSet.TabIndex = 6;
            this.btn_kVSet.Text = "电压设定";
            this.btn_kVSet.UseVisualStyleBackColor = true;
            this.btn_kVSet.Click += new System.EventHandler(this.btn_kVSet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(146, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "kV";
            // 
            // label_kV
            // 
            this.label_kV.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_kV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_kV.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kV.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_kV.Location = new System.Drawing.Point(37, 30);
            this.label_kV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_kV.Name = "label_kV";
            this.label_kV.Size = new System.Drawing.Size(104, 40);
            this.label_kV.TabIndex = 3;
            this.label_kV.Text = "12.45";
            this.label_kV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_mA
            // 
            this.groupBox_mA.Controls.Add(this.txt_mASet);
            this.groupBox_mA.Controls.Add(this.btn_mASet);
            this.groupBox_mA.Controls.Add(this.aGauge_mA);
            this.groupBox_mA.Controls.Add(this.label3);
            this.groupBox_mA.Controls.Add(this.label_mA);
            this.groupBox_mA.Location = new System.Drawing.Point(245, 36);
            this.groupBox_mA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_mA.Name = "groupBox_mA";
            this.groupBox_mA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_mA.Size = new System.Drawing.Size(215, 318);
            this.groupBox_mA.TabIndex = 3;
            this.groupBox_mA.TabStop = false;
            this.groupBox_mA.Text = "管电流";
            // 
            // txt_mASet
            // 
            this.txt_mASet.Location = new System.Drawing.Point(77, 255);
            this.txt_mASet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mASet.Name = "txt_mASet";
            this.txt_mASet.Size = new System.Drawing.Size(63, 21);
            this.txt_mASet.TabIndex = 5;
            this.txt_mASet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_mASet
            // 
            this.btn_mASet.BackColor = System.Drawing.Color.Transparent;
            this.btn_mASet.Location = new System.Drawing.Point(77, 280);
            this.btn_mASet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mASet.Name = "btn_mASet";
            this.btn_mASet.Size = new System.Drawing.Size(62, 27);
            this.btn_mASet.TabIndex = 6;
            this.btn_mASet.Text = "电流设定";
            this.btn_mASet.UseVisualStyleBackColor = false;
            this.btn_mASet.Click += new System.EventHandler(this.btn_mASet_Click);
            // 
            // aGauge_mA
            // 
            this.aGauge_mA.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge_mA.BaseArcRadius = 80;
            this.aGauge_mA.BaseArcStart = 135;
            this.aGauge_mA.BaseArcSweep = 270;
            this.aGauge_mA.BaseArcWidth = 2;
            this.aGauge_mA.Cap_Idx = ((byte)(0));
            this.aGauge_mA.CapColor = System.Drawing.SystemColors.Highlight;
            this.aGauge_mA.CapFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge_mA.CapPosition = new System.Drawing.Point(93, 120);
            this.aGauge_mA.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(93, 120),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge_mA.CapsText = new string[] {
        "mA",
        "",
        "",
        "",
        ""};
            this.aGauge_mA.CapText = "mA";
            this.aGauge_mA.Center = new System.Drawing.Point(105, 100);
            this.aGauge_mA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aGauge_mA.Location = new System.Drawing.Point(4, 82);
            this.aGauge_mA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aGauge_mA.MaxValue = 1F;
            this.aGauge_mA.MinValue = 0F;
            this.aGauge_mA.Name = "aGauge_mA";
            this.aGauge_mA.NeedleColor1 = MyControls.AGauge.NeedleColorEnum.Gray;
            this.aGauge_mA.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge_mA.NeedleRadius = 80;
            this.aGauge_mA.NeedleType = 0;
            this.aGauge_mA.NeedleWidth = 3;
            this.aGauge_mA.Range_Idx = ((byte)(1));
            this.aGauge_mA.RangeColor = System.Drawing.SystemColors.Highlight;
            this.aGauge_mA.RangeEnabled = true;
            this.aGauge_mA.RangeEndValue = 0.001F;
            this.aGauge_mA.RangeInnerRadius = 70;
            this.aGauge_mA.RangeOuterRadius = 80;
            this.aGauge_mA.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.SystemColors.Highlight,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge_mA.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge_mA.RangesEndValue = new float[] {
        300F,
        0.001F,
        0F,
        0F,
        0F};
            this.aGauge_mA.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge_mA.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge_mA.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge_mA.RangeStartValue = 0F;
            this.aGauge_mA.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge_mA.ScaleLinesInterInnerRadius = 73;
            this.aGauge_mA.ScaleLinesInterOuterRadius = 80;
            this.aGauge_mA.ScaleLinesInterWidth = 1;
            this.aGauge_mA.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge_mA.ScaleLinesMajorInnerRadius = 70;
            this.aGauge_mA.ScaleLinesMajorOuterRadius = 80;
            this.aGauge_mA.ScaleLinesMajorStepValue = 0.1F;
            this.aGauge_mA.ScaleLinesMajorWidth = 2;
            this.aGauge_mA.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge_mA.ScaleLinesMinorInnerRadius = 75;
            this.aGauge_mA.ScaleLinesMinorNumOf = 9;
            this.aGauge_mA.ScaleLinesMinorOuterRadius = 80;
            this.aGauge_mA.ScaleLinesMinorWidth = 1;
            this.aGauge_mA.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge_mA.ScaleNumbersFormat = null;
            this.aGauge_mA.ScaleNumbersRadius = 95;
            this.aGauge_mA.ScaleNumbersRotation = 0;
            this.aGauge_mA.ScaleNumbersStartScaleLine = 0;
            this.aGauge_mA.ScaleNumbersStepScaleLines = 1;
            this.aGauge_mA.Size = new System.Drawing.Size(208, 181);
            this.aGauge_mA.TabIndex = 4;
            this.aGauge_mA.Value = 0F;
            this.aGauge_mA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aGauge_mA_MouseDown);
            this.aGauge_mA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.aGauge_mA_MouseMove);
            this.aGauge_mA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aGauge_mA_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(142, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "mA";
            // 
            // label_mA
            // 
            this.label_mA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_mA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_mA.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mA.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_mA.Location = new System.Drawing.Point(33, 30);
            this.label_mA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_mA.Name = "label_mA";
            this.label_mA.Size = new System.Drawing.Size(104, 40);
            this.label_mA.TabIndex = 3;
            this.label_mA.Text = "12.45";
            this.label_mA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_FilPreHeat
            // 
            this.groupBox_FilPreHeat.Controls.Add(this.txt_FilPreHeat);
            this.groupBox_FilPreHeat.Controls.Add(this.label_Filment);
            this.groupBox_FilPreHeat.Controls.Add(this.btn_FilPreHeatSet);
            this.groupBox_FilPreHeat.Controls.Add(this.label7);
            this.groupBox_FilPreHeat.Controls.Add(this.label8);
            this.groupBox_FilPreHeat.Controls.Add(this.label6);
            this.groupBox_FilPreHeat.Location = new System.Drawing.Point(14, 359);
            this.groupBox_FilPreHeat.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_FilPreHeat.Name = "groupBox_FilPreHeat";
            this.groupBox_FilPreHeat.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_FilPreHeat.Size = new System.Drawing.Size(309, 80);
            this.groupBox_FilPreHeat.TabIndex = 4;
            this.groupBox_FilPreHeat.TabStop = false;
            this.groupBox_FilPreHeat.Text = "灯丝预热";
            // 
            // txt_FilPreHeat
            // 
            this.txt_FilPreHeat.Location = new System.Drawing.Point(149, 26);
            this.txt_FilPreHeat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FilPreHeat.Name = "txt_FilPreHeat";
            this.txt_FilPreHeat.Size = new System.Drawing.Size(39, 21);
            this.txt_FilPreHeat.TabIndex = 5;
            this.txt_FilPreHeat.Text = "1";
            this.txt_FilPreHeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Filment
            // 
            this.label_Filment.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Filment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Filment.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filment.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_Filment.Location = new System.Drawing.Point(10, 24);
            this.label_Filment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filment.Name = "label_Filment";
            this.label_Filment.Size = new System.Drawing.Size(77, 36);
            this.label_Filment.TabIndex = 3;
            this.label_Filment.Text = "12.45";
            this.label_Filment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FilPreHeatSet
            // 
            this.btn_FilPreHeatSet.Location = new System.Drawing.Point(212, 22);
            this.btn_FilPreHeatSet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FilPreHeatSet.Name = "btn_FilPreHeatSet";
            this.btn_FilPreHeatSet.Size = new System.Drawing.Size(87, 27);
            this.btn_FilPreHeatSet.TabIndex = 6;
            this.btn_FilPreHeatSet.Text = "灯丝预热设定";
            this.btn_FilPreHeatSet.UseVisualStyleBackColor = true;
            this.btn_FilPreHeatSet.Click += new System.EventHandler(this.btn_FilPreHeatSet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(92, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(149, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 11);
            this.label8.TabIndex = 4;
            this.label8.Text = "标准最大设定2A，建议设定1A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(192, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_FilLimitHiden);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_FilLimitSet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.trackBar_FilLimitSet);
            this.groupBox1.Controls.Add(this.btn_FilLimitSet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(14, 448);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(305, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "灯丝限幅";
            // 
            // label_FilLimitHiden
            // 
            this.label_FilLimitHiden.AutoSize = true;
            this.label_FilLimitHiden.Location = new System.Drawing.Point(59, 9);
            this.label_FilLimitHiden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FilLimitHiden.Name = "label_FilLimitHiden";
            this.label_FilLimitHiden.Size = new System.Drawing.Size(29, 12);
            this.label_FilLimitHiden.TabIndex = 11;
            this.label_FilLimitHiden.Text = "3.1A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "4A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(61, 55);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 9;
            this.label23.Text = "2A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "0A";
            // 
            // txt_FilLimitSet
            // 
            this.txt_FilLimitSet.Location = new System.Drawing.Point(149, 22);
            this.txt_FilLimitSet.Margin = new System.Windows.Forms.Padding(2);
            this.txt_FilLimitSet.Name = "txt_FilLimitSet";
            this.txt_FilLimitSet.Size = new System.Drawing.Size(39, 21);
            this.txt_FilLimitSet.TabIndex = 5;
            this.txt_FilLimitSet.Text = "2.52";
            this.txt_FilLimitSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(129, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 11);
            this.label11.TabIndex = 4;
            this.label11.Text = "标准最大设定3.5A，建议设定2.5A";
            // 
            // trackBar_FilLimitSet
            // 
            this.trackBar_FilLimitSet.Location = new System.Drawing.Point(1, 23);
            this.trackBar_FilLimitSet.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_FilLimitSet.Maximum = 40;
            this.trackBar_FilLimitSet.Name = "trackBar_FilLimitSet";
            this.trackBar_FilLimitSet.Size = new System.Drawing.Size(134, 45);
            this.trackBar_FilLimitSet.TabIndex = 7;
            this.trackBar_FilLimitSet.TickFrequency = 5;
            this.trackBar_FilLimitSet.Scroll += new System.EventHandler(this.trackBar_FilLimitSet_Scroll);
            // 
            // btn_FilLimitSet
            // 
            this.btn_FilLimitSet.Location = new System.Drawing.Point(212, 19);
            this.btn_FilLimitSet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_FilLimitSet.Name = "btn_FilLimitSet";
            this.btn_FilLimitSet.Size = new System.Drawing.Size(87, 27);
            this.btn_FilLimitSet.TabIndex = 6;
            this.btn_FilLimitSet.Text = "灯丝限幅设定";
            this.btn_FilLimitSet.UseVisualStyleBackColor = true;
            this.btn_FilLimitSet.Click += new System.EventHandler(this.btn_FilLimitSet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(193, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label_InterLockError);
            this.groupBox2.Controls.Add(this.label_InterLockOK);
            this.groupBox2.Controls.Add(this.label_StateError);
            this.groupBox2.Controls.Add(this.label_StateOK);
            this.groupBox2.Controls.Add(this.label_Temp);
            this.groupBox2.Controls.Add(this.label_Power);
            this.groupBox2.Location = new System.Drawing.Point(326, 359);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(135, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统状态";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(64, 138);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(64, 11);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "通信状态:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 115);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "互锁开关:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 93);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "运行状态:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "工作温度:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "电源电压:";
            // 
            // label_InterLockError
            // 
            this.label_InterLockError.BackColor = System.Drawing.Color.Red;
            this.label_InterLockError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_InterLockError.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InterLockError.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_InterLockError.Location = new System.Drawing.Point(105, 110);
            this.label_InterLockError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InterLockError.Name = "label_InterLockError";
            this.label_InterLockError.Size = new System.Drawing.Size(20, 21);
            this.label_InterLockError.TabIndex = 3;
            this.label_InterLockError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_InterLockOK
            // 
            this.label_InterLockOK.BackColor = System.Drawing.Color.Chartreuse;
            this.label_InterLockOK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_InterLockOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InterLockOK.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_InterLockOK.Location = new System.Drawing.Point(68, 110);
            this.label_InterLockOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_InterLockOK.Name = "label_InterLockOK";
            this.label_InterLockOK.Size = new System.Drawing.Size(20, 21);
            this.label_InterLockOK.TabIndex = 3;
            this.label_InterLockOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StateError
            // 
            this.label_StateError.BackColor = System.Drawing.Color.Red;
            this.label_StateError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_StateError.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StateError.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_StateError.Location = new System.Drawing.Point(105, 86);
            this.label_StateError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StateError.Name = "label_StateError";
            this.label_StateError.Size = new System.Drawing.Size(20, 21);
            this.label_StateError.TabIndex = 3;
            this.label_StateError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StateOK
            // 
            this.label_StateOK.BackColor = System.Drawing.Color.Chartreuse;
            this.label_StateOK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_StateOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StateOK.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_StateOK.Location = new System.Drawing.Point(68, 86);
            this.label_StateOK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StateOK.Name = "label_StateOK";
            this.label_StateOK.Size = new System.Drawing.Size(20, 21);
            this.label_StateOK.TabIndex = 3;
            this.label_StateOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Temp
            // 
            this.label_Temp.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Temp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Temp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Temp.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_Temp.Location = new System.Drawing.Point(66, 46);
            this.label_Temp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Temp.Name = "label_Temp";
            this.label_Temp.Size = new System.Drawing.Size(62, 23);
            this.label_Temp.TabIndex = 3;
            this.label_Temp.Text = "12.45℃";
            this.label_Temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Power
            // 
            this.label_Power.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Power.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Power.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Power.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_Power.Location = new System.Drawing.Point(66, 23);
            this.label_Power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Power.Name = "label_Power";
            this.label_Power.Size = new System.Drawing.Size(62, 23);
            this.label_Power.TabIndex = 3;
            this.label_Power.Text = "24.3V";
            this.label_Power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btn_OpenHV);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btn_CloseHV);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Location = new System.Drawing.Point(475, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(98, 486);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制操作";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 457);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 20);
            this.button7.TabIndex = 0;
            this.button7.Text = "载入设置";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 433);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 20);
            this.button6.TabIndex = 0;
            this.button6.Text = "保存设置";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_OpenHV
            // 
            this.btn_OpenHV.BackColor = System.Drawing.Color.Tomato;
            this.btn_OpenHV.Location = new System.Drawing.Point(23, 48);
            this.btn_OpenHV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OpenHV.Name = "btn_OpenHV";
            this.btn_OpenHV.Size = new System.Drawing.Size(57, 32);
            this.btn_OpenHV.TabIndex = 0;
            this.btn_OpenHV.Text = "高压开";
            this.btn_OpenHV.UseVisualStyleBackColor = false;
            this.btn_OpenHV.Click += new System.EventHandler(this.btn_OpenHV_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 408);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 20);
            this.button5.TabIndex = 0;
            this.button5.Text = "复位软件";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_CloseHV
            // 
            this.btn_CloseHV.BackColor = System.Drawing.Color.Lime;
            this.btn_CloseHV.Location = new System.Drawing.Point(21, 126);
            this.btn_CloseHV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CloseHV.Name = "btn_CloseHV";
            this.btn_CloseHV.Size = new System.Drawing.Size(59, 32);
            this.btn_CloseHV.TabIndex = 0;
            this.btn_CloseHV.Text = "高压关";
            this.btn_CloseHV.UseVisualStyleBackColor = false;
            this.btn_CloseHV.Click += new System.EventHandler(this.btn_CloseHV_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(2, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_CloseHV,
            this.ovalShape_OpenHV});
            this.shapeContainer1.Size = new System.Drawing.Size(94, 468);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape_CloseHV
            // 
            this.ovalShape_CloseHV.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_CloseHV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape_CloseHV.FillColor = System.Drawing.Color.Lime;
            this.ovalShape_CloseHV.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_CloseHV.Location = new System.Drawing.Point(34, 80);
            this.ovalShape_CloseHV.Name = "ovalShape_CloseHV";
            this.ovalShape_CloseHV.Size = new System.Drawing.Size(25, 25);
            // 
            // ovalShape_OpenHV
            // 
            this.ovalShape_OpenHV.FillColor = System.Drawing.Color.Red;
            this.ovalShape_OpenHV.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_OpenHV.Location = new System.Drawing.Point(34, 3);
            this.ovalShape_OpenHV.Name = "ovalShape_OpenHV";
            this.ovalShape_OpenHV.Size = new System.Drawing.Size(25, 25);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_FilPreHeat);
            this.Controls.Add(this.groupBox_mA);
            this.Controls.Add(this.groupBox_kV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "[大连泰思曼科技有限公司]TXR1012上位机";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_kV.ResumeLayout(false);
            this.groupBox_kV.PerformLayout();
            this.groupBox_mA.ResumeLayout(false);
            this.groupBox_mA.PerformLayout();
            this.groupBox_FilPreHeat.ResumeLayout(false);
            this.groupBox_FilPreHeat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FilLimitSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_PortsSet;
        private System.Windows.Forms.ToolStripMenuItem cOM口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EthernetSet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Set;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        //public static System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox_kV;
        private System.Windows.Forms.Button btn_kVSet;
        private System.Windows.Forms.TextBox txt_kVSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_kV;
        private System.Windows.Forms.GroupBox groupBox_mA;
        private System.Windows.Forms.Button btn_mASet;
        private System.Windows.Forms.TextBox txt_mASet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_mA;
        private MyControls.AGauge aGauge_kV;
        private MyControls.AGauge aGauge_mA;
        private System.Windows.Forms.GroupBox groupBox_FilPreHeat;
        private System.Windows.Forms.TextBox txt_FilPreHeat;
        private System.Windows.Forms.Label label_Filment;
        private System.Windows.Forms.Button btn_FilPreHeatSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_FilLimitSet;
        private System.Windows.Forms.Button btn_FilLimitSet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_InterLockError;
        private System.Windows.Forms.Label label_InterLockOK;
        private System.Windows.Forms.Label label_StateError;
        private System.Windows.Forms.Label label_StateOK;
        private System.Windows.Forms.Label label_Temp;
        private System.Windows.Forms.Label label_Power;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_CloseHV;
        private System.Windows.Forms.Button btn_OpenHV;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_CloseHV;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_OpenHV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar_FilLimitSet;
        private System.Windows.Forms.Label label_FilLimitHiden;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SetType;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Instruction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SlaveAddress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ComNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_BaudRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RunTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

