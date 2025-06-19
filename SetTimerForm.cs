using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class SetTimerForm : Form
    {
        public int Hours => (int)hourNum.Value;
        public int Minutes => (int)minutesNum.Value;
        public int Seconds => (int)secNum.Value;

        public SetTimerForm(TimeSpan initialTime)
        {
            InitializeComponent();

            hourNum.Value = initialTime.Hours;
            minutesNum.Value = initialTime.Minutes;
            secNum.Value = initialTime.Seconds;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
