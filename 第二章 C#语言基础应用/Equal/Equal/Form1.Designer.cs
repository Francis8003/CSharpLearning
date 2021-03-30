namespace Equal
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
            this.btn_Get = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_target1 = new System.Windows.Forms.RadioButton();
            this.rbtn_target2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_class2 = new System.Windows.Forms.RadioButton();
            this.rbtn_class1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(194, 174);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(109, 23);
            this.btn_Get.TabIndex = 0;
            this.btn_Get.Text = "查看是否兼容";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_target2);
            this.groupBox1.Controls.Add(this.rbtn_target1);
            this.groupBox1.Location = new System.Drawing.Point(25, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "对象";
            // 
            // rbtn_target1
            // 
            this.rbtn_target1.AutoSize = true;
            this.rbtn_target1.Location = new System.Drawing.Point(45, 20);
            this.rbtn_target1.Name = "rbtn_target1";
            this.rbtn_target1.Size = new System.Drawing.Size(83, 16);
            this.rbtn_target1.TabIndex = 0;
            this.rbtn_target1.TabStop = true;
            this.rbtn_target1.Text = "字符串对象";
            this.rbtn_target1.UseVisualStyleBackColor = true;
            // 
            // rbtn_target2
            // 
            this.rbtn_target2.AutoSize = true;
            this.rbtn_target2.Location = new System.Drawing.Point(45, 61);
            this.rbtn_target2.Name = "rbtn_target2";
            this.rbtn_target2.Size = new System.Drawing.Size(71, 16);
            this.rbtn_target2.TabIndex = 1;
            this.rbtn_target2.TabStop = true;
            this.rbtn_target2.Text = "文件对象";
            this.rbtn_target2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_class2);
            this.groupBox2.Controls.Add(this.rbtn_class1);
            this.groupBox2.Location = new System.Drawing.Point(276, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "类型";
            // 
            // rbtn_class2
            // 
            this.rbtn_class2.AutoSize = true;
            this.rbtn_class2.Location = new System.Drawing.Point(45, 61);
            this.rbtn_class2.Name = "rbtn_class2";
            this.rbtn_class2.Size = new System.Drawing.Size(95, 16);
            this.rbtn_class2.TabIndex = 1;
            this.rbtn_class2.TabStop = true;
            this.rbtn_class2.Text = "FileInfo类型";
            this.rbtn_class2.UseVisualStyleBackColor = true;
            // 
            // rbtn_class1
            // 
            this.rbtn_class1.AutoSize = true;
            this.rbtn_class1.Location = new System.Drawing.Point(45, 20);
            this.rbtn_class1.Name = "rbtn_class1";
            this.rbtn_class1.Size = new System.Drawing.Size(83, 16);
            this.rbtn_class1.TabIndex = 0;
            this.rbtn_class1.TabStop = true;
            this.rbtn_class1.Text = "string类型";
            this.rbtn_class1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Get);
            this.Name = "Form1";
            this.Text = "对象";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_target2;
        private System.Windows.Forms.RadioButton rbtn_target1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_class2;
        private System.Windows.Forms.RadioButton rbtn_class1;
    }
}

