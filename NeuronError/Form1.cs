using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuronError
{
    public partial class Form1 : Form
    {
        public static double ans,i1,i2;
        public Form1(double ii1,double ii2,double x)
        {
            i1 = ii1;
            i2 = ii2;
            ans = x;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = Convert.ToString(ans);
            textBoxi0.Text = Convert.ToString(i1);
            textBoxi1.Text = Convert.ToString(i2);
            textBox1.Text = ".01";
            textBox2.Text = ".99";


        }
    }
}
