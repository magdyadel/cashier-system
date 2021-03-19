namespace CASHIR_SYSTEM.Areas.Orders
{
    partial class Tables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteTBL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTBL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fpnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTBL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddTBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 106);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteTBL
            // 
            this.btnDeleteTBL.Location = new System.Drawing.Point(113, 45);
            this.btnDeleteTBL.Name = "btnDeleteTBL";
            this.btnDeleteTBL.Size = new System.Drawing.Size(221, 52);
            this.btnDeleteTBL.TabIndex = 2;
            this.btnDeleteTBL.Text = "حذف طاولة";
            this.btnDeleteTBL.UseVisualStyleBackColor = true;
            this.btnDeleteTBL.Click += new System.EventHandler(this.btnDeleteTBL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "الطاولات";
            // 
            // btnAddTBL
            // 
            this.btnAddTBL.Location = new System.Drawing.Point(466, 45);
            this.btnAddTBL.Name = "btnAddTBL";
            this.btnAddTBL.Size = new System.Drawing.Size(221, 52);
            this.btnAddTBL.TabIndex = 0;
            this.btnAddTBL.Text = "أضافة طاولة جديدة";
            this.btnAddTBL.UseVisualStyleBackColor = true;
            this.btnAddTBL.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fpnlTables);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(57, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 399);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الطاولات";
            // 
            // fpnlTables
            // 
            this.fpnlTables.AutoScroll = true;
            this.fpnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlTables.Location = new System.Drawing.Point(3, 21);
            this.fpnlTables.Name = "fpnlTables";
            this.fpnlTables.Size = new System.Drawing.Size(685, 375);
            this.fpnlTables.TabIndex = 0;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Tables";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tables";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel fpnlTables;
        private System.Windows.Forms.Button btnAddTBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTBL;
    }
}