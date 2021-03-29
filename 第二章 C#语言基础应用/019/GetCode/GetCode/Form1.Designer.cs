namespace GetCode
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_chr = new System.Windows.Forms.TextBox();
            this.btn_Get = new System.Windows.Forms.Button();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入一个汉字字符：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_chr
            // 
            this.txt_chr.Location = new System.Drawing.Point(221, 63);
            this.txt_chr.Name = "txt_chr";
            this.txt_chr.Size = new System.Drawing.Size(100, 21);
            this.txt_chr.TabIndex = 1;
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(84, 136);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(101, 23);
            this.btn_Get.TabIndex = 2;
            this.btn_Get.Text = "获取汉字编码值";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(221, 136);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 21);
            this.txt_Num.TabIndex = 3;
            this.txt_Num.TextChanged += new System.EventHandler(this.txt_Num_TextChanged);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 214);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.txt_chr);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_chr;
        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.TextBox txt_Num;
    }
}

