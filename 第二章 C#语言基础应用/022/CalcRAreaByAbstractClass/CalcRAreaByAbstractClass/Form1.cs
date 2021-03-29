using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcRAreaByAbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte bt_One, bt_Two;
            if (byte.TryParse(textBox1.Text, out bt_One) && byte.TryParse(textBox2.Text, out bt_Two))
            {
                try
                {
                    checked { bt_One += bt_Two; }
                    textBox3.Text = bt_One.ToString();
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, "出错！");
                }
            }
            else
            {
                MessageBox.Show("请输入255以内的数字！");
            }
        }
    }
}
