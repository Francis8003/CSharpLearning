using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            ushort P_usint_temp;
            if (ushort.TryParse(txt_year.Text, out P_usint_temp))
            {
                MessageBox.Show(
                    (P_usint_temp % 4 == 0 && P_usint_temp % 100 != 0)
                    || P_usint_temp % 4 == 0 ?
                    "输入的是闰年！" : "输入的不是闰年！", "Tip"
                    );

            }
            else
            {
                MessageBox.Show("请输入正确的数值！", "Tip");
            }
        }
    }
}
