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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClockTime_Form = new System.Windows.Forms.Label();
            this.ClockStart_Button = new System.Windows.Forms.Button();
            this.ClockTimeSet = new System.Windows.Forms.Label();
            this.Clock_GroupBox = new System.Windows.Forms.GroupBox();
            this.Clock_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Alarm1_GroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm1_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Alarm1Set_Button = new System.Windows.Forms.Button();
            this.Alarm1_Clock = new System.Windows.Forms.Label();
            this.SetAlarmHour1 = new System.Windows.Forms.Label();
            this.Alarm2_GroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm2_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Alarm2Set_Button = new System.Windows.Forms.Button();
            this.Alarm2_Clock = new System.Windows.Forms.Label();
            this.SetAlarm2Hour = new System.Windows.Forms.Label();
            this.EasterPacBox = new System.Windows.Forms.PictureBox();
            this.Clock_GroupBox.SuspendLayout();
            this.Alarm1_GroupBox.SuspendLayout();
            this.Alarm2_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EasterPacBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClockTime_Form
            // 
            this.ClockTime_Form.AutoSize = true;
            this.ClockTime_Form.BackColor = System.Drawing.Color.Transparent;
            this.ClockTime_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 66F);
            this.ClockTime_Form.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClockTime_Form.Location = new System.Drawing.Point(349, 179);
            this.ClockTime_Form.Name = "ClockTime_Form";
            this.ClockTime_Form.Size = new System.Drawing.Size(263, 101);
            this.ClockTime_Form.TabIndex = 0;
            this.ClockTime_Form.Text = "00:00";
            // 
            // ClockStart_Button
            // 
            this.ClockStart_Button.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockStart_Button.Location = new System.Drawing.Point(175, 27);
            this.ClockStart_Button.Name = "ClockStart_Button";
            this.ClockStart_Button.Size = new System.Drawing.Size(75, 26);
            this.ClockStart_Button.TabIndex = 1;
            this.ClockStart_Button.Text = "Start";
            this.ClockStart_Button.UseVisualStyleBackColor = true;
            this.ClockStart_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // ClockTimeSet
            // 
            this.ClockTimeSet.AutoSize = true;
            this.ClockTimeSet.Font = new System.Drawing.Font("Constantia", 15F);
            this.ClockTimeSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClockTimeSet.Location = new System.Drawing.Point(11, 28);
            this.ClockTimeSet.Name = "ClockTimeSet";
            this.ClockTimeSet.Size = new System.Drawing.Size(87, 24);
            this.ClockTimeSet.TabIndex = 2;
            this.ClockTimeSet.Text = "Set time:";
            // 
            // Clock_GroupBox
            // 
            this.Clock_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Clock_GroupBox.Controls.Add(this.Clock_DateTimePicker);
            this.Clock_GroupBox.Controls.Add(this.ClockStart_Button);
            this.Clock_GroupBox.Controls.Add(this.ClockTimeSet);
            this.Clock_GroupBox.Location = new System.Drawing.Point(329, 60);
            this.Clock_GroupBox.Name = "Clock_GroupBox";
            this.Clock_GroupBox.Size = new System.Drawing.Size(267, 72);
            this.Clock_GroupBox.TabIndex = 4;
            this.Clock_GroupBox.TabStop = false;
            // 
            // Clock_DateTimePicker
            // 
            this.Clock_DateTimePicker.AllowDrop = true;
            this.Clock_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Clock_DateTimePicker.Location = new System.Drawing.Point(104, 27);
            this.Clock_DateTimePicker.Name = "Clock_DateTimePicker";
            this.Clock_DateTimePicker.ShowUpDown = true;
            this.Clock_DateTimePicker.Size = new System.Drawing.Size(65, 26);
            this.Clock_DateTimePicker.TabIndex = 6;
            this.Clock_DateTimePicker.Value = new System.DateTime(2017, 10, 24, 0, 0, 0, 0);
            this.Clock_DateTimePicker.ValueChanged += new System.EventHandler(this.Clock_DateTimePicker_ValueChanged);
            // 
            // Alarm1_GroupBox
            // 
            this.Alarm1_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1_DateTimePicker);
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1Set_Button);
            this.Alarm1_GroupBox.Controls.Add(this.Alarm1_Clock);
            this.Alarm1_GroupBox.Controls.Add(this.SetAlarmHour1);
            this.Alarm1_GroupBox.Location = new System.Drawing.Point(25, 34);
            this.Alarm1_GroupBox.Name = "Alarm1_GroupBox";
            this.Alarm1_GroupBox.Size = new System.Drawing.Size(280, 200);
            this.Alarm1_GroupBox.TabIndex = 0;
            this.Alarm1_GroupBox.TabStop = false;
            // 
            // Alarm1_DateTimePicker
            // 
            this.Alarm1_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm1_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Alarm1_DateTimePicker.Location = new System.Drawing.Point(101, 41);
            this.Alarm1_DateTimePicker.Name = "Alarm1_DateTimePicker";
            this.Alarm1_DateTimePicker.ShowUpDown = true;
            this.Alarm1_DateTimePicker.Size = new System.Drawing.Size(65, 26);
            this.Alarm1_DateTimePicker.TabIndex = 4;
            this.Alarm1_DateTimePicker.Value = new System.DateTime(2017, 10, 24, 0, 0, 0, 0);
            this.Alarm1_DateTimePicker.ValueChanged += new System.EventHandler(this.Alarm1_DateTimePicker_ValueChanged);
            // 
            // Alarm1Set_Button
            // 
            this.Alarm1Set_Button.BackColor = System.Drawing.Color.Transparent;
            this.Alarm1Set_Button.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm1Set_Button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Alarm1Set_Button.Location = new System.Drawing.Point(91, 149);
            this.Alarm1Set_Button.Name = "Alarm1Set_Button";
            this.Alarm1Set_Button.Size = new System.Drawing.Size(75, 23);
            this.Alarm1Set_Button.TabIndex = 3;
            this.Alarm1Set_Button.Text = "Set";
            this.Alarm1Set_Button.UseVisualStyleBackColor = false;
            this.Alarm1Set_Button.Click += new System.EventHandler(this.Alarm1Set_Button_Click);
            // 
            // Alarm1_Clock
            // 
            this.Alarm1_Clock.AutoSize = true;
            this.Alarm1_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm1_Clock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Alarm1_Clock.Location = new System.Drawing.Point(54, 70);
            this.Alarm1_Clock.Name = "Alarm1_Clock";
            this.Alarm1_Clock.Size = new System.Drawing.Size(151, 59);
            this.Alarm1_Clock.TabIndex = 2;
            this.Alarm1_Clock.Text = "00:00";
            // 
            // SetAlarmHour1
            // 
            this.SetAlarmHour1.AutoSize = true;
            this.SetAlarmHour1.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarmHour1.Location = new System.Drawing.Point(78, 16);
            this.SetAlarmHour1.Name = "SetAlarmHour1";
            this.SetAlarmHour1.Size = new System.Drawing.Size(104, 22);
            this.SetAlarmHour1.TabIndex = 0;
            this.SetAlarmHour1.Text = "Set Alarm 1:";
            // 
            // Alarm2_GroupBox
            // 
            this.Alarm2_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2_DateTimePicker);
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2Set_Button);
            this.Alarm2_GroupBox.Controls.Add(this.Alarm2_Clock);
            this.Alarm2_GroupBox.Controls.Add(this.SetAlarm2Hour);
            this.Alarm2_GroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.Alarm2_GroupBox.Location = new System.Drawing.Point(25, 267);
            this.Alarm2_GroupBox.Name = "Alarm2_GroupBox";
            this.Alarm2_GroupBox.Size = new System.Drawing.Size(280, 200);
            this.Alarm2_GroupBox.TabIndex = 1;
            this.Alarm2_GroupBox.TabStop = false;
            // 
            // Alarm2_DateTimePicker
            // 
            this.Alarm2_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm2_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Alarm2_DateTimePicker.Location = new System.Drawing.Point(101, 41);
            this.Alarm2_DateTimePicker.Name = "Alarm2_DateTimePicker";
            this.Alarm2_DateTimePicker.ShowUpDown = true;
            this.Alarm2_DateTimePicker.Size = new System.Drawing.Size(65, 26);
            this.Alarm2_DateTimePicker.TabIndex = 8;
            this.Alarm2_DateTimePicker.Value = new System.DateTime(2017, 10, 24, 0, 0, 0, 0);
            this.Alarm2_DateTimePicker.ValueChanged += new System.EventHandler(this.Alarm2_DateTimePicker_ValueChanged);
            // 
            // Alarm2Set_Button
            // 
            this.Alarm2Set_Button.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm2Set_Button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Alarm2Set_Button.Location = new System.Drawing.Point(91, 151);
            this.Alarm2Set_Button.Name = "Alarm2Set_Button";
            this.Alarm2Set_Button.Size = new System.Drawing.Size(75, 23);
            this.Alarm2Set_Button.TabIndex = 7;
            this.Alarm2Set_Button.Text = "Set";
            this.Alarm2Set_Button.UseVisualStyleBackColor = true;
            this.Alarm2Set_Button.Click += new System.EventHandler(this.Alarm2Set_Button_Click);
            // 
            // Alarm2_Clock
            // 
            this.Alarm2_Clock.AutoSize = true;
            this.Alarm2_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm2_Clock.Location = new System.Drawing.Point(54, 73);
            this.Alarm2_Clock.Name = "Alarm2_Clock";
            this.Alarm2_Clock.Size = new System.Drawing.Size(151, 59);
            this.Alarm2_Clock.TabIndex = 6;
            this.Alarm2_Clock.Text = "00:00";
            // 
            // SetAlarm2Hour
            // 
            this.SetAlarm2Hour.AutoSize = true;
            this.SetAlarm2Hour.Font = new System.Drawing.Font("Constantia", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAlarm2Hour.Location = new System.Drawing.Point(78, 16);
            this.SetAlarm2Hour.Name = "SetAlarm2Hour";
            this.SetAlarm2Hour.Size = new System.Drawing.Size(107, 22);
            this.SetAlarm2Hour.TabIndex = 4;
            this.SetAlarm2Hour.Text = "Set Alarm 2:";
            // 
            // EasterPacBox
            // 
            this.EasterPacBox.BackColor = System.Drawing.Color.Transparent;
            this.EasterPacBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EasterPacBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasterPacBox.Image = global::GUI_Clock.Properties.Resources.Pac_Man;
            this.EasterPacBox.Location = new System.Drawing.Point(644, 373);
            this.EasterPacBox.Name = "EasterPacBox";
            this.EasterPacBox.Size = new System.Drawing.Size(30, 26);
            this.EasterPacBox.TabIndex = 7;
            this.EasterPacBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.EasterPacBox);
            this.Controls.Add(this.Alarm1_GroupBox);
            this.Controls.Add(this.Alarm2_GroupBox);
            this.Controls.Add(this.ClockTime_Form);
            this.Controls.Add(this.Clock_GroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 550);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klocka";
            this.Clock_GroupBox.ResumeLayout(false);
            this.Clock_GroupBox.PerformLayout();
            this.Alarm1_GroupBox.ResumeLayout(false);
            this.Alarm1_GroupBox.PerformLayout();
            this.Alarm2_GroupBox.ResumeLayout(false);
            this.Alarm2_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EasterPacBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClockTime_Form;
        private System.Windows.Forms.Button ClockStart_Button;
        private System.Windows.Forms.Label ClockTimeSet;
        private System.Windows.Forms.GroupBox Clock_GroupBox;
        private System.Windows.Forms.GroupBox Alarm1_GroupBox;
        private System.Windows.Forms.Button Alarm1Set_Button;
        private System.Windows.Forms.Label Alarm1_Clock;
        private System.Windows.Forms.Label SetAlarmHour1;
        private System.Windows.Forms.GroupBox Alarm2_GroupBox;
        private System.Windows.Forms.Button Alarm2Set_Button;
        private System.Windows.Forms.Label Alarm2_Clock;
        private System.Windows.Forms.Label SetAlarm2Hour;
        private System.Windows.Forms.DateTimePicker Clock_DateTimePicker;
        private System.Windows.Forms.DateTimePicker Alarm1_DateTimePicker;
        private System.Windows.Forms.DateTimePicker Alarm2_DateTimePicker;
        private System.Windows.Forms.PictureBox EasterPacBox;
    }
}

