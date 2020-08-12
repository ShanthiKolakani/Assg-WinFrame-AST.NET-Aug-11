using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConAssgLib;

namespace WinAssg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArthmOpp obj;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new ArthmOpp();
            obj.num1 = Convert.ToInt32(txtnum1.Text);
            obj.num2 = Convert.ToInt32(txtnum2.Text);
            lblResult.Text = obj.Subtract().ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj = new ArthmOpp();
            obj.num1 = Convert.ToInt32(txtnum1.Text);
            obj.num2 = Convert.ToInt32(txtnum2.Text);
            lblResult.Text = obj.Add().ToString();

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            obj = new ArthmOpp();
            obj.num1 = Convert.ToInt32(txtnum1.Text);
            obj.num2 = Convert.ToInt32(txtnum2.Text);

            lblResult.Text = obj.Multiply().ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            obj = new ArthmOpp();
            obj.num1 = Convert.ToInt32(txtnum1.Text);
            obj.num2 = Convert.ToInt32(txtnum2.Text);
            lblResult.Text = obj.Divide().ToString();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            obj = new ArthmOpp();
            obj.num1 = Convert.ToInt32(txtnum1.Text);
            obj.num2 = Convert.ToInt32(txtnum2.Text);
            lblResult.Text = obj.Modulo().ToString();
        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void lblnum2_Click(object sender, EventArgs e)
        {

        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
