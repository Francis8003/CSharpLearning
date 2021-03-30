namespace Transform
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn__obj = new System.Windows.Forms.RadioButton();
            this.rbtn_stream = new System.Windows.Forms.RadioButton();
            this.rbtn_string = new System.Windows.Forms.RadioButton();
            this.btn_Get = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "转换为什么类型";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_string);
            this.groupBox1.Controls.Add(this.rbtn_stream);
            this.groupBox1.Controls.Add(this.rbtn__obj);
            this.groupBox1.Location = new System.Drawing.Point(211, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rbtn__obj
            // 
            this.rbtn__obj.AutoSize = true;
            this.rbtn__obj.Location = new System.Drawing.Point(27, 32);
            this.rbtn__obj.Name = "rbtn__obj";
            this.rbtn__obj.Size = new System.Drawing.Size(59, 16);
            this.rbtn__obj.TabIndex = 0;
            this.rbtn__obj.TabStop = true;
            this.rbtn__obj.Text = "Object";
            this.rbtn__obj.UseVisualStyleBackColor = true;
            // 
            // rbtn_stream
            // 
            this.rbtn_stream.AutoSize = true;
            this.rbtn_stream.Location = new System.Drawing.Point(27, 67);
            this.rbtn_stream.Name = "rbtn_stream";
            this.rbtn_stream.Size = new System.Drawing.Size(59, 16);
            this.rbtn_stream.TabIndex = 1;
            this.rbtn_stream.TabStop = true;
            this.rbtn_stream.Text = "Stream";
            this.rbtn_stream.UseVisualStyleBackColor = true;
            // 
            // rbtn_string
            // 
            this.rbtn_string.AutoSize = true;
            this.rbtn_string.Location = new System.Drawing.Point(27, 100);
            this.rbtn_string.Name = "rbtn_string";
            this.rbtn_string.Size = new System.Drawing.Size(59, 16);
            this.rbtn_string.TabIndex = 2;
            this.rbtn_string.TabStop = true;
            this.rbtn_string.Text = "String";
            this.rbtn_string.UseVisualStyleBackColor = true;
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(153, 185);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 2;
            this.btn_Get.Text = "类型转换";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 235);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_string;
        private System.Windows.Forms.RadioButton rbtn_stream;
        private System.Windows.Forms.RadioButton rbtn__obj;
        private System.Windows.Forms.Button btn_Get;
    }
}

