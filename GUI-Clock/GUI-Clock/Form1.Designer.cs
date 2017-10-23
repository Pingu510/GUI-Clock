namespace GUI_Clock
{
    partial class Form1
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
            this.Clock_Form = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Sethour = new System.Windows.Forms.Label();
            this.Setminutes = new System.Windows.Forms.Label();
            this.clockbox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Alarm1_Minute_Textbox = new System.Windows.Forms.TextBox();
            this.Alarm1_Hour_Textbox = new System.Windows.Forms.TextBox();
            this.Tab1_Set_Alarm1_Buttom = new System.Windows.Forms.Button();
            this.Alarm_Clock1_Time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlarmTabBox = new System.Windows.Forms.TabControl();
            this.AlarmTabPage1 = new System.Windows.Forms.TabPage();
            this.AlarmTabPage2 = new System.Windows.Forms.TabPage();
            this.AlarmBox2 = new System.Windows.Forms.GroupBox();
            this.Alarm2_Minute_Textbox = new System.Windows.Forms.TextBox();
            this.Alarm2_Hour_Textbox = new System.Windows.Forms.TextBox();
            this.Tab2_Set_Alarm2_Buttom = new System.Windows.Forms.Button();
            this.Alarm_Clock2_Time = new System.Windows.Forms.Label();
            this.SetMinuteTab2 = new System.Windows.Forms.Label();
            this.SetHoursTabPage2 = new System.Windows.Forms.Label();
            this.ClockBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.clockbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AlarmTabBox.SuspendLayout();
            this.AlarmTabPage1.SuspendLayout();
            this.AlarmTabPage2.SuspendLayout();
            this.AlarmBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clock_Form
            // 
            this.Clock_Form.AutoSize = true;
            this.Clock_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_Form.Location = new System.Drawing.Point(86, 74);
            this.Clock_Form.Name = "Clock_Form";
            this.Clock_Form.Size = new System.Drawing.Size(145, 55);
            this.Clock_Form.TabIndex = 0;
            this.Clock_Form.Text = "00:00";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(116, 132);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Sethour
            // 
            this.Sethour.AutoSize = true;
            this.Sethour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sethour.Location = new System.Drawing.Point(25, 30);
            this.Sethour.Name = "Sethour";
            this.Sethour.Size = new System.Drawing.Size(63, 16);
            this.Sethour.TabIndex = 2;
            this.Sethour.Text = "Set hour: ";
            // 
            // Setminutes
            // 
            this.Setminutes.AutoSize = true;
            this.Setminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setminutes.Location = new System.Drawing.Point(25, 58);
            this.Setminutes.Name = "Setminutes";
            this.Setminutes.Size = new System.Drawing.Size(80, 16);
            this.Setminutes.TabIndex = 3;
            this.Setminutes.Text = "Set minutes:";
            // 
            // clockbox
            // 
            this.clockbox.Controls.Add(this.textBox2);
            this.clockbox.Controls.Add(this.textBox1);
            this.clockbox.Controls.Add(this.Clock_Form);
            this.clockbox.Controls.Add(this.Start_Button);
            this.clockbox.Controls.Add(this.Sethour);
            this.clockbox.Controls.Add(this.Setminutes);
            this.clockbox.Location = new System.Drawing.Point(15, 25);
            this.clockbox.Name = "clockbox";
            this.clockbox.Size = new System.Drawing.Size(322, 173);
            this.clockbox.TabIndex = 4;
            this.clockbox.TabStop = false;
            this.clockbox.Text = "Clock";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Alarm1_Minute_Textbox);
            this.groupBox2.Controls.Add(this.Alarm1_Hour_Textbox);
            this.groupBox2.Controls.Add(this.Tab1_Set_Alarm1_Buttom);
            this.groupBox2.Controls.Add(this.Alarm_Clock1_Time);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Alarm1_Minute_Textbox
            // 
            this.Alarm1_Minute_Textbox.Location = new System.Drawing.Point(128, 65);
            this.Alarm1_Minute_Textbox.Name = "Alarm1_Minute_Textbox";
            this.Alarm1_Minute_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Alarm1_Minute_Textbox.TabIndex = 5;
            // 
            // Alarm1_Hour_Textbox
            // 
            this.Alarm1_Hour_Textbox.Location = new System.Drawing.Point(128, 31);
            this.Alarm1_Hour_Textbox.Name = "Alarm1_Hour_Textbox";
            this.Alarm1_Hour_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Alarm1_Hour_Textbox.TabIndex = 4;
            // 
            // Tab1_Set_Alarm1_Buttom
            // 
            this.Tab1_Set_Alarm1_Buttom.Location = new System.Drawing.Point(75, 171);
            this.Tab1_Set_Alarm1_Buttom.Name = "Tab1_Set_Alarm1_Buttom";
            this.Tab1_Set_Alarm1_Buttom.Size = new System.Drawing.Size(75, 23);
            this.Tab1_Set_Alarm1_Buttom.TabIndex = 3;
            this.Tab1_Set_Alarm1_Buttom.Text = "Set";
            this.Tab1_Set_Alarm1_Buttom.UseVisualStyleBackColor = true;
            this.Tab1_Set_Alarm1_Buttom.Click += new System.EventHandler(this.SetAlarm_Button_Click);
            // 
            // Alarm_Clock1_Time
            // 
            this.Alarm_Clock1_Time.AutoSize = true;
            this.Alarm_Clock1_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm_Clock1_Time.Location = new System.Drawing.Point(45, 100);
            this.Alarm_Clock1_Time.Name = "Alarm_Clock1_Time";
            this.Alarm_Clock1_Time.Size = new System.Drawing.Size(145, 55);
            this.Alarm_Clock1_Time.TabIndex = 2;
            this.Alarm_Clock1_Time.Text = "00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Set minutes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Set hour";
            // 
            // AlarmTabBox
            // 
            this.AlarmTabBox.AccessibleDescription = "l";
            this.AlarmTabBox.AccessibleName = "";
            this.AlarmTabBox.Controls.Add(this.AlarmTabPage1);
            this.AlarmTabBox.Controls.Add(this.AlarmTabPage2);
            this.AlarmTabBox.Location = new System.Drawing.Point(12, 204);
            this.AlarmTabBox.Name = "AlarmTabBox";
            this.AlarmTabBox.SelectedIndex = 0;
            this.AlarmTabBox.Size = new System.Drawing.Size(330, 307);
            this.AlarmTabBox.TabIndex = 5;
            // 
            // AlarmTabPage1
            // 
            this.AlarmTabPage1.Controls.Add(this.groupBox2);
            this.AlarmTabPage1.Location = new System.Drawing.Point(4, 22);
            this.AlarmTabPage1.Name = "AlarmTabPage1";
            this.AlarmTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.AlarmTabPage1.Size = new System.Drawing.Size(322, 281);
            this.AlarmTabPage1.TabIndex = 0;
            this.AlarmTabPage1.Text = "Alarm 1";
            this.AlarmTabPage1.UseVisualStyleBackColor = true;
            // 
            // AlarmTabPage2
            // 
            this.AlarmTabPage2.Controls.Add(this.AlarmBox2);
            this.AlarmTabPage2.Location = new System.Drawing.Point(4, 22);
            this.AlarmTabPage2.Name = "AlarmTabPage2";
            this.AlarmTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.AlarmTabPage2.Size = new System.Drawing.Size(322, 281);
            this.AlarmTabPage2.TabIndex = 1;
            this.AlarmTabPage2.Text = "Alarm 2";
            this.AlarmTabPage2.UseVisualStyleBackColor = true;
            this.AlarmTabPage2.Click += new System.EventHandler(this.AlarmTabPage2_Click);
            // 
            // AlarmBox2
            // 
            this.AlarmBox2.Controls.Add(this.Alarm2_Minute_Textbox);
            this.AlarmBox2.Controls.Add(this.Alarm2_Hour_Textbox);
            this.AlarmBox2.Controls.Add(this.Tab2_Set_Alarm2_Buttom);
            this.AlarmBox2.Controls.Add(this.Alarm_Clock2_Time);
            this.AlarmBox2.Controls.Add(this.SetMinuteTab2);
            this.AlarmBox2.Controls.Add(this.SetHoursTabPage2);
            this.AlarmBox2.Location = new System.Drawing.Point(18, 29);
            this.AlarmBox2.Name = "AlarmBox2";
            this.AlarmBox2.Size = new System.Drawing.Size(284, 220);
            this.AlarmBox2.TabIndex = 1;
            this.AlarmBox2.TabStop = false;
            // 
            // Alarm2_Minute_Textbox
            // 
            this.Alarm2_Minute_Textbox.Location = new System.Drawing.Point(124, 58);
            this.Alarm2_Minute_Textbox.Name = "Alarm2_Minute_Textbox";
            this.Alarm2_Minute_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Alarm2_Minute_Textbox.TabIndex = 9;
            // 
            // Alarm2_Hour_Textbox
            // 
            this.Alarm2_Hour_Textbox.Location = new System.Drawing.Point(124, 37);
            this.Alarm2_Hour_Textbox.Name = "Alarm2_Hour_Textbox";
            this.Alarm2_Hour_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Alarm2_Hour_Textbox.TabIndex = 8;
            // 
            // Tab2_Set_Alarm2_Buttom
            // 
            this.Tab2_Set_Alarm2_Buttom.Location = new System.Drawing.Point(74, 155);
            this.Tab2_Set_Alarm2_Buttom.Name = "Tab2_Set_Alarm2_Buttom";
            this.Tab2_Set_Alarm2_Buttom.Size = new System.Drawing.Size(75, 23);
            this.Tab2_Set_Alarm2_Buttom.TabIndex = 7;
            this.Tab2_Set_Alarm2_Buttom.Text = "Set";
            this.Tab2_Set_Alarm2_Buttom.UseVisualStyleBackColor = true;
            // 
            // Alarm_Clock2_Time
            // 
            this.Alarm_Clock2_Time.AutoSize = true;
            this.Alarm_Clock2_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm_Clock2_Time.Location = new System.Drawing.Point(45, 97);
            this.Alarm_Clock2_Time.Name = "Alarm_Clock2_Time";
            this.Alarm_Clock2_Time.Size = new System.Drawing.Size(145, 55);
            this.Alarm_Clock2_Time.TabIndex = 6;
            this.Alarm_Clock2_Time.Text = "00:00";
            // 
            // SetMinuteTab2
            // 
            this.SetMinuteTab2.AutoSize = true;
            this.SetMinuteTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinuteTab2.Location = new System.Drawing.Point(31, 57);
            this.SetMinuteTab2.Name = "SetMinuteTab2";
            this.SetMinuteTab2.Size = new System.Drawing.Size(90, 18);
            this.SetMinuteTab2.TabIndex = 5;
            this.SetMinuteTab2.Text = "Set minutes:";
            // 
            // SetHoursTabPage2
            // 
            this.SetHoursTabPage2.AutoSize = true;
            this.SetHoursTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetHoursTabPage2.Location = new System.Drawing.Point(31, 39);
            this.SetHoursTabPage2.Name = "SetHoursTabPage2";
            this.SetHoursTabPage2.Size = new System.Drawing.Size(76, 18);
            this.SetHoursTabPage2.TabIndex = 4;
            this.SetHoursTabPage2.Text = "Set hours:";
            // 
            // ClockBackgroundWorker
            // 
            this.ClockBackgroundWorker.WorkerReportsProgress = true;
            this.ClockBackgroundWorker.WorkerSupportsCancellation = true;
            this.ClockBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ClockBackgroundWorker_DoWork);
            this.ClockBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ClockBackgroundWorker_RunWorkerCompleted);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 523);
            this.Controls.Add(this.AlarmTabBox);
            this.Controls.Add(this.clockbox);
            this.Name = "Form1";
            this.Text = "Klocka";
            this.clockbox.ResumeLayout(false);
            this.clockbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AlarmTabBox.ResumeLayout(false);
            this.AlarmTabPage1.ResumeLayout(false);
            this.AlarmTabPage2.ResumeLayout(false);
            this.AlarmBox2.ResumeLayout(false);
            this.AlarmBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Clock_Form;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Label Sethour;
        private System.Windows.Forms.Label Setminutes;
        private System.Windows.Forms.GroupBox clockbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Tab1_Set_Alarm1_Buttom;
        private System.Windows.Forms.Label Alarm_Clock1_Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl AlarmTabBox;
        private System.Windows.Forms.TabPage AlarmTabPage1;
        private System.Windows.Forms.TabPage AlarmTabPage2;
        private System.Windows.Forms.GroupBox AlarmBox2;
        private System.Windows.Forms.Button Tab2_Set_Alarm2_Buttom;
        private System.Windows.Forms.Label Alarm_Clock2_Time;
        private System.Windows.Forms.Label SetMinuteTab2;
        private System.Windows.Forms.Label SetHoursTabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Alarm1_Minute_Textbox;
        private System.Windows.Forms.TextBox Alarm1_Hour_Textbox;
        private System.Windows.Forms.TextBox Alarm2_Minute_Textbox;
        private System.Windows.Forms.TextBox Alarm2_Hour_Textbox;
        private System.ComponentModel.BackgroundWorker ClockBackgroundWorker;
        private System.Windows.Forms.Timer ClockTimer;
    }
}

