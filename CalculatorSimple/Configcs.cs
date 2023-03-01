using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CalculatorSimple
{
    public partial class Configcs : Form
    {
        private Form1 _parentForm;
        public Configcs(Form1 form1)
        {
            _parentForm = form1;
            InitializeComponent();
            this.Load += Configcs_Load1;
        }

        private void Configcs_Load1(object sender, EventArgs e)
        {
            string[] RGB = (ConfigurationManager.AppSettings["ColorPanel"]).Split(',');
            trackBar_Red1.Value = int.Parse(RGB[0]);
            trackBar_Green1.Value = int.Parse(RGB[1]);
            trackBar_Blue1.Value = int.Parse(RGB[2]);

            groupBox1.BackColor = Color.FromArgb(trackBar_Red1.Value, trackBar_Green1.Value, trackBar_Blue1.Value);
            this.BackColor = Color.FromArgb(56, 56, 56);
        }

        private void Configcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void trackBar_ColorChange_Scroll(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(trackBar_Red1.Value, trackBar_Green1.Value, trackBar_Blue1.Value);
            _parentForm.ChangeColor(groupBox1.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] RGB = (ConfigurationManager.AppSettings["DefaultColorPanel"]).Split(',');
            trackBar_Red1.Value = int.Parse(RGB[0]);
            trackBar_Green1.Value = int.Parse(RGB[1]);
            trackBar_Blue1.Value = int.Parse(RGB[2]);

            groupBox1.BackColor = Color.FromArgb(trackBar_Red1.Value, trackBar_Green1.Value, trackBar_Blue1.Value);
            _parentForm.ChangeColor(Color.FromArgb(trackBar_Red1.Value, trackBar_Green1.Value, trackBar_Blue1.Value));
        }
    }
}
