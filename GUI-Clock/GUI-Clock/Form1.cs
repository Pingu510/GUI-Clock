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


        public Form1()
        {
            InitializeComponent();
            Thread ThreadTime = new Thread(new ThreadStart(Update_Clock_Form));
            programLogic.clock.Minute.OnTick += Minute_OnTick;
            
        }

        private void Minute_OnTick()
        {
            Update_Clock_Form();
        }

        public void Update_Clock_Form()
        {
           // programLogic.TickingClock();

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
                AlarmTabPage2.BackColor = Color.DeepPink;
                Blink();
                programLogic.clock.SetTime(int.Parse(ClockHourInput_TextBox.Text), int.Parse(ClockMinuteInput_TextBox.Text));
                programLogic.clock.StartClock();

                ClockHourInput_TextBox.Enabled = false;
                ClockMinuteInput_TextBox.Enabled = false;
            }
            else//Stänger klocka
            {
                ClockStart_Button.Text = "Start";
                programLogic.clock.StopClock();
                ClockHourInput_TextBox.Enabled = true;
                ClockMinuteInput_TextBox.Enabled = true;
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
        
        private void ClockHourInput_TextBox_TextChanged(object sender, EventArgs e)
        {
            string setTime = Console.ReadLine();

        }

        private void ClockMinuteInput_TextBox_TextChanged(object sender, EventArgs e)
        {
            string setMinute = Console.ReadLine();
        }

    }
}
