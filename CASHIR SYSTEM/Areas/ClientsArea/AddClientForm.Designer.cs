namespace CASHIR_SYSTEM.Areas.Clients
{
    partial class AddClientForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.clientNametextbox = new System.Windows.Forms.TextBox();
            this.clientAddresstextbox = new System.Windows.Forms.TextBox();
            this.firstPhonetextbox = new System.Windows.Forms.TextBox();
            this.seceondPhoneTextbox = new System.Windows.Forms.TextBox();
            this.notstextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddeddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.minaOpacityAnimation1 = new Mina.UI_WinForm.MinaOpacityAnimation(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serviceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "بيانات العملاء";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientNametextbox
            // 
            this.clientNametextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientNametextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNametextbox.Location = new System.Drawing.Point(441, 73);
            this.clientNametextbox.Name = "clientNametextbox";
            this.clientNametextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientNametextbox.Size = new System.Drawing.Size(294, 28);
            this.clientNametextbox.TabIndex = 1;
            this.clientNametextbox.TextChanged += new System.EventHandler(this.clientNametextbox_TextChanged);
            // 
            // clientAddresstextbox
            // 
            this.clientAddresstextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientAddresstextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddresstextbox.Location = new System.Drawing.Point(441, 128);
            this.clientAddresstextbox.Multiline = true;
            this.clientAddresstextbox.Name = "clientAddresstextbox";
            this.clientAddresstextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientAddresstextbox.Size = new System.Drawing.Size(294, 28);
            this.clientAddresstextbox.TabIndex = 1;
            this.clientAddresstextbox.TextChanged += new System.EventHandler(this.clientAddresstextbox_TextChanged);
            // 
            // firstPhonetextbox
            // 
            this.firstPhonetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstPhonetextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPhonetextbox.Location = new System.Drawing.Point(12, 73);
            this.firstPhonetextbox.Name = "firstPhonetextbox";
            this.firstPhonetextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstPhonetextbox.Size = new System.Drawing.Size(294, 28);
            this.firstPhonetextbox.TabIndex = 1;
            this.firstPhonetextbox.TextChanged += new System.EventHandler(this.firstPhonetextbox_TextChanged);
            this.firstPhonetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstPhonetextbox_KeyPress);
            this.firstPhonetextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.firstPhonetextbox_KeyUp);
            // 
            // seceondPhoneTextbox
            // 
            this.seceondPhoneTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seceondPhoneTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seceondPhoneTextbox.Location = new System.Drawing.Point(12, 125);
            this.seceondPhoneTextbox.Name = "seceondPhoneTextbox";
            this.seceondPhoneTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seceondPhoneTextbox.Size = new System.Drawing.Size(294, 28);
            this.seceondPhoneTextbox.TabIndex = 1;
            this.seceondPhoneTextbox.TextChanged += new System.EventHandler(this.seceondPhoneTextbox_TextChanged);
            this.seceondPhoneTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seceondPhoneTextbox_KeyPress);
            // 
            // notstextbox
            // 
            this.notstextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notstextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notstextbox.Location = new System.Drawing.Point(10, 263);
            this.notstextbox.Multiline = true;
            this.notstextbox.Name = "notstextbox";
            this.notstextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notstextbox.Size = new System.Drawing.Size(294, 58);
            this.notstextbox.TabIndex = 1;
            this.notstextbox.TextChanged += new System.EventHandler(this.notstextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم العميل";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(757, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "عنوان العميل";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "خدمة التوصيل";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // serviceNumeric
            // 
            this.serviceNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceNumeric.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNumeric.Location = new System.Drawing.Point(441, 194);
            this.serviceNumeric.Name = "serviceNumeric";
            this.serviceNumeric.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serviceNumeric.Size = new System.Drawing.Size(294, 28);
            this.serviceNumeric.TabIndex = 3;
            this.serviceNumeric.ValueChanged += new System.EventHandler(this.serviceNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "التليفون الاول";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "التليفون الثانى";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "تاريخ الاضافة";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "ملاحظات";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // AddeddateTimePicker
            // 
            this.AddeddateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddeddateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddeddateTimePicker.Location = new System.Drawing.Point(12, 193);
            this.AddeddateTimePicker.Name = "AddeddateTimePicker";
            this.AddeddateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddeddateTimePicker.Size = new System.Drawing.Size(292, 24);
            this.AddeddateTimePicker.TabIndex = 4;
            this.AddeddateTimePicker.ValueChanged += new System.EventHandler(this.AddeddateTimePicker_ValueChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(441, 271);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(294, 50);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "اضافة عميل";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // minaOpacityAnimation1
            // 
            this.minaOpacityAnimation1.Duration = 200;
            this.minaOpacityAnimation1.TargetControl = this;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 366);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddeddateTimePicker);
            this.Controls.Add(this.serviceNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.notstextbox);
            this.Controls.Add(this.seceondPhoneTextbox);
            this.Controls.Add(this.firstPhonetextbox);
            this.Controls.Add(this.clientAddresstextbox);
            this.Controls.Add(this.clientNametextbox);
            this.Controls.Add(this.label1);
            this.Name = "AddClientForm";
            this.Opacity = 0D;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافة عميل جديد";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientNametextbox;
        private System.Windows.Forms.TextBox clientAddresstextbox;
        private System.Windows.Forms.TextBox firstPhonetextbox;
        private System.Windows.Forms.TextBox seceondPhoneTextbox;
        private System.Windows.Forms.TextBox notstextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown serviceNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker AddeddateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private Mina.UI_WinForm.MinaOpacityAnimation minaOpacityAnimation1;
    }
}