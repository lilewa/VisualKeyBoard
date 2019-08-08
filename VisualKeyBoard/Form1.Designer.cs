namespace VisualKeyBoard
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.keyBoardTextBox1 = new VisualKeyBoard.KeyBoardTextBox();
            this.keyBoardTextBox2 = new VisualKeyBoard.KeyBoardTextBox();
            this.SuspendLayout();
            // 
            // keyBoardTextBox1
            // 
            this.keyBoardTextBox1.Location = new System.Drawing.Point(288, 331);
            this.keyBoardTextBox1.Name = "keyBoardTextBox1";
            this.keyBoardTextBox1.Size = new System.Drawing.Size(100, 21);
            this.keyBoardTextBox1.TabIndex = 0;
            this.keyBoardTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyBoardTextBox1_KeyDown);
            // 
            // keyBoardTextBox2
            // 
            this.keyBoardTextBox2.Location = new System.Drawing.Point(95, 38);
            this.keyBoardTextBox2.Name = "keyBoardTextBox2";
            this.keyBoardTextBox2.Size = new System.Drawing.Size(100, 21);
            this.keyBoardTextBox2.TabIndex = 0;
            this.keyBoardTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyBoardTextBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 407);
            this.Controls.Add(this.keyBoardTextBox2);
            this.Controls.Add(this.keyBoardTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyBoardTextBox keyBoardTextBox1;
        private KeyBoardTextBox keyBoardTextBox2;
    }
}

