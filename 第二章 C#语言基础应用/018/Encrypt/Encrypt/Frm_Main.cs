using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt
{
    public partial class Frm_Main : Form
    {

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            int P_int_Num, P_int_Key;
            if (int.TryParse(txt_Key.Text, out P_int_Key) && int.TryParse(txt_Num.Text, out P_int_Num))
            {
                txt_Encrypt.Text = (P_int_Key ^ P_int_Num).ToString();
            }
            else
            {
                MessageBox.Show("请输入数值", "出现错误");
            }
        }

        private void Revert_Click(object sender, EventArgs e)
        {
            int P_int_Key, P_int_Encrypt;
            if (int.TryParse(txt_Encrypt.Text, out P_int_Key)//判断输入是否是数值
                && int.TryParse(txt_Key.Text, out P_int_Encrypt))
            {
                txt_Revert.Text = (P_int_Encrypt ^ P_int_Key).ToString();
            }
            else
            {
                MessageBox.Show("请输入数值", "出现错误");
            }
        }
    }
}
