namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    partial class AddSizeQtty
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddQtty = new System.Windows.Forms.TextBox();
            this.cmbSizeShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToOrderGrid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(94, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "الكمية :";
            // 
            // txtAddQtty
            // 
            this.txtAddQtty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQtty.Location = new System.Drawing.Point(85, 33);
            this.txtAddQtty.Multiline = true;
            this.txtAddQtty.Name = "txtAddQtty";
            this.txtAddQtty.Size = new System.Drawing.Size(75, 27);
            this.txtAddQtty.TabIndex = 6;
            this.txtAddQtty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddQtty.TextChanged += new System.EventHandler(this.txtAddQtty_TextChanged);
            // 
            // cmbSizeShow
            // 
            this.cmbSizeShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSizeShow.FormattingEnabled = true;
            this.cmbSizeShow.Location = new System.Drawing.Point(66, 88);
            this.cmbSizeShow.Name = "cmbSizeShow";
            this.cmbSizeShow.Size = new System.Drawing.Size(106, 27);
            this.cmbSizeShow.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(96, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "الحجم :";
            // 
            // btnAddToOrderGrid
            // 
            this.btnAddToOrderGrid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddToOrderGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddToOrderGrid.Location = new System.Drawing.Point(5, 139);
            this.btnAddToOrderGrid.Name = "btnAddToOrderGrid";
            this.btnAddToOrderGrid.Size = new System.Drawing.Size(250, 60);
            this.btnAddToOrderGrid.TabIndex = 5;
            this.btnAddToOrderGrid.Text = "اضافة إلى الاوردر";
            this.btnAddToOrderGrid.UseVisualStyleBackColor = false;
            this.btnAddToOrderGrid.Click += new System.EventHandler(this.btnAddToOrderGrid_Click);
            // 
            // AddSizeQtty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddQtty);
            this.Controls.Add(this.cmbSizeShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddToOrderGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSizeQtty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة";
            this.Load += new System.EventHandler(this.AddSizeQtty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddQtty;
        private System.Windows.Forms.ComboBox cmbSizeShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddToOrderGrid;
    }
}