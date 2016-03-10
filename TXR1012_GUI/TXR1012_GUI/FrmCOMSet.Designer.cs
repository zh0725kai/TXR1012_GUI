namespace TXR1012_GUI
{
    partial class FrmCOMSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SlaveAddress = new System.Windows.Forms.TextBox();
            this.cbo_COMNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Parity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_StopBit = new System.Windows.Forms.ComboBox();
            this.btn_AdvanceSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(225, 207);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "从机地址:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SlaveAddress
            // 
            this.txt_SlaveAddress.Enabled = false;
            this.txt_SlaveAddress.Location = new System.Drawing.Point(112, 24);
            this.txt_SlaveAddress.Name = "txt_SlaveAddress";
            this.txt_SlaveAddress.Size = new System.Drawing.Size(77, 25);
            this.txt_SlaveAddress.TabIndex = 2;
            this.txt_SlaveAddress.Text = "1";
            // 
            // cbo_COMNum
            // 
            this.cbo_COMNum.FormattingEnabled = true;
            this.cbo_COMNum.Location = new System.Drawing.Point(112, 62);
            this.cbo_COMNum.Name = "cbo_COMNum";
            this.cbo_COMNum.Size = new System.Drawing.Size(77, 23);
            this.cbo_COMNum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "COM端口号:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_BaudRate
            // 
            this.cbo_BaudRate.FormattingEnabled = true;
            this.cbo_BaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.cbo_BaudRate.Location = new System.Drawing.Point(112, 98);
            this.cbo_BaudRate.Name = "cbo_BaudRate";
            this.cbo_BaudRate.Size = new System.Drawing.Size(77, 23);
            this.cbo_BaudRate.TabIndex = 3;
            this.cbo_BaudRate.Text = "9600";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "波特率:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_DataBits
            // 
            this.cbo_DataBits.Enabled = false;
            this.cbo_DataBits.FormattingEnabled = true;
            this.cbo_DataBits.Location = new System.Drawing.Point(112, 135);
            this.cbo_DataBits.Name = "cbo_DataBits";
            this.cbo_DataBits.Size = new System.Drawing.Size(77, 23);
            this.cbo_DataBits.TabIndex = 3;
            this.cbo_DataBits.Text = "8";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "数据位:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "校验位:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_Parity
            // 
            this.cbo_Parity.Enabled = false;
            this.cbo_Parity.FormattingEnabled = true;
            this.cbo_Parity.Location = new System.Drawing.Point(112, 172);
            this.cbo_Parity.Name = "cbo_Parity";
            this.cbo_Parity.Size = new System.Drawing.Size(77, 23);
            this.cbo_Parity.TabIndex = 3;
            this.cbo_Parity.Text = "None";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "停止位:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo_StopBit
            // 
            this.cbo_StopBit.Enabled = false;
            this.cbo_StopBit.FormattingEnabled = true;
            this.cbo_StopBit.Location = new System.Drawing.Point(112, 207);
            this.cbo_StopBit.Name = "cbo_StopBit";
            this.cbo_StopBit.Size = new System.Drawing.Size(77, 23);
            this.cbo_StopBit.TabIndex = 3;
            this.cbo_StopBit.Text = "1";
            // 
            // btn_AdvanceSet
            // 
            this.btn_AdvanceSet.Location = new System.Drawing.Point(225, 26);
            this.btn_AdvanceSet.Name = "btn_AdvanceSet";
            this.btn_AdvanceSet.Size = new System.Drawing.Size(75, 23);
            this.btn_AdvanceSet.TabIndex = 0;
            this.btn_AdvanceSet.Text = "高级设置";
            this.btn_AdvanceSet.UseVisualStyleBackColor = true;
            this.btn_AdvanceSet.Click += new System.EventHandler(this.btn_AdvanceSet_Click);
            // 
            // FrmCOMSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 246);
            this.Controls.Add(this.cbo_StopBit);
            this.Controls.Add(this.cbo_Parity);
            this.Controls.Add(this.cbo_BaudRate);
            this.Controls.Add(this.cbo_DataBits);
            this.Controls.Add(this.cbo_COMNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SlaveAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AdvanceSet);
            this.Controls.Add(this.btn_OK);
            this.Name = "FrmCOMSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[COM端口设置]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SlaveAddress;
        private System.Windows.Forms.ComboBox cbo_COMNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Parity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_StopBit;
        private System.Windows.Forms.Button btn_AdvanceSet;
    }
}