using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CalculatorSimple
{
    public partial class Form1 : Form
    {
        private Configcs _configcs = null;
        private int _bitDeapth = 10;
        private double _leftOperand = 0;
        private double _rightOperand = 0;
        private double _result = 0;
        private string _symbol = "";
        //private string _tmpSymbol = "";
        private bool _isPI = false;
        private bool _isE = false;
        //private bool _check = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int R, G, B;
            R = this.panel1.BackColor.R;
            G = this.panel1.BackColor.G;
            B = this.panel1.BackColor.B;

            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configFile.AppSettings.Settings.Remove("ColorPanel");
            configFile.AppSettings.Settings.Add("ColorPanel", $"{R},{G},{B}");

            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int R, G, B;
            string[] RGB = (ConfigurationManager.AppSettings["ColorPanel"]).Split(',');
            R = int.Parse(RGB[0]);
            G = int.Parse(RGB[1]);
            B = int.Parse(RGB[2]);

            this.BackColor = Color.FromArgb(R, G, B);
            panel1.BackColor = Color.FromArgb(R, G, B);
            panel2.BackColor = Color.FromArgb(R, G, B);
            textBox_Result.BackColor = Color.FromArgb(R, G, B);
        }

        private void button_Click(object sender, EventArgs e)
        {
            //if (_result != 0 && _tmpSymbol != _symbol)
            //{
            //    textBox_Result.Clear();
            //    _result = 0;
            //    //if (_leftOperand != 0 /*&& _check == true*/)
            //    //    _leftOperand = 0;
            //    _check = true;
            //}
            if ((sender as System.Windows.Forms.Button).Text == "0" && textBox_Result.Text != "0" && !textBox_Result.Text.Contains("3,14159") && !textBox_Result.Text.Contains("π") && !textBox_Result.Text.Contains("2,71828") && !textBox_Result.Text.Contains("е"))
                textBox_Result.Text += "0";
            else if((sender as System.Windows.Forms.Button).Text == "π" && _isPI == false)
            {
                textBox_Result.Clear();
                textBox_Result.Text += "3,14159";
                _isPI = true;
                _isE = false;
            }
            else if ((sender as System.Windows.Forms.Button).Text == "е" && _isE == false)
            {
                textBox_Result.Clear();
                textBox_Result.Text += "2,71828";
                _isE = true;
                _isPI = false;
            }
            else if (textBox_Result.Text.Length < _bitDeapth && !textBox_Result.Text.Contains("3,14159") && !textBox_Result.Text.Contains("π") && !textBox_Result.Text.Contains("2,71828") && !textBox_Result.Text.Contains("е"))
                textBox_Result.Text += (sender as System.Windows.Forms.Button).Text;
            if(_symbol != "")
            {
                if (textBox_Result.Text.Length < _bitDeapth)
                    _rightOperand = double.Parse(textBox_Result.Text);
                //else if(textBox_Result.Text.Length < _bitDeapth && _check == true)
                //    _leftOperand = double.Parse(textBox_Result.Text);
            }
        }

        private void button_Symbol_Click(object sender, EventArgs e)
        {
            if(textBox_Result.Text != "")
            {
                
                _isPI = false;
                _isE = false;
                _leftOperand = double.Parse(textBox_Result.Text);
                textBox_Result.Clear();
                _symbol = (sender as System.Windows.Forms.Button).Text;
            }
        }

        private void button_Ravno_Click(object sender, EventArgs e)
        {
           
            switch(_symbol) 
            {
                case "+":{ _result = _leftOperand + _rightOperand; break; }
                case "-":{ _result = _leftOperand - _rightOperand; break; }
                case "/":{ _result = _leftOperand / _rightOperand; break; }
                case "*":{ _result = _leftOperand * _rightOperand; break; }
                case "%": { _result = _leftOperand * _rightOperand / 100; break; }
                case "xⁿ": { _result = Math.Pow(_leftOperand, _rightOperand); break; }
                case "mod": {
                        if (_leftOperand < 0)
                            while (_leftOperand < 0)
                                _leftOperand += _rightOperand;
                        _result = _leftOperand % _rightOperand; break;
                    }
            }
            _isPI = false;
            _isE = false;
            _leftOperand = _result;
            textBox_Result.Text = _result.ToString();
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (!(textBox_Result.Text).Contains(','))
            {
                if (_result != 0)
                {
                    textBox_Result.Text = "0";
                    _result = 0;
                }
                textBox_Result.Text += ",";
            }
        }

        private void button_PlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "0" && textBox_Result.Text != "")
            {
                if (textBox_Result.Text[0] != '-')
                    textBox_Result.Text = '-' + textBox_Result.Text;
                else
                    textBox_Result.Text = textBox_Result.Text.Replace("-", "");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            _leftOperand = 0;
            _rightOperand = 0;
            _result = 0;
            _symbol = "";
            _isPI = false;
            _isE = false;
        }

        private void button_1x_Pow_Sqrt_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text != "")
            {
                _leftOperand = double.Parse(textBox_Result.Text);
                textBox_Result.Clear();
                _symbol = (sender as System.Windows.Forms.Button).Text;
                switch (_symbol)
                {
                    case "1/x": { _leftOperand = 1 / _leftOperand; break; }
                    case "x²": { _leftOperand = Math.Pow(_leftOperand, 2); break; }
                    case "√": { _leftOperand = Math.Sqrt(_leftOperand); break; }
                    case "log": { _leftOperand = Math.Log(_leftOperand); break; }
                }
                textBox_Result.Text = _leftOperand.ToString();
            }
        }

        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if(textBox_Result.Text.Length > 0)
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1, 1);
                if(textBox_Result.Text == "-")
                    textBox_Result.Text = "";
            }
        }

        private void оПрограміToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProgram = new AboutProgram();
            aboutProgram.ShowDialog();
        }

        private void конфігToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_configcs == null)
            {
                _configcs= new Configcs(this);
                _configcs.StartPosition = FormStartPosition.Manual;
            }
            _configcs.Location = new Point(this.Location.X + this.Size.Width - 12, this.Location.Y);
            _configcs.Show();
        }
        public void ChangeColor(Color color)
        {
            this.panel1.BackColor = color;
            this.panel2.BackColor = color;
            this.BackColor = color;
            textBox_Result.BackColor = color;
        }

        private void стандартнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            _leftOperand = 0;
            _rightOperand = 0;
            _result = 0;
            _symbol = "";
            _isPI = false;
            _isE = false;

            стандартнийToolStripMenuItem.Checked = true;
            інженернийToolStripMenuItem.Checked = false;

            panel1.Location = new Point(0, 95);
            panel2.Location = new Point(390, 95);
        }

        private void інженернийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            _leftOperand = 0;
            _rightOperand = 0;
            _result = 0;
            _symbol = "";
            _isPI = false;
            _isE = false;

            стандартнийToolStripMenuItem.Checked = false;
            інженернийToolStripMenuItem.Checked = true;

            panel2.Location = new Point(0, 95);
            panel1.Location = new Point(390, 95);
        }
    }
}
