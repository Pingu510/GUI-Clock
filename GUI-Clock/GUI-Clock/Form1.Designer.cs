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
            this.ClockTime_Form = new System.Windows.Forms.Label();
            this.ClockStart_Button = new System.Windows.Forms.Button();
            this.ClockHourSet = new System.Windows.Forms.Label();
            this.ClockMinuteSet = new System.Windows.Forms.Label();
            this.Clock_GroupBox = new System.Windows.Forms.GroupBox();
            this.ClockMinuteInput_TextBox = new System.Windows.Forms.TextBox();
            this.ClockHourInput_TextBox = new System.Windows.Forms.TextBox();
            this.Alarm1_GroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm1MinuteInput_TextBox = new System.Windows.Forms.TextBox();
            this.Alarm1HourInput_TextBox = new System.Windows.Forms.TextBox();
            this.Alarm1Set_Button = new System.Windows.Forms.Button();
            this.Alarm1_Clock = new System.Windows.Forms.Label();
            this.SetAlarmMinute1 = new System.Windows.Forms.Label();
            this.SetAlarmHour1 = new System.Windows.Forms.Label();
            this.AlarmTabBox = new System.Windows.Forms.TabControl();
            this.AlarmTabPage1 = new System.Windows.Forms.TabPage();
            this.AlarmTabPage2 = new System.Windows.Forms.TabPage();
            this.Alarm2_GroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm2MinuteInput_TextBox = new System.Windows.Forms.TextBox();
            this.Alarm2HourInput_TextBox = new System.Windows.Forms.TextBox();
            this.Alarm2Set_Button = new System.Windows.Forms.Button();
            this.Alarm2_Clock = new System.Windows.Forms.Label();
            this.SetAlarm2Minute = new System.Windows.Forms.Label();
            this.SetAlarm2Hour = new System.Windows.Forms.Label();
            this.Clock_GroupBox.SuspendLayout();
            this.Alarm1_GroupBox.SuspendLayout();
            this.AlarmTabBox.SuspendLayout();
            this.AlarmTabPage1.SuspendLayout();
            this.AlarmTabPage2.SuspendLayout();
            this.Alarm2_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockTime_Form
            // 
            this.ClockTime_Form.AutoSize = true;
            this.ClockTime_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockTime_Form.Location = new System.Drawing.Point(86, 74);
            this.ClockTime_Form.Name = "ClockTime_Form";
            this.ClockTime_Form.Size = new System.Drawing.Size(145, 55);
            this.ClockTime_Form.TabIndex = 0;
            this.ClockTime_Form.Text = "00:00";
            // 
            // ClockStart_Button
            // 
            this.ClockStart_Button.Location = new System.Drawing.Point(116, 132);
            this.ClockStart_Button.Name = "ClockStart_Button";
            this.ClockStart_Button.Size = new System.Drawing.Size(75, 23);
            this.ClockStart_Button.TabIndex = 1;
            this.ClockStart_Button.Text = "Start";
            this.ClockStart_Button.UseVisualStyleBackColor = true;
            this.ClockStart_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // ClockHourSet
            // 
            this.ClockHourSet.AutoSize = true;
            this.ClockHourSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockHourSet.Location = new System.Drawing.Point(25, 30);
            this.ClockHourSet.Name = "ClockHourSet";
            this.ClockHourSet.Size = new System.Drawing.Size(63, 16);
            this.ClockHourSet.TabIndex = 2;
            this.ClockHourSet.Text = "Set hour: ";
            // 
            // ClockMinuteSet
            // 
            this.ClockMinuteSet.AutoSize = true;
            this.ClockMinuteSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockMinuteSet.Location = new System.Drawing.Point(25, 58);
            this.ClockMinuteSet.Name = "ClockMinuteSet";
            this.ClockMinuteSet.Size = new System.Drawing.Size(80, 16);
            this.ClockMinuteSet.TabIndex = 3;
            this.ClockMinuteSet.Text = "Set minutes:";
            // 
            // Clock_GroupBox
            // 
            this.Clock_GroupBox.Controls.Add(this.ClockMinuteInput_TextBox);
            this.Clock_GroupBox.Controls.Add(this.ClockHourInput_TextBox);
            this.Clock_GroupBox.Controls.Add(this.ClockTime_Form);
            this.Clock_GroupBox.Controls.Add(this.ClockStart_Button);
            this.Clock_GroupBox.Controls.Add(this.ClockHourSet);
            this.Clock_GroupBox.Controls.Add(this.ClockMinuteSet);
            this.Clock_GroupBox.Location = new System.Drawing.Point(15, 25);
            this.Clock_GroupBox.Name = "Clock_GroupBox";
            this.Clock_GroupBox.Size = new System.Drawing.Size(322, 173);
            this.Clock_GroupBox.TabIndex = 4;
            this.Clock_GroupBox.TabStop = false;
            this.Clock_GroupBox.Text = "Clock";
            // 
            // ClockMinuteInput_TextBox
            // 
            this.ClockMinuteInput_TextBox.Location = new System.Drawing.Point(108, 54);
            this.ClockMinuteInput_TextBox.Name = "ClockMinuteInput_TextBox";
            this.ClockMinuteInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ClockMinuteInput_TextBox.TabIndex = 5;
            this.ClockMinuteInput_TextBox.TextChanged += new System.EventHandler(this.ClockMinuteInput_TextBox_TextChanged);
            // 
            // ClockHourInput_TextBox
            // 
            this.ClockHourInput_TextBox.Location = new System.Drawing.Point(108, 30);
            this.ClockHourInput_TextBox.Name = "ClockHourInput_TextBox";
            this.ClockHourInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ClockHourInput_TextBox.TabIndex = 4;
            this.ClockHourInput_TextBox.TextChanged += new System.EventHandler(this.ClockHourInput_TextBox_TextChanged);
            // 
            // Alarm1_GroupBox
            // 
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1MinuteInput_TextBox);
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1HourInput_TextBox);
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1Set_Button);
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1_Clock);
            this.Alarm1_GroupBox.Controls.Add(this.SetAlarmMinute1);
            this.Alarm1_GroupBox.Controls.Add(this.SetAlarmHour1);
            this.Alarm1_GroupBox.Location = new System.Drawing.Point(17, 22);
            this.Alarm1_GroupBox.Name = "Alarm1_GroupBox";
            this.Alarm1_GroupBox.Size = new System.Drawing.Size(281, 217);
            this.Alarm1_GroupBox.TabIndex = 0;
            this.Alarm1_GroupBox.TabStop = false;
            // 
            // Alarm1MinuteInput_TextBox
            // 
            this.Alarm1MinuteInput_TextBox.Location = new System.Drawing.Point(128, 65);
            this.Alarm1MinuteInput_TextBox.Name = "Alarm1MinuteInput_TextBox";
            this.Alarm1MinuteInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Alarm1MinuteInput_TextBox.TabIndex = 5;
            // 
            // Alarm1HourInput_TextBox
            // 
            this.Alarm1HourInput_TextBox.Location = new System.Drawing.Point(128, 31);
            this.Alarm1HourInput_TextBox.Name = "Alarm1HourInput_TextBox";
            this.Alarm1HourInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Alarm1HourInput_TextBox.TabIndex = 4;
            // 
            // Alarm1Set_Button
            // 
            this.Alarm1Set_Button.Location = new System.Drawing.Point(75, 171);
            this.Alarm1Set_Button.Name = "Alarm1Set_Button";
            this.Alarm1Set_Button.Size = new System.Drawing.Size(75, 23);
            this.Alarm1Set_Button.TabIndex = 3;
            this.Alarm1Set_Button.Text = "Set";
            this.Alarm1Set_Button.UseVisualStyleBackColor = true;
            // 
            // Alarm1_Clock
            // 
            this.Alarm1_Clock.AutoSize = true;
            this.Alarm1_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm1_Clock.Location = new System.Drawing.Point(45, 100);
            this.Alarm1_Clock.Name = "Alarm1_Clock";
            this.Alarm1_Clock.Size = new System.Drawing.Size(145, 55);
            this.Alarm1_Clock.TabIndex = 2;
            this.Alarm1_Clock.Text = "00:00";
            // 
            // SetAlarmMinute1
            // 
            this.SetAlarmMinute1.AutoSize = true;
            this.SetAlarmMinute1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarmMinute1.Location = new System.Drawing.Point(28, 65);
            this.SetAlarmMinute1.Name = "SetAlarmMinute1";
            this.SetAlarmMinute1.Size = new System.Drawing.Size(75, 15);
            this.SetAlarmMinute1.TabIndex = 1;
            this.SetAlarmMinute1.Text = "Set minutes:";
            // 
            // SetAlarmHour1
            // 
            this.SetAlarmHour1.AutoSize = true;
            this.SetAlarmHour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarmHour1.Location = new System.Drawing.Point(28, 36);
            this.SetAlarmHour1.Name = "SetAlarmHour1";
            this.SetAlarmHour1.Size = new System.Drawing.Size(53, 15);
            this.SetAlarmHour1.TabIndex = 0;
            this.SetAlarmHour1.Text = "Set hour";
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
            this.AlarmTabPage1.Controls.Add(this.Alarm1_GroupBox);
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
            this.AlarmTabPage2.Controls.Add(this.Alarm2_GroupBox);
            this.AlarmTabPage2.Location = new System.Drawing.Point(4, 22);
            this.AlarmTabPage2.Name = "AlarmTabPage2";
            this.AlarmTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.AlarmTabPage2.Size = new System.Drawing.Size(322, 281);
            this.AlarmTabPage2.TabIndex = 1;
            this.AlarmTabPage2.Text = "Alarm 2";
            this.AlarmTabPage2.UseVisualStyleBackColor = true;
            // 
            // Alarm2_GroupBox
            // 
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2MinuteInput_TextBox);
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2HourInput_TextBox);
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2Set_Button);
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2_Clock);
            this.Alarm2_GroupBox.Controls.Add(this.SetAlarm2Minute);
            this.Alarm2_GroupBox.Controls.Add(this.SetAlarm2Hour);
            this.Alarm2_GroupBox.Location = new System.Drawing.Point(21, 32);
            this.Alarm2_GroupBox.Name = "Alarm2_GroupBox";
            this.Alarm2_GroupBox.Size = new System.Drawing.Size(281, 217);
            this.Alarm2_GroupBox.TabIndex = 1;
            this.Alarm2_GroupBox.TabStop = false;
            // 
            // Alarm2MinuteInput_TextBox
            // 
            this.Alarm2MinuteInput_TextBox.Location = new System.Drawing.Point(124, 58);
            this.Alarm2MinuteInput_TextBox.Name = "Alarm2MinuteInput_TextBox";
            this.Alarm2MinuteInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Alarm2MinuteInput_TextBox.TabIndex = 9;
            // 
            // Alarm2HourInput_TextBox
            // 
            this.Alarm2HourInput_TextBox.Location = new System.Drawing.Point(124, 37);
            this.Alarm2HourInput_TextBox.Name = "Alarm2HourInput_TextBox";
            this.Alarm2HourInput_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Alarm2HourInput_TextBox.TabIndex = 8;
            // 
            // Alarm2Set_Button
            // 
            this.Alarm2Set_Button.Location = new System.Drawing.Point(74, 155);
            this.Alarm2Set_Button.Name = "Alarm2Set_Button";
            this.Alarm2Set_Button.Size = new System.Drawing.Size(75, 23);
            this.Alarm2Set_Button.TabIndex = 7;
            this.Alarm2Set_Button.Text = "Set";
            this.Alarm2Set_Button.UseVisualStyleBackColor = true;
            // 
            // Alarm2_Clock
            // 
            this.Alarm2_Clock.AutoSize = true;
            this.Alarm2_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm2_Clock.Location = new System.Drawing.Point(45, 97);
            this.Alarm2_Clock.Name = "Alarm2_Clock";
            this.Alarm2_Clock.Size = new System.Drawing.Size(145, 55);
            this.Alarm2_Clock.TabIndex = 6;
            this.Alarm2_Clock.Text = "00:00";
            // 
            // SetAlarm2Minute
            // 
            this.SetAlarm2Minute.AutoSize = true;
            this.SetAlarm2Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarm2Minute.Location = new System.Drawing.Point(31, 57);
            this.SetAlarm2Minute.Name = "SetAlarm2Minute";
            this.SetAlarm2Minute.Size = new System.Drawing.Size(90, 18);
            this.SetAlarm2Minute.TabIndex = 5;
            this.SetAlarm2Minute.Text = "Set minutes:";
            // 
            // SetAlarm2Hour
            // 
            this.SetAlarm2Hour.AutoSize = true;
            this.SetAlarm2Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarm2Hour.Location = new System.Drawing.Point(31, 39);
            this.SetAlarm2Hour.Name = "SetAlarm2Hour";
            this.SetAlarm2Hour.Size = new System.Drawing.Size(76, 18);
            this.SetAlarm2Hour.TabIndex = 4;
            this.SetAlarm2Hour.Text = "Set hours:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 523);
            this.Controls.Add(this.AlarmTabBox);
            this.Controls.Add(this.Clock_GroupBox);
            this.Name = "Form1";
            this.Text = "Klocka";
            this.Clock_GroupBox.ResumeLayout(false);
            this.Clock_GroupBox.PerformLayout();
            this.Alarm1_GroupBox.ResumeLayout(false);
            this.Alarm1_GroupBox.PerformLayout();
            this.AlarmTabBox.ResumeLayout(false);
            this.AlarmTabPage1.ResumeLayout(false);
            this.AlarmTabPage2.ResumeLayout(false);
            this.Alarm2_GroupBox.ResumeLayout(false);
            this.Alarm2_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ClockTime_Form;
        private System.Windows.Forms.Button ClockStart_Button;
        private System.Windows.Forms.Label ClockHourSet;
        private System.Windows.Forms.Label ClockMinuteSet;
        private System.Windows.Forms.GroupBox Clock_GroupBox;
        private System.Windows.Forms.GroupBox Alarm1_GroupBox;
        private System.Windows.Forms.Button Alarm1Set_Button;
        private System.Windows.Forms.Label Alarm1_Clock;
        private System.Windows.Forms.Label SetAlarmMinute1;
        private System.Windows.Forms.Label SetAlarmHour1;
        private System.Windows.Forms.TabControl AlarmTabBox;
        private System.Windows.Forms.TabPage AlarmTabPage1;
        private System.Windows.Forms.TabPage AlarmTabPage2;
        private System.Windows.Forms.GroupBox Alarm2_GroupBox;
        private System.Windows.Forms.Button Alarm2Set_Button;
        private System.Windows.Forms.Label Alarm2_Clock;
        private System.Windows.Forms.Label SetAlarm2Minute;
        private System.Windows.Forms.Label SetAlarm2Hour;
        private System.Windows.Forms.TextBox ClockMinuteInput_TextBox;
        private System.Windows.Forms.TextBox ClockHourInput_TextBox;
        private System.Windows.Forms.TextBox Alarm1MinuteInput_TextBox;
        private System.Windows.Forms.TextBox Alarm1HourInput_TextBox;
        private System.Windows.Forms.TextBox Alarm2MinuteInput_TextBox;
        private System.Windows.Forms.TextBox Alarm2HourInput_TextBox;
    }
}

