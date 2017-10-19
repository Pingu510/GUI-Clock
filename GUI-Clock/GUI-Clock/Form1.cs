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
            ThreadTime.Start();

        }
       
        public void Update_Clock_Form()
        {
            programLogic.TickingClock();
            string currenttime;
            string strhours = programLogic.clock.GetHours().ToString();
            if(strhours.Length > 1)
            {
                 currenttime = "0" + strhours;
            }
            string strminutes = programLogic.clock.GetMinutes().ToString();
            Clock_Form.Text = "00:00";
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            AlarmTabPage2.BackColor = Color.DeepPink;
            Blink();
            //clock.StartClock();


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
    }
}
