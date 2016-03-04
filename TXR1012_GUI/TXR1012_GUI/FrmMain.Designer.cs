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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOM口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以太网设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox_kV = new System.Windows.Forms.GroupBox();
            this.txt_kVSet = new System.Windows.Forms.TextBox();
            this.aGauge1 = new MyControls.AGauge();
            this.btn_kVSet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_kV = new System.Windows.Forms.Label();
            this.groupBox_mA = new System.Windows.Forms.GroupBox();
            this.txt_mASet = new System.Windows.Forms.TextBox();
            this.btn_mASet = new System.Windows.Forms.Button();
            this.aGauge2 = new MyControls.AGauge();
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
            this.txt_FilLimit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar_FilLimitSet = new System.Windows.Forms.TrackBar();
            this.btn_FilLimitSet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.端口ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出QToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 端口ToolStripMenuItem
            // 
            this.端口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM口设置ToolStripMenuItem,
            this.以太网设置ToolStripMenuItem});
            this.端口ToolStripMenuItem.Name = "端口ToolStripMenuItem";
            this.端口ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.端口ToolStripMenuItem.Text = "端口(&P)";
            // 
            // cOM口设置ToolStripMenuItem
            // 
            this.cOM口设置ToolStripMenuItem.Name = "cOM口设置ToolStripMenuItem";
            this.cOM口设置ToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.cOM口设置ToolStripMenuItem.Text = "COM口设置(&S)";
            // 
            // 以太网设置ToolStripMenuItem
            // 
            this.以太网设置ToolStripMenuItem.Name = "以太网设置ToolStripMenuItem";
            this.以太网设置ToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.以太网设置ToolStripMenuItem.Text = "以太网设置(&L)";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.设置ToolStripMenuItem.Text = "设置(&S)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(&F1)";
            // 
            // 退出QToolStripMenuItem
            // 
            this.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem";
            this.退出QToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.退出QToolStripMenuItem.Text = "退出（&Q）";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox_kV
            // 
            this.groupBox_kV.Controls.Add(this.txt_kVSet);
            this.groupBox_kV.Controls.Add(this.aGauge1);
            this.groupBox_kV.Controls.Add(this.btn_kVSet);
            this.groupBox_kV.Controls.Add(this.label2);
            this.groupBox_kV.Controls.Add(this.label_kV);
            this.groupBox_kV.Location = new System.Drawing.Point(19, 45);
            this.groupBox_kV.Name = "groupBox_kV";
            this.groupBox_kV.Size = new System.Drawing.Size(223, 352);
            this.groupBox_kV.TabIndex = 3;
            this.groupBox_kV.TabStop = false;
            this.groupBox_kV.Text = "管电压";
            // 
            // txt_kVSet
            // 
            this.txt_kVSet.Location = new System.Drawing.Point(67, 276);
            this.txt_kVSet.Name = "txt_kVSet";
            this.txt_kVSet.Size = new System.Drawing.Size(83, 25);
            this.txt_kVSet.TabIndex = 5;
            this.txt_kVSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColor = System.Drawing.Color.Red;
            this.aGauge1.CapFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge1.CapPosition = new System.Drawing.Point(93, 120);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(93, 120),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "kV",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "kV";
            this.aGauge1.Center = new System.Drawing.Point(105, 100);
            this.aGauge1.Location = new System.Drawing.Point(6, 103);
            this.aGauge1.MaxValue = 50F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = MyControls.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge1.NeedleRadius = 80;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 3;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.Red;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 0.001F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        300F,
        0.001F,
        0F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 0F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 5F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(210, 180);
            this.aGauge1.TabIndex = 4;
            this.aGauge1.Value = 0F;
            // 
            // btn_kVSet
            // 
            this.btn_kVSet.Location = new System.Drawing.Point(67, 307);
            this.btn_kVSet.Name = "btn_kVSet";
            this.btn_kVSet.Size = new System.Drawing.Size(83, 34);
            this.btn_kVSet.TabIndex = 6;
            this.btn_kVSet.Text = "电压设定";
            this.btn_kVSet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(161, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "kV";
            // 
            // label_kV
            // 
            this.label_kV.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_kV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_kV.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kV.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_kV.Location = new System.Drawing.Point(16, 37);
            this.label_kV.Name = "label_kV";
            this.label_kV.Size = new System.Drawing.Size(139, 50);
            this.label_kV.TabIndex = 3;
            this.label_kV.Text = "12.45";
            this.label_kV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_mA
            // 
            this.groupBox_mA.Controls.Add(this.txt_mASet);
            this.groupBox_mA.Controls.Add(this.btn_mASet);
            this.groupBox_mA.Controls.Add(this.aGauge2);
            this.groupBox_mA.Controls.Add(this.label3);
            this.groupBox_mA.Controls.Add(this.label_mA);
            this.groupBox_mA.Location = new System.Drawing.Point(248, 45);
            this.groupBox_mA.Name = "groupBox_mA";
            this.groupBox_mA.Size = new System.Drawing.Size(223, 352);
            this.groupBox_mA.TabIndex = 3;
            this.groupBox_mA.TabStop = false;
            this.groupBox_mA.Text = "管电流";
            // 
            // txt_mASet
            // 
            this.txt_mASet.Location = new System.Drawing.Point(70, 276);
            this.txt_mASet.Name = "txt_mASet";
            this.txt_mASet.Size = new System.Drawing.Size(83, 25);
            this.txt_mASet.TabIndex = 5;
            this.txt_mASet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_mASet
            // 
            this.btn_mASet.BackColor = System.Drawing.Color.Transparent;
            this.btn_mASet.Location = new System.Drawing.Point(70, 307);
            this.btn_mASet.Name = "btn_mASet";
            this.btn_mASet.Size = new System.Drawing.Size(83, 34);
            this.btn_mASet.TabIndex = 6;
            this.btn_mASet.Text = "电流设定";
            this.btn_mASet.UseVisualStyleBackColor = false;
            // 
            // aGauge2
            // 
            this.aGauge2.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge2.BaseArcRadius = 80;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.Cap_Idx = ((byte)(0));
            this.aGauge2.CapColor = System.Drawing.SystemColors.Highlight;
            this.aGauge2.CapFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aGauge2.CapPosition = new System.Drawing.Point(93, 120);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(93, 120),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "mA",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "mA";
            this.aGauge2.Center = new System.Drawing.Point(105, 100);
            this.aGauge2.Location = new System.Drawing.Point(6, 103);
            this.aGauge2.MaxValue = 1F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.NeedleColor1 = MyControls.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.DimGray;
            this.aGauge2.NeedleRadius = 80;
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 3;
            this.aGauge2.Range_Idx = ((byte)(1));
            this.aGauge2.RangeColor = System.Drawing.SystemColors.Highlight;
            this.aGauge2.RangeEnabled = true;
            this.aGauge2.RangeEndValue = 0.001F;
            this.aGauge2.RangeInnerRadius = 70;
            this.aGauge2.RangeOuterRadius = 80;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.SystemColors.Highlight,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        300F,
        0.001F,
        0F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 0F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesInterInnerRadius = 73;
            this.aGauge2.ScaleLinesInterOuterRadius = 80;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleLinesMajorInnerRadius = 70;
            this.aGauge2.ScaleLinesMajorOuterRadius = 80;
            this.aGauge2.ScaleLinesMajorStepValue = 0.1F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.aGauge2.ScaleLinesMinorInnerRadius = 75;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 80;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 95;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 0;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Size = new System.Drawing.Size(210, 180);
            this.aGauge2.TabIndex = 4;
            this.aGauge2.Value = 0F;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(161, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "mA";
            // 
            // label_mA
            // 
            this.label_mA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_mA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_mA.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mA.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_mA.Location = new System.Drawing.Point(16, 37);
            this.label_mA.Name = "label_mA";
            this.label_mA.Size = new System.Drawing.Size(139, 50);
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
            this.groupBox_FilPreHeat.Location = new System.Drawing.Point(19, 403);
            this.groupBox_FilPreHeat.Name = "groupBox_FilPreHeat";
            this.groupBox_FilPreHeat.Size = new System.Drawing.Size(410, 98);
            this.groupBox_FilPreHeat.TabIndex = 4;
            this.groupBox_FilPreHeat.TabStop = false;
            this.groupBox_FilPreHeat.Text = "灯丝预热";
            // 
            // txt_FilPreHeat
            // 
            this.txt_FilPreHeat.Location = new System.Drawing.Point(206, 32);
            this.txt_FilPreHeat.Name = "txt_FilPreHeat";
            this.txt_FilPreHeat.Size = new System.Drawing.Size(51, 25);
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
            this.label_Filment.Location = new System.Drawing.Point(14, 30);
            this.label_Filment.Name = "label_Filment";
            this.label_Filment.Size = new System.Drawing.Size(103, 45);
            this.label_Filment.TabIndex = 3;
            this.label_Filment.Text = "12.45";
            this.label_Filment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FilPreHeatSet
            // 
            this.btn_FilPreHeatSet.Location = new System.Drawing.Point(289, 28);
            this.btn_FilPreHeatSet.Name = "btn_FilPreHeatSet";
            this.btn_FilPreHeatSet.Size = new System.Drawing.Size(106, 34);
            this.btn_FilPreHeatSet.TabIndex = 6;
            this.btn_FilPreHeatSet.Text = "灯丝预热设定";
            this.btn_FilPreHeatSet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(123, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(206, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "标准最大设定2A，建议设定1A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(263, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_FilLimitHiden);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_FilLimit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.trackBar_FilLimitSet);
            this.groupBox1.Controls.Add(this.btn_FilLimitSet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(19, 507);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "灯丝限幅";
            // 
            // label_FilLimitHiden
            // 
            this.label_FilLimitHiden.AutoSize = true;
            this.label_FilLimitHiden.Location = new System.Drawing.Point(79, 11);
            this.label_FilLimitHiden.Name = "label_FilLimitHiden";
            this.label_FilLimitHiden.Size = new System.Drawing.Size(39, 15);
            this.label_FilLimitHiden.TabIndex = 11;
            this.label_FilLimitHiden.Text = "3.1A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "4A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(79, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 15);
            this.label23.TabIndex = 9;
            this.label23.Text = "2A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "0A";
            // 
            // txt_FilLimit
            // 
            this.txt_FilLimit.Location = new System.Drawing.Point(206, 28);
            this.txt_FilLimit.Name = "txt_FilLimit";
            this.txt_FilLimit.Size = new System.Drawing.Size(51, 25);
            this.txt_FilLimit.TabIndex = 5;
            this.txt_FilLimit.Text = "2.5";
            this.txt_FilLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(178, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 14);
            this.label11.TabIndex = 4;
            this.label11.Text = "标准最大设定3.5A，建议设定2.5A";
            // 
            // trackBar_FilLimitSet
            // 
            this.trackBar_FilLimitSet.Location = new System.Drawing.Point(6, 29);
            this.trackBar_FilLimitSet.Maximum = 40;
            this.trackBar_FilLimitSet.Name = "trackBar_FilLimitSet";
            this.trackBar_FilLimitSet.Size = new System.Drawing.Size(161, 56);
            this.trackBar_FilLimitSet.TabIndex = 7;
            this.trackBar_FilLimitSet.TickFrequency = 10;
            // 
            // btn_FilLimitSet
            // 
            this.btn_FilLimitSet.Location = new System.Drawing.Point(289, 24);
            this.btn_FilLimitSet.Name = "btn_FilLimitSet";
            this.btn_FilLimitSet.Size = new System.Drawing.Size(106, 34);
            this.btn_FilLimitSet.TabIndex = 6;
            this.btn_FilLimitSet.Text = "灯丝限幅设定";
            this.btn_FilLimitSet.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(264, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "A";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(435, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 196);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统状态";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "互锁开关:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "运行状态:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "工作温度:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "电源电压:";
            // 
            // label_InterLockError
            // 
            this.label_InterLockError.BackColor = System.Drawing.Color.Red;
            this.label_InterLockError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_InterLockError.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InterLockError.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_InterLockError.Location = new System.Drawing.Point(136, 144);
            this.label_InterLockError.Name = "label_InterLockError";
            this.label_InterLockError.Size = new System.Drawing.Size(26, 26);
            this.label_InterLockError.TabIndex = 3;
            this.label_InterLockError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_InterLockOK
            // 
            this.label_InterLockOK.BackColor = System.Drawing.Color.Chartreuse;
            this.label_InterLockOK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_InterLockOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InterLockOK.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_InterLockOK.Location = new System.Drawing.Point(87, 144);
            this.label_InterLockOK.Name = "label_InterLockOK";
            this.label_InterLockOK.Size = new System.Drawing.Size(26, 26);
            this.label_InterLockOK.TabIndex = 3;
            this.label_InterLockOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StateError
            // 
            this.label_StateError.BackColor = System.Drawing.Color.Red;
            this.label_StateError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_StateError.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StateError.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_StateError.Location = new System.Drawing.Point(136, 115);
            this.label_StateError.Name = "label_StateError";
            this.label_StateError.Size = new System.Drawing.Size(26, 26);
            this.label_StateError.TabIndex = 3;
            this.label_StateError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StateOK
            // 
            this.label_StateOK.BackColor = System.Drawing.Color.Chartreuse;
            this.label_StateOK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_StateOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StateOK.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_StateOK.Location = new System.Drawing.Point(87, 115);
            this.label_StateOK.Name = "label_StateOK";
            this.label_StateOK.Size = new System.Drawing.Size(26, 26);
            this.label_StateOK.TabIndex = 3;
            this.label_StateOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Temp
            // 
            this.label_Temp.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label_Temp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Temp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Temp.ForeColor = System.Drawing.Color.GreenYellow;
            this.label_Temp.Location = new System.Drawing.Point(81, 58);
            this.label_Temp.Name = "label_Temp";
            this.label_Temp.Size = new System.Drawing.Size(83, 29);
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
            this.label_Power.Location = new System.Drawing.Point(81, 29);
            this.label_Power.Name = "label_Power";
            this.label_Power.Size = new System.Drawing.Size(83, 29);
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
            this.groupBox3.Location = new System.Drawing.Point(477, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 352);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制操作";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 0;
            this.button7.Text = "载入设置";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 0;
            this.button6.Text = "保存设置";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn_OpenHV
            // 
            this.btn_OpenHV.Location = new System.Drawing.Point(49, 52);
            this.btn_OpenHV.Name = "btn_OpenHV";
            this.btn_OpenHV.Size = new System.Drawing.Size(66, 40);
            this.btn_OpenHV.TabIndex = 0;
            this.btn_OpenHV.Text = "高压开";
            this.btn_OpenHV.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 0;
            this.button5.Text = "复位软件";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_CloseHV
            // 
            this.btn_CloseHV.Location = new System.Drawing.Point(47, 131);
            this.btn_CloseHV.Name = "btn_CloseHV";
            this.btn_CloseHV.Size = new System.Drawing.Size(68, 40);
            this.btn_CloseHV.TabIndex = 0;
            this.btn_CloseHV.Text = "高压关";
            this.btn_CloseHV.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 21);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_CloseHV,
            this.ovalShape_OpenHV});
            this.shapeContainer1.Size = new System.Drawing.Size(125, 328);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape_CloseHV
            // 
            this.ovalShape_CloseHV.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_CloseHV.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape_CloseHV.FillColor = System.Drawing.Color.Lime;
            this.ovalShape_CloseHV.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_CloseHV.Location = new System.Drawing.Point(8, 116);
            this.ovalShape_CloseHV.Name = "ovalShape_CloseHV";
            this.ovalShape_CloseHV.Size = new System.Drawing.Size(25, 25);
            // 
            // ovalShape_OpenHV
            // 
            this.ovalShape_OpenHV.FillColor = System.Drawing.Color.Red;
            this.ovalShape_OpenHV.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_OpenHV.Location = new System.Drawing.Point(8, 40);
            this.ovalShape_OpenHV.Name = "ovalShape_OpenHV";
            this.ovalShape_OpenHV.Size = new System.Drawing.Size(25, 25);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(633, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_FilPreHeat);
            this.Controls.Add(this.groupBox_mA);
            this.Controls.Add(this.groupBox_kV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "[大连泰思曼科技有限公司]TXR1012上位机";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem 端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOM口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 以太网设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出QToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private MyControls.AGauge aGauge1;
        private MyControls.AGauge aGauge2;
        private System.Windows.Forms.GroupBox groupBox_FilPreHeat;
        private System.Windows.Forms.TextBox txt_FilPreHeat;
        private System.Windows.Forms.Label label_Filment;
        private System.Windows.Forms.Button btn_FilPreHeatSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_FilLimit;
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
        private System.IO.Ports.SerialPort serialPort1;
    }
}

