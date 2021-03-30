using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Frm_Main : Form
    {
        private List<double> G_list_value = new List<double>();

        // 是否刚刚按下+号
        private bool G_bl_add = false;

        // 是否刚刚按下=号
        private bool G_bl_value = false;

        // 防止连续按+号
        private bool G_bl_key = false;


        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length<9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "0";
                G_bl_key = false;
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "1";
                G_bl_key = false;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "2";
                G_bl_key = false;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "3";
                G_bl_key = false;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "4";
                G_bl_key = false;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "5";
                G_bl_key = false;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "6";
                G_bl_key = false;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "7";
                G_bl_key = false;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "8";
                G_bl_key = false;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_value.Text.Length < 9)
            {
                if (G_bl_add)
                {
                    txt_value.Clear();
                    G_bl_add = false;
                }
                txt_value.Text += "9";
                G_bl_key = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            G_list_value.Clear();
            lb_express.Text = GetString();
            txt_value.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (G_bl_value)
            {
                G_bl_value = false;
                G_bl_key = true;
            }
            else
            {
                if(!G_bl_key)
                {
                    G_list_value.Add(double.Parse(txt_value.Text));
                    GetValue();
                    lb_express.Text = GetString();
                    G_bl_add = true;
                    G_bl_key = true;
                }
            }
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            if(!G_bl_key)
            {
                if (!G_bl_value)
                {
                    G_list_value.Add(double.Parse(txt_value.Text));
                    GetValue();
                    lb_express.Text = GetString();
                    G_bl_add = true;
                    G_bl_value = true;
                }
            }
        }

        private void bl_express_Click(object sender, EventArgs e)
        {

        }
        void GetValue()
        {
            double P_dbl_temp = 0;
            foreach (double d in G_list_value)
            {
                P_dbl_temp += d;
            }
            txt_value.Text = P_dbl_temp.ToString();
        }

        string GetString()
        {
            string P_str_temp = string.Empty;
            for (int i = 0; i < G_list_value.Count; i++)
            {
                if (i!=0)
                {
                    P_str_temp += "+" + G_list_value[i].ToString();
                }
                else
                {
                    P_str_temp = G_list_value[i].ToString();
                }
                
            }
            return P_str_temp;
        }
    }
}
