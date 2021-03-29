using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetCode
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            try
            {
                char chr = txt_chr.Text[0];
                byte[] gb2312_bt = Encoding.GetEncoding("gb2312").GetBytes(new char[] { chr });
                int n = (int)gb2312_bt[0] << 8;
                n += (int)gb2312_bt[1];
                txt_Num.Text = n.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请输入汉字字符！", "出现错误！");
            }
        }

        private void txt_Num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
