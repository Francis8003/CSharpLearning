using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Type type = typeof(System.Int32);
            foreach (MethodInfo method in type.GetMethods())
            {
                richTextBox1.AppendText("方法名字" + method.Name + Environment.NewLine);
                foreach (ParameterInfo parameter in method.GetParameters())
                {
                    richTextBox1.AppendText("参数" + parameter + Environment.NewLine);
                }
            }
        }
    }
}
