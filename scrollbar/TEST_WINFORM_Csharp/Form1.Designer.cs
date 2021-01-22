namespace TEST_WINFORM_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userControl1 = new TEST_WINFORM_Csharp.UserControl1();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "50";
            // 
            // pValueTextBox
            // 
            this.pValueTextBox.Location = new System.Drawing.Point(102, 114);
            this.pValueTextBox.Name = "pValueTextBox";
            this.pValueTextBox.Size = new System.Drawing.Size(230, 21);
            this.pValueTextBox.TabIndex = 2;
            this.pValueTextBox.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "sValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "pValue";
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(61, 35);
            this.userControl1.MaxValue = 100;
            this.userControl1.Name = "userControl1";
            this.userControl1.pV = 50;
            this.userControl1.Size = new System.Drawing.Size(300, 25);
            this.userControl1.TabIndex = 0;
            this.userControl1.Value = 50;
            this.userControl1.ValueChangeEvent += new System.EventHandler(this.userControl1_ValueChangeEvent);
            this.userControl1.Load += new System.EventHandler(this.Form1_Load);
            this.userControl1.Leave += new System.EventHandler(this.userControl1_ValueChangeEvent);
            this.userControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userControl1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 147);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pValueTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

