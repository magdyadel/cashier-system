namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    partial class payIfUserExists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PaiedMonyTextBox = new System.Windows.Forms.TextBox();
            this.ReaminngMonyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Allmonytextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaiedMonyTextBox
            // 
            this.PaiedMonyTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaiedMonyTextBox.Location = new System.Drawing.Point(12, 81);
            this.PaiedMonyTextBox.Name = "PaiedMonyTextBox";
            this.PaiedMonyTextBox.Size = new System.Drawing.Size(177, 28);
            this.PaiedMonyTextBox.TabIndex = 0;
            this.PaiedMonyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.PaiedMonyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaiedMonyTextBox_KeyUp);
            // 
            // ReaminngMonyTextBox
            // 
            this.ReaminngMonyTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReaminngMonyTextBox.Location = new System.Drawing.Point(12, 140);
            this.ReaminngMonyTextBox.Name = "ReaminngMonyTextBox";
            this.ReaminngMonyTextBox.Size = new System.Drawing.Size(177, 28);
            this.ReaminngMonyTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "المبلغ المدفوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "الباقى";
            // 
            // Allmonytextbox
            // 
            this.Allmonytextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allmonytextbox.Location = new System.Drawing.Point(12, 22);
            this.Allmonytextbox.Name = "Allmonytextbox";
            this.Allmonytextbox.Size = new System.Drawing.Size(177, 28);
            this.Allmonytextbox.TabIndex = 0;
            this.Allmonytextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "مبلغ الطلب";
            // 
            // payIfUserExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReaminngMonyTextBox);
            this.Controls.Add(this.Allmonytextbox);
            this.Controls.Add(this.PaiedMonyTextBox);
            this.Name = "payIfUserExists";
            this.Text = "payIfUserExists";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.payIfUserExists_FormClosed);
            this.Load += new System.EventHandler(this.payIfUserExists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaiedMonyTextBox;
        private System.Windows.Forms.TextBox ReaminngMonyTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Allmonytextbox;
        private System.Windows.Forms.Label label3;
    }
}