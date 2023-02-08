using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorSimple
{
    public partial class Form1 : Form
    {
        private int _bitDeapth = 10;
        private double _leftOperand = 0;
        private double _rightOperand = 0;
        private double _result = 0;
        private string _symbol = "";

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(56, 56, 56);
            panel1.BackColor = Color.FromArgb(56, 56, 56);
            textBox_Result.BackColor = Color.FromArgb(56, 56, 56);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((sender as System.Windows.Forms.Button).Text == "0" && textBox_Result.Text != "0")
                textBox_Result.Text += "0";
            else if (textBox_Result.Text.Length < _bitDeapth)
                textBox_Result.Text += (sender as System.Windows.Forms.Button).Text;
            if(_symbol == "+" || _symbol == "-" || _symbol == "/" || _symbol == "*" || _symbol == "%")
                if (textBox_Result.Text.Length < _bitDeapth)
                    _rightOperand = double.Parse(textBox_Result.Text);
        }

        private void button_Symbol_Click(object sender, EventArgs e)
        {
            //_rightOperand = 0;
            if(textBox_Result.Text != "")
            {
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
            }
            _leftOperand = _result;
            textBox_Result.Text = _result.ToString();
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (!(textBox_Result.Text).Contains(','))
            {
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
    }
}
