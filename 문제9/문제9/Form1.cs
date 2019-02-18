using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace 문제9
{

    public partial class Form1 : Form
    {
        private delegate void Mydelegate(TextBox textbox, int j);
        private  Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => RandomNum(textBox1)); t1.Start();
            Thread t2 = new Thread(() => RandomNum(textBox2)); t2.Start();
            Thread t3 = new Thread(() => RandomNum(textBox3)); t3.Start();
            Thread t4 = new Thread(() => RandomNum(textBox4)); t4.Start();
            Thread t5 = new Thread(() => RandomNum(textBox5)); t5.Start();
            Thread t6 = new Thread(() => RandomNum(textBox6)); t6.Start();
        }
        
        private void RandomNum(TextBox textbox)
        {
           
            int n = r.Next(1, 46);
            Mydelegate mydelegate = (TextBox t, int j) => t.Text = j.ToString();
            if (textbox.InvokeRequired)
            {
               
                this.Invoke(mydelegate, textbox, n);

            }
            else
            {
                textbox.Text = n.ToString();
            }
        }
    }
}
