namespace TEMPer
{
    partial class Connect_USB_device
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
            this.components = new System.ComponentModel.Container();
            this.labelTextLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTextLeft
            // 
            this.labelTextLeft.AutoSize = true;
            this.labelTextLeft.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextLeft.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelTextLeft.Location = new System.Drawing.Point(12, 244);
            this.labelTextLeft.Name = "labelTextLeft";
            this.labelTextLeft.Size = new System.Drawing.Size(268, 23);
            this.labelTextLeft.TabIndex = 0;
            this.labelTextLeft.Text = "У Вас осталось/You have left:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Необходимо выбрать номер подключаемого устройства \r\nПодключить ОДНО USB устройств" +
    "о, нажать на кнопку \"Начать подключение устройства\" \r\nи дождаться конца таймера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "You must select the number of the connected device\r\nConnect ONE USB device, click" +
    " on the \"Start device connection\"\r\nand wait for the timer to end";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(306, 232);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(44, 49);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.Text = "5";
            this.labelTimer.Click += new System.EventHandler(this.labelTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(16, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("13");
            this.domainUpDown1.Items.Add("14");
            this.domainUpDown1.Items.Add("15");
            this.domainUpDown1.Items.Add("16");
            this.domainUpDown1.Items.Add("17");
            this.domainUpDown1.Items.Add("18");
            this.domainUpDown1.Items.Add("19");
            this.domainUpDown1.Items.Add("20");
            this.domainUpDown1.Items.Add("21");
            this.domainUpDown1.Items.Add("22");
            this.domainUpDown1.Items.Add("23");
            this.domainUpDown1.Items.Add("24");
            this.domainUpDown1.Items.Add("25");
            this.domainUpDown1.Items.Add("26");
            this.domainUpDown1.Items.Add("27");
            this.domainUpDown1.Items.Add("28");
            this.domainUpDown1.Items.Add("29");
            this.domainUpDown1.Items.Add("30");
            this.domainUpDown1.Items.Add("31");
            this.domainUpDown1.Items.Add("32");
            this.domainUpDown1.Items.Add("33");
            this.domainUpDown1.Items.Add("34");
            this.domainUpDown1.Items.Add("35");
            this.domainUpDown1.Items.Add("36");
            this.domainUpDown1.Items.Add("37");
            this.domainUpDown1.Items.Add("38");
            this.domainUpDown1.Items.Add("39");
            this.domainUpDown1.Items.Add("40");
            this.domainUpDown1.Location = new System.Drawing.Point(481, 280);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(336, 22);
            this.domainUpDown1.TabIndex = 5;
            this.domainUpDown1.Text = "Выберите номер подключенного устройства";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(568, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "Начать подключение устройства";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(19, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Версия программы TemPer 26.5\r\nРуссификатор и кастом by Fatalre\r\nfatalrew@gmail.co" +
    "m\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(289, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "TemPer Program Version 26.5\r\nCustom by Fatalre\r\nfatalrew@gmail.com";
            // 
            // Connect_USB_device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 327);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTextLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connect_USB_device";
            this.ShowIcon = false;
            this.Text = "Подключите USB устройство/Connect USB device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}