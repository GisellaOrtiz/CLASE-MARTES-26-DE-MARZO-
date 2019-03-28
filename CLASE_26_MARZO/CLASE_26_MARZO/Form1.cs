using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPERACONES;

namespace CLASE_26_MARZO
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valorA_Click(object sender, EventArgs e)
        {

        }

        private void valorB_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SUMAR_Click(object sender, EventArgs e)
        {
            SUMA obj1 = new SUMA();
            obj1.V1 = double.Parse(textBox1.Text);
            obj1.V2 = double.Parse(textBox2.Text);
            label3.Text = obj1.RealizaSUMA().ToString();
        }

        private void RESTA_Click(object sender, EventArgs e)
        {
            RESTA obj2 = new RESTA();
            obj2.R1 = double.Parse(textBox1.Text);
            obj2.R2 = double.Parse(textBox2.Text);
            label3.Text = obj2.RealizaRESTA().ToString();
        }

        private void MULTI_Click(object sender, EventArgs e)
        {
            MULTI obj3 = new MULTI();
            obj3.Mult1 = double.Parse(textBox1.Text);
            obj3.Mult2 = double.Parse(textBox2.Text);
            label3.Text = obj3.RealizaMULTIPLICACION().ToString();
        }

        private void DIVIDIR_Click(object sender, EventArgs e)
        {
            DIVISION obj4 = new DIVISION();
            obj4.Div1 = double.Parse(textBox1.Text);
            obj4.Div2 = double.Parse(textBox2.Text);
            label3.Text = obj4.RealizaDIVISION().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
