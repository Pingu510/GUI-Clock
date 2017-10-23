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
            programLogic.TickingClock();

            BeginInvoke((MethodInvoker)delegate () {
                Clock_Form.Text = $"{programLogic.clock.GetHours().ToString("00")}:{programLogic.clock.GetMinutes().ToString("00")}";
              var isAlert =  programLogic.Alarm1.CheckAlarm(programLogic.clock.GetHours(), programLogic.clock.GetMinutes());
                if (isAlert)
                {
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
            AlarmTabPage2.BackColor = Color.DeepPink;
            Blink();
            programLogic.clock.SetTime(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            programLogic.StartClock();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private async void Blink()
        {
            while(true)
            {
                await Task.Delay(1000);
                AlarmTabPage2.BackColor = AlarmTabPage2.BackColor == Color.DeepPink ? Color.White : Color.Red;
            }
        }

        private void AlarmTabPage2_Click(object sender, EventArgs e)
        {
            AlarmTabPage2.BackColor = Color.DarkSalmon;

                
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Clock_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string setTime = Console.ReadLine();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string setMinute = Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            programLogic.clock.StopClock();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
    }
}
