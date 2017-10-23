using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using ClockLogic;

namespace GUI_Clock
{
    public partial class Form1 : Form
    {
        public string currenttime;

        ProgramLogic programLogic = new ProgramLogic();

        public Form1()
        {
            InitializeComponent();
        }



        // This button event starts and stops the clock
        private void Start_Button_Click(object sender, EventArgs e)
        {
            //AlarmTabPage2.BackColor = Color.DeepPink;
            //Blink();
            if (Start_Button.Text == "Start")
            {
                Start_Time();
                Start_Button.Text = "Stop";
                //programLogic.clock.StartClock();
                ClockTimer.Start();
            }
            else
            {
                Start_Button.Text = "Start";
                //programLogic.clock.StopClock();
                ClockTimer.Stop();
            }
        }

        private void Start_Time()
        {

        }

        /// <summary>
        /// Timer who handles clock
        /// </summary>
        private void ClockTimer_Tick(object sender, EventArgs e)
        { 
            ClockTimer.Interval = 1000;
            ClockTimer.Enabled = false;
            ClockBackgroundWorker.RunWorkerAsync();
            ClockTimer.Enabled = true;
        }

        private void ClockBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            programLogic.clock.Timer_Elapsed();
            currenttime = programLogic.CreateTimeString();

            //System.Diagnostics.Debug.WriteLine("this is Cbackgw");
        }

        /// <summary>
        /// Updates the graphics form of DigitalClock.
        /// Triggers when ClockBackgroundworker has done work.
        /// </summary>
        private void ClockBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Clock_Form.Text = currenttime;
        }

        private void SetAlarm_Button_Click(object sender, EventArgs e)
        {
            if (Tab1_Set_Alarm1_Buttom.Text == "Set")
            {
                Tab1_Set_Alarm1_Buttom.Text = "Abort";
                int _hour = programLogic.CreateTimeIntiger(Alarm1_Hour_Textbox.Text);
                int _minute = programLogic.CreateTimeIntiger(Alarm1_Minute_Textbox.Text);
                programLogic._alarm1.SetAlarm(_hour, _minute);
            }
            else
            {
                Tab1_Set_Alarm1_Buttom.Text = "Set";
            }
        }

        //Blinkande bakgrund
        private async void Blink()
        {
            while(true)
            {
                await Task.Delay(1000);
                AlarmTabPage2.BackColor = AlarmTabPage2.BackColor == Color.DeepPink ? Color.White : Color.Red;
            }
        }

<<<<<<< HEAD
        private void AlarmClockTab2_Click(object sender, EventArgs e)
=======
        private void AlarmTabPage2_Click(object sender, EventArgs e)
>>>>>>> f2c6285f07985e64d21d5c10dd667b26c8bf4ad7
        {

        }
    }
}
