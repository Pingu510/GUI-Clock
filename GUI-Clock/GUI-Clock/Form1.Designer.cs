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
            this.Clock_Form = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Sethour = new System.Windows.Forms.Label();
            this.Setminutes = new System.Windows.Forms.Label();
            this.clockbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlarmTabBox = new System.Windows.Forms.TabControl();
            this.AlarmTabPage1 = new System.Windows.Forms.TabPage();
            this.AlarmTabPage2 = new System.Windows.Forms.TabPage();
            this.AlarmBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SetButtomTab2 = new System.Windows.Forms.Button();
            this.AlarmClockTab2 = new System.Windows.Forms.Label();
            this.SetMinuteTab2 = new System.Windows.Forms.Label();
            this.SetHoursTabPage2 = new System.Windows.Forms.Label();
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
            this.Clock_Form.Click += new System.EventHandler(this.Clock_Click);
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
            this.clockbox.Controls.Add(this.button1);
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
            this.clockbox.Enter += new System.EventHandler(this.clockbox_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alarm";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "00:00";
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
            this.AlarmBox2.Controls.Add(this.textBox6);
            this.AlarmBox2.Controls.Add(this.textBox5);
            this.AlarmBox2.Controls.Add(this.SetButtomTab2);
            this.AlarmBox2.Controls.Add(this.AlarmClockTab2);
            this.AlarmBox2.Controls.Add(this.SetMinuteTab2);
            this.AlarmBox2.Controls.Add(this.SetHoursTabPage2);
            this.AlarmBox2.Location = new System.Drawing.Point(21, 32);
            this.AlarmBox2.Name = "AlarmBox2";
            this.AlarmBox2.Size = new System.Drawing.Size(281, 217);
            this.AlarmBox2.TabIndex = 1;
            this.AlarmBox2.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(124, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(124, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 8;
            // 
            // SetButtomTab2
            // 
            this.SetButtomTab2.Location = new System.Drawing.Point(74, 155);
            this.SetButtomTab2.Name = "SetButtomTab2";
            this.SetButtomTab2.Size = new System.Drawing.Size(75, 23);
            this.SetButtomTab2.TabIndex = 7;
            this.SetButtomTab2.Text = "Set";
            this.SetButtomTab2.UseVisualStyleBackColor = true;
            // 
            // AlarmClockTab2
            // 
            this.AlarmClockTab2.AutoSize = true;
            this.AlarmClockTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmClockTab2.Location = new System.Drawing.Point(45, 97);
            this.AlarmClockTab2.Name = "AlarmClockTab2";
            this.AlarmClockTab2.Size = new System.Drawing.Size(145, 55);
            this.AlarmClockTab2.TabIndex = 6;
            this.AlarmClockTab2.Text = "00:00";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 523);
            this.Controls.Add(this.AlarmTabBox);
            this.Controls.Add(this.clockbox);
            this.Name = "Form1";
            this.Text = "Klocka";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl AlarmTabBox;
        private System.Windows.Forms.TabPage AlarmTabPage1;
        private System.Windows.Forms.TabPage AlarmTabPage2;
        private System.Windows.Forms.GroupBox AlarmBox2;
        private System.Windows.Forms.Button SetButtomTab2;
        private System.Windows.Forms.Label AlarmClockTab2;
        private System.Windows.Forms.Label SetMinuteTab2;
        private System.Windows.Forms.Label SetHoursTabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}

