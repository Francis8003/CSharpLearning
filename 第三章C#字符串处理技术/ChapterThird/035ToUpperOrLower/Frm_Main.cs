using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _035ToUpperOrLower
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (rbtn_upper.Checked)
            {
                txt_changed.Text = txt_string.Text.ToUpper();
            }
            else
            {
                txt_changed.Text = txt_string.Text.ToLower();
            }
        }
        private void txt_string_MouseClick(object sender, EventArgs e)
        {
            if (txt_string.Text == "          请输入字符串")
            {
                txt_string.Text = string.Empty;
            }
        }
    }
}
