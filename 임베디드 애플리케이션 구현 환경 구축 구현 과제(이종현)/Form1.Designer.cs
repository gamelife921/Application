﻿namespace _01BASIC
{
    partial class winform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BUT_OFF = new System.Windows.Forms.Button();
            this.BUT_ON = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TEMP_BOX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SUN_TXT = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DIS_TXT = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.PortNumber.Location = new System.Drawing.Point(30, 32);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(106, 20);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged);
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(155, 32);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 23);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(12, 29);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textArea.Size = new System.Drawing.Size(176, 124);
            this.textArea.TabIndex = 2;
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BUT_OFF);
            this.groupBox2.Controls.Add(this.BUT_ON);
            this.groupBox2.Location = new System.Drawing.Point(30, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED";
            // 
            // BUT_OFF
            // 
            this.BUT_OFF.Location = new System.Drawing.Point(105, 29);
            this.BUT_OFF.Name = "BUT_OFF";
            this.BUT_OFF.Size = new System.Drawing.Size(75, 52);
            this.BUT_OFF.TabIndex = 1;
            this.BUT_OFF.Text = "Off";
            this.BUT_OFF.UseVisualStyleBackColor = true;
            this.BUT_OFF.Click += new System.EventHandler(this.button2_Click);
            // 
            // BUT_ON
            // 
            this.BUT_ON.Location = new System.Drawing.Point(9, 29);
            this.BUT_ON.Name = "BUT_ON";
            this.BUT_ON.Size = new System.Drawing.Size(75, 52);
            this.BUT_ON.TabIndex = 0;
            this.BUT_ON.Text = "On";
            this.BUT_ON.UseVisualStyleBackColor = true;
            this.BUT_ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textArea);
            this.groupBox3.Location = new System.Drawing.Point(252, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 174);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "모니 터링";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TEMP_BOX);
            this.groupBox4.Location = new System.Drawing.Point(30, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 51);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도 센서";
            // 
            // TEMP_BOX
            // 
            this.TEMP_BOX.Enabled = false;
            this.TEMP_BOX.Location = new System.Drawing.Point(9, 21);
            this.TEMP_BOX.Name = "TEMP_BOX";
            this.TEMP_BOX.ReadOnly = true;
            this.TEMP_BOX.Size = new System.Drawing.Size(171, 21);
            this.TEMP_BOX.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SUN_TXT);
            this.groupBox5.Location = new System.Drawing.Point(30, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 55);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도 센서";
            // 
            // SUN_TXT
            // 
            this.SUN_TXT.Enabled = false;
            this.SUN_TXT.Location = new System.Drawing.Point(9, 21);
            this.SUN_TXT.Name = "SUN_TXT";
            this.SUN_TXT.ReadOnly = true;
            this.SUN_TXT.Size = new System.Drawing.Size(171, 21);
            this.SUN_TXT.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DIS_TXT);
            this.groupBox6.Location = new System.Drawing.Point(252, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 55);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파 센서";
            // 
            // DIS_TXT
            // 
            this.DIS_TXT.Location = new System.Drawing.Point(12, 20);
            this.DIS_TXT.Multiline = true;
            this.DIS_TXT.Name = "DIS_TXT";
            this.DIS_TXT.ReadOnly = true;
            this.DIS_TXT.Size = new System.Drawing.Size(176, 21);
            this.DIS_TXT.TabIndex = 0;
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 361);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "winform";
            this.Text = "WINFORMTEST";
            this.Load += new System.EventHandler(this.winform_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BUT_OFF;
        private System.Windows.Forms.Button BUT_ON;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TEMP_BOX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SUN_TXT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DIS_TXT;
    }
}