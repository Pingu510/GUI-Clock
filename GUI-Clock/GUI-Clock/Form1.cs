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
            //Thread ThreadTime = new Thread(new ThreadStart(Minute_OnTick);//Update_Clock_Form));
            programLogic.clock.Minute.OnTick += Minute_OnTick;
            
            SetDateTimeFormats();

        }

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

        public void Update_Clock_Form()
        {
            ClockTime_Form.Text = programLogic.CreateTimeString();

            // Om båda larmen ska gå samtidigt, använd programLogic.IsItTimeForAlarm() ist

            if (programLogic.Alarm1.CheckAlarm(programLogic.clock.GetHours(), programLogic.clock.GetMinutes()))
            {
                ManageTheAlarm("alarm1");
            }
            else if(programLogic.Alarm2.CheckAlarm(programLogic.clock.GetHours(), programLogic.clock.GetMinutes()))
            {
                ManageTheAlarm("alarm2");
            }
            
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (ClockStart_Button.Text == "Start") //Startar klocka
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
        /// This is where the alarm goes off
        /// </summary>
        private void ManageTheAlarm(string whatalarm)
        {
            SoundTheAlarm();

            if (whatalarm == "alarm1")
            {
                programLogic.Alarm1.SetToActive(false); //sets alarm to inactive
                Alarm1Set_Button.Text = "Set";
                Alarm1_DateTimePicker.Enabled = true;
            }
            else if (whatalarm == "alarm2")
            {
                programLogic.Alarm2.SetToActive(false); //sets alarm to inactive
                Alarm2Set_Button.Text = "Set";
                Alarm2_DateTimePicker.Enabled = true;
            }
        }

        /// <summary>
        /// This is what happens when alarm goes off
        /// </summary>
        private void SoundTheAlarm()
        {
            //string filepath = System.Reflection.Assembly.LoadFile("bells004.wav");//GetExecutingAssembly().GetManifestResourceNames();

            DialogResult result = DialogResult.None;
            //string filepath = "";
            SoundPlayer soundPlayer = new SoundPlayer("Resources\\bells004.wav");

            while (result != DialogResult.OK)
            {
                soundPlayer.PlayLooping();
                //AlarmTabPage2.BackColor = Color.DeepPink;
                result = MessageBox.Show("Tick Tock Goes The Clock...", "Alarming news!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            soundPlayer.Stop();
            //AlarmTabPage2.BackColor = Color.White;
        }

        private void Clock_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedClockTime = Clock_DateTimePicker.Value;
            programLogic.clock.SetTime(myPickedClockTime.Hour, myPickedClockTime.Minute);
            ClockTime_Form.Text = programLogic.CreateTimeString();
        }

        /// <summary>
        /// Alarm 1 pick time box
        /// </summary>
        private void Alarm1_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedAlarm1Time = Alarm1_DateTimePicker.Value;            
            Alarm1_Clock.Text = myPickedAlarm1Time.Hour.ToString("00") + ":" + myPickedAlarm1Time.Minute.ToString("00");
        }

        /// <summary>
        /// Alarm 2 pick time box
        /// </summary>
        private void Alarm2_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedAlarm2Time = Alarm2_DateTimePicker.Value;
            Alarm2_Clock.Text = myPickedAlarm2Time.Hour.ToString("00") + ":" + myPickedAlarm2Time.Minute.ToString("00");
        }

        /// <summary>
        /// Alarm 1 sets the alarm
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
        /// Alarm 2 sets the alarm
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
