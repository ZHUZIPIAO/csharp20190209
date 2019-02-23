using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddrBook
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {

        }

        private void btnperiod_Click(object sender, EventArgs e)
        {

        }

        private void btnzero_Click(object sender, EventArgs e)
        {

        }

        private void btndivide_Click(object sender, EventArgs e)
        {

        }

        private void btnnine_Click(object sender, EventArgs e)
        {

        }

        private void btneight_Click(object sender, EventArgs e)
        {

        }

        private void btnseven_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnsix_Click(object sender, EventArgs e)
        {

        }

        private void btfive_Click(object sender, EventArgs e)
        {

        }

        private void btnfour_Click(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {

        }

        private void btnthree_Click(object sender, EventArgs e)
        {

        }

        private void btntwo_Click(object sender, EventArgs e)
        {

        }

        private void btnone_Click(object sender, EventArgs e)
        {

        }

        private void btnminus_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if(num1==0 && textBox1.TextLength > 0)
            {
                num1 = 0; textBox1.Clear();
            }else if(num1>0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
            }
        }



        private void btnroot_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
