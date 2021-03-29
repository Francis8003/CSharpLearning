using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_true_Click(object sender, EventArgs e)
        {
            using (Test t = new Test())
            {
                MessageBox.Show("先执行资源前的方法，方法执行结束后，释放掉资源");
            }
        }
    }
    public class Test : IDisposable
    {
        public void Dispose()
        {
            MessageBox.Show("已经执行test对象的Disposable方法", "tip");
        }
    }

}
