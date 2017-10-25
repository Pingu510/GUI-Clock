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
using ClockLogic;
using System.Media;

namespace GUI_Clock
{
    public partial class Form1 : Form
    {
        ProgramLogic programLogic = new ProgramLogic();
        DateTime myPickedClockTime;
        DateTime myPickedAlarm1Time;
        DateTime myPickedAlarm2Time;


        public Form1()
        {
            InitializeComponent();
            programLogic.clock.Minute.OnTick += Minute_OnTick;
            
            SetDateTimeFormats();
        }

        /// <summary>
        /// Sets a custom format for the datetime boxes, 24h clock.
        /// </summary>
        private void SetDateTimeFormats()
        {
            Clock_DateTimePicker.CustomFormat = "HH:mm";
            Alarm1_DateTimePicker.CustomFormat = "HH:mm";            
            Alarm2_DateTimePicker.CustomFormat = "HH:mm";
        }


        private void Minute_OnTick()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(Update_Clock_Form));
            }
        }

        /// <summary>
        /// Updates the clocktimer GUI and calls an alarmcheck method.
        /// </summary>
        public void Update_Clock_Form()
        {
            ClockTime_Form.Text = programLogic.CreateTimeString();
            IsItTimeForAlarm();           
        }
        
        /// <summary>
        /// Checks if its time to sound the alarm and then proceds to call SoundTheAlarm(),
        ///  and then manages what happens when the alarm is shut off
        /// </summary>
        private void IsItTimeForAlarm()
        {
            int _currenthour = programLogic.clock.GetHours();
            int _currentminute = programLogic.clock.GetMinutes();

            if (programLogic.Alarm1.CheckAlarm(_currenthour, _currentminute) && programLogic.Alarm2.CheckAlarm(_currenthour, _currentminute))
            {
                SoundTheAlarm();
                WhenAlarmIsDone("Alarm1");
                WhenAlarmIsDone("Alarm2");
            }
            else if (programLogic.Alarm1.CheckAlarm(_currenthour, _currentminute))
            {
                SoundTheAlarm();
                WhenAlarmIsDone("Alarm1");
            }
            else if (programLogic.Alarm2.CheckAlarm(_currenthour, _currentminute))
            {
                SoundTheAlarm();
                WhenAlarmIsDone("Alarm2");
            }
        }

        /// <summary>
        /// Changes ActiveAlarm, buttons, datetime picker to right values  
        /// </summary>
        /// <param name="currentAlarm"></param>
        private void WhenAlarmIsDone (string currentAlarm)
        {
            if (currentAlarm == "Alarm1")
            {
                programLogic.Alarm1.SetToActive(false); //sets alarm to inactive
                Alarm1Set_Button.Text = "Set";
                Alarm1_DateTimePicker.Enabled = true;
            }
            else if (currentAlarm == "Alarm2")
            {
                programLogic.Alarm2.SetToActive(false); //sets alarm to inactive
                Alarm2Set_Button.Text = "Set";
                Alarm2_DateTimePicker.Enabled = true;
            }
        }

        /// <summary>
        /// This is where the alarm goes off
        /// </summary>
        private void SoundTheAlarm()
        {
            DialogResult result = DialogResult.None;
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.ChurchBell);

            while (result != DialogResult.OK)
            {
                soundPlayer.PlayLooping();
                result = MessageBox.Show("Tick Tock Goes The Clock...", "Alarming news!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            soundPlayer.Stop();
        }

        /// <summary>
        /// Starts and stops the clock
        /// </summary>
        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (ClockStart_Button.Text == "Start") //Starts clock
            {
                ClockStart_Button.Text = "Stop";

                programLogic.clock.SetTime(myPickedClockTime.Hour, myPickedClockTime.Minute);
                programLogic.clock.StartClock();

                Clock_DateTimePicker.Enabled = false;
            }
            else//Stops Clock
            {
                ClockStart_Button.Text = "Start";
                programLogic.clock.StopClock();

                Clock_DateTimePicker.Enabled = true;
            }
        }

        /// <summary>
        /// When the text in clock datetime is changed, does this.
        /// </summary>
        private void Clock_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedClockTime = Clock_DateTimePicker.Value;
            programLogic.clock.SetTime(myPickedClockTime.Hour, myPickedClockTime.Minute);
            ClockTime_Form.Text = programLogic.CreateTimeString();
        }

        /// <summary>
        /// When the text in alarm 1 datetime is changed, does this.
        /// </summary>
        private void Alarm1_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedAlarm1Time = Alarm1_DateTimePicker.Value;            
            Alarm1_Clock.Text = myPickedAlarm1Time.Hour.ToString("00") + ":" + myPickedAlarm1Time.Minute.ToString("00");
        }

        /// <summary>
        /// When the text in alarm 2 datetime is changed, does this.
        /// </summary>
        private void Alarm2_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedAlarm2Time = Alarm2_DateTimePicker.Value;
            Alarm2_Clock.Text = myPickedAlarm2Time.Hour.ToString("00") + ":" + myPickedAlarm2Time.Minute.ToString("00");
        }

        /// <summary>
        /// Sets alarm 1 to active or inactive
        /// </summary>
        private void Alarm1Set_Button_Click(object sender, EventArgs e)
        {
            if (Alarm1Set_Button.Text == "Set")
            {
                Alarm1Set_Button.Text = "Disable";
                Alarm1_DateTimePicker.Enabled = false;
                programLogic.Alarm1.SetAlarm(myPickedAlarm1Time.Hour, myPickedAlarm1Time.Minute);
            }
            else
            {
                programLogic.Alarm1.SetToActive(false);
                Alarm1Set_Button.Text = "Set";
                Alarm1_DateTimePicker.Enabled = true;
            }
        }

        /// <summary>
        /// Sets alarm 2 to active or inactive
        /// </summary>
        private void Alarm2Set_Button_Click(object sender, EventArgs e)
        {
            if(Alarm2Set_Button.Text == "Set")
            {
                Alarm2Set_Button.Text = "Disable";
                Alarm2_DateTimePicker.Enabled = false;
                programLogic.Alarm2.SetAlarm(myPickedAlarm2Time.Hour, myPickedAlarm2Time.Minute);
            }
            else
            {
                programLogic.Alarm2.SetToActive(false);
                Alarm2Set_Button.Text = "Set";
                Alarm2_DateTimePicker.Enabled = true;
            }
        }
    }
}
