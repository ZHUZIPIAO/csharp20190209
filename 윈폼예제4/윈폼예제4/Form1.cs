﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼예제4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Model Windows";
            f.Width = 200;
            f.Height = 100;
            f.BackColor = Color.Blue;

            f.ShowDialog();
        }

        private void btnModless_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Modeless Windows";
            f.Width = 200;
            f.Height = 100;
            f.BackColor = Color.Black;
            //모달창이 아닌 윈도우를 연다.
            f.Show();

        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오라클자바커뮤니티", "메시지박스", MessageBoxButtons.OK,
 MessageBoxIcon.Exclamation); //경고창
        }
    }
}
