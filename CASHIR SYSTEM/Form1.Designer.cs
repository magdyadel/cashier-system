namespace CASHIR_SYSTEM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minaPaginationPanel1 = new Mina.UI_WinForm.MinaPaginationPanel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // minaPaginationPanel1
            // 
            this.minaPaginationPanel1.CheckedBackColor = System.Drawing.Color.DeepSkyBlue;
            this.minaPaginationPanel1.CheckedForeColor = System.Drawing.Color.White;
            this.minaPaginationPanel1.CurrentForm = null;
            this.minaPaginationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minaPaginationPanel1.EnableNavBar = true;
            this.minaPaginationPanel1.Location = new System.Drawing.Point(0, 0);
            this.minaPaginationPanel1.Name = "minaPaginationPanel1";
            this.minaPaginationPanel1.NavBarBackColor = System.Drawing.SystemColors.Control;
            this.minaPaginationPanel1.Size = new System.Drawing.Size(800, 450);
            this.minaPaginationPanel1.TabIndex = 0;
            // 
            // minaPaginationPanel1.toolStrip1
            // 
            this.minaPaginationPanel1.toolStrip.AutoSize = false;
            this.minaPaginationPanel1.toolStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.minaPaginationPanel1.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.minaPaginationPanel1.toolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minaPaginationPanel1.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.minaPaginationPanel1.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.minaPaginationPanel1.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.minaPaginationPanel1.toolStrip.Location = new System.Drawing.Point(669, 0);
            this.minaPaginationPanel1.toolStrip.Name = "toolStrip1";
            this.minaPaginationPanel1.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.minaPaginationPanel1.toolStrip.Size = new System.Drawing.Size(131, 450);
            this.minaPaginationPanel1.toolStrip.TabIndex = 0;
            this.minaPaginationPanel1.toolStrip.Text = "toolStrip1";
            this.minaPaginationPanel1.UncheckedForeColor = System.Drawing.Color.White;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(127, 25);
            this.toolStripButton1.Text = "اضافة طلب";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(127, 25);
            this.toolStripButton2.Text = "اضافة مجموعة";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.Color.White;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(127, 25);
            this.toolStripButton3.Text = "اضافة صنف";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minaPaginationPanel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Mina.UI_WinForm.MinaPaginationPanel minaPaginationPanel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

