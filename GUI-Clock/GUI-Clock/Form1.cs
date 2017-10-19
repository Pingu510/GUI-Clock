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
        public Clock clock;


        public Form1()
        {
            InitializeComponent();

            Thread t = new Thread(new ThreadStart(TickingClock));
            t.Start();
        }

        public void TickingClock()
        {
            clock = new Clock();
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
