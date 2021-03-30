using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Get_Click(object sender, EventArgs e)
        {
            if (rbtn__obj.Checked)
            {
                using (FileStream p_Filestream = new FileStream(@"d:\log.txt", FileMode.Create))
                {
                    object p_object = p_Filestream as object;
                    if (p_object != null)
                    {
                        MessageBox.Show("转换为object成功", "Tip");
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Tip");
                    }
                }

            }
            if (rbtn_stream.Checked)
            {
                using (FileStream P_fileStream = new FileStream(@"d:\log.txt", FileMode.Create))
                {
                    object P_obj = P_fileStream;
                    Stream p_Stream = P_obj as Stream;
                    if (p_Stream != null)
                    {
                        MessageBox.Show("success", "Tip");
                    }
                    else
                    {
                        MessageBox.Show("Failed", "Tip");
                    }
                }
            }
        }
    }
}
