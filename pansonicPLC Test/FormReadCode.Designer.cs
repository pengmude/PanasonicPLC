namespace pansonicPLC_Test
{
    partial class FormReadCode
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_len = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_result = new System.Windows.Forms.TextBox();
            this.device_plc_status = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "读取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "读码地址";
            // 
            // txb_address
            // 
            this.txb_address.Location = new System.Drawing.Point(303, 99);
            this.txb_address.Name = "txb_address";
            this.txb_address.Size = new System.Drawing.Size(173, 28);
            this.txb_address.TabIndex = 2;
            this.txb_address.Text = "DT1234";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "读码长度（字）";
            // 
            // txb_len
            // 
            this.txb_len.Location = new System.Drawing.Point(303, 195);
            this.txb_len.Name = "txb_len";
            this.txb_len.Size = new System.Drawing.Size(173, 28);
            this.txb_len.TabIndex = 2;
            this.txb_len.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "读码结果";
            // 
            // txb_result
            // 
            this.txb_result.Location = new System.Drawing.Point(67, 329);
            this.txb_result.Name = "txb_result";
            this.txb_result.Size = new System.Drawing.Size(398, 28);
            this.txb_result.TabIndex = 2;
            // 
            // device_plc_status
            // 
            this.device_plc_status.AutoSize = true;
            this.device_plc_status.Location = new System.Drawing.Point(64, 34);
            this.device_plc_status.Name = "device_plc_status";
            this.device_plc_status.Size = new System.Drawing.Size(143, 18);
            this.device_plc_status.TabIndex = 3;
            this.device_plc_status.Text = "PLC串口连接状态";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comboBox1.Location = new System.Drawing.Point(242, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormReadCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.device_plc_status);
            this.Controls.Add(this.txb_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_len);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormReadCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "读码测试";
            this.Load += new System.EventHandler(this.FormReadCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_len;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_result;
        private System.Windows.Forms.Label device_plc_status;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}