namespace IfThenElse
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
            this.rbt_true = new System.Windows.Forms.RadioButton();
            this.rbt_false = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "是否业务花销";
            // 
            // rbt_true
            // 
            this.rbt_true.AutoSize = true;
            this.rbt_true.Location = new System.Drawing.Point(145, 43);
            this.rbt_true.Name = "rbt_true";
            this.rbt_true.Size = new System.Drawing.Size(35, 16);
            this.rbt_true.TabIndex = 1;
            this.rbt_true.TabStop = true;
            this.rbt_true.Text = "是";
            this.rbt_true.UseVisualStyleBackColor = true;
            // 
            // rbt_false
            // 
            this.rbt_false.AutoSize = true;
            this.rbt_false.Location = new System.Drawing.Point(223, 43);
            this.rbt_false.Name = "rbt_false";
            this.rbt_false.Size = new System.Drawing.Size(35, 16);
            this.rbt_false.TabIndex = 2;
            this.rbt_false.TabStop = true;
            this.rbt_false.Text = "否";
            this.rbt_false.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "报销";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbt_false);
            this.Controls.Add(this.rbt_true);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbt_true;
        private System.Windows.Forms.RadioButton rbt_false;
        private System.Windows.Forms.Button button1;
    }
}

