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
        DateTime myPickedDateTime;


        public Form1()
        {
            InitializeComponent();
            Thread ThreadTime = new Thread(new ThreadStart(Update_Clock_Form));
            programLogic.clock.Minute.OnTick += Minute_OnTick;
            

            Clock_DateTimePicker.Format = DateTimePickerFormat.Custom;
            Clock_DateTimePicker.ShowUpDown = true;
            Clock_DateTimePicker.CustomFormat = "HH:mm";
        }

        private void Minute_OnTick()
        {
            Update_Clock_Form();
        }

        public void Update_Clock_Form()
        {

            BeginInvoke((MethodInvoker)delegate () {
                ClockTime_Form.Text = $"{programLogic.clock.GetHours().ToString("00")}:{programLogic.clock.GetMinutes().ToString("00")}";
              var isAlert =  programLogic._alarm1.CheckAlarm(programLogic.clock.GetHours(), programLogic.clock.GetMinutes());
                if (isAlert)
                {
                    SystemSounds.Asterisk.Play();
                    //noise
                }
                else
                {
//remove the noise
                }

            });

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            
            if (ClockStart_Button.Text == "Start") //Startar klocka
            {
                ClockStart_Button.Text = "Stop";

                programLogic.clock.SetTime(myPickedDateTime.Hour, myPickedDateTime.Minute);
                programLogic.clock.StartClock();

                Clock_DateTimePicker.Enabled = false;
            }
            else//Stänger klocka
            {
                ClockStart_Button.Text = "Start";
                programLogic.clock.StopClock();

                Clock_DateTimePicker.Enabled = true;
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

        private void Clock_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            myPickedDateTime = Clock_DateTimePicker.Value;
            ClockTime_Form.Text = myPickedDateTime.Hour.ToString() + ":" + myPickedDateTime.Minute.ToString();
        }
    }
}
