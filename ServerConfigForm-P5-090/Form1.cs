using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_090;

namespace ServerConfigForm_P5_090
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnOff.Text = "Server On";
            labelket.Text = "klik OFF untuk mematikan server";
            Host.Open();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Close();
            labelket.Text = "klik On untuk mematikan server";
            labelOnOff.Text = "Server off";
        }
    }
}
