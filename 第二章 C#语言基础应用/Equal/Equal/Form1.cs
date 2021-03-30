using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            object P_obj = rbtn_target1.Checked ?
                (object)"C#" : new System.IO.FileInfo(@"d:\");
            if (rbtn_class1.Checked)
            {
                if (P_obj is System.String)
                {
                    MessageBox.Show("兼容");
                }
                else
                {
                    MessageBox.Show("不兼容");
                }
            }
            if (rbtn_class2.Checked)
            {
                if (P_obj is System.IO.FileInfo)
                {
                    MessageBox.Show("兼容");
                }
                else
                {
                    MessageBox.Show("不兼容");
                }
            }
        }
    }
}
