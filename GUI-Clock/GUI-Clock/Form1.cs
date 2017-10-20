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
                Start_Button.Text = "Stop";
                ClockTimer.Start();
            }
            else
            {
                Start_Button.Text = "Start";
                ClockTimer.Stop();
            }
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
            //if (clockvalues == "00:00")
            //{
            //    clockvalues = "11:11";
            //}
            //else
            //{
            //    clockvalues = "00:00";
            //}
            programLogic.clock.Timer_Elapsed();
            currenttime = programLogic.CreateTimeString();

            System.Diagnostics.Debug.WriteLine("this is Cbackgw");
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
            if (SetAlarm_Button.Text == "Set")
            {
                SetAlarm_Button.Text = "Abort";
            }
            else
            {
                SetAlarm_Button.Text = "Set";
            }
        }

        private async void Blink()
        {
            while(true)
            {
                await Task.Delay(1000);
                AlarmTabPage2.BackColor = AlarmTabPage2.BackColor == Color.DeepPink ? Color.White : Color.Red;
            }
        }
    }
}
