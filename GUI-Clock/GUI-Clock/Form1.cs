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
        }
        
        private void SoundTheAlarm()
        {
            if (programLogic.TimeForSetOffAlarm())
            {
                //Färgsprakande grejs
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
