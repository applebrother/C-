﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first_WINFORM
{
    public partial class my : Form
    {
        public my()
        {
            InitializeComponent();
        }
        
        
      

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form2 newform = new Form2();
            newform.Show();*/ 
            //显示FORM2
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
            MessageBox.Show("您已经点击了开始按钮");//弹出提示框
            


        }
        
    }
}