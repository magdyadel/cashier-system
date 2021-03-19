namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    partial class TableSizeQtty
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
            this.btnTableAddToOrderGrid = new System.Windows.Forms.Button();
            this.cmbTableSizeShow = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableAddQtty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTableAddToOrderGrid
            // 
            this.btnTableAddToOrderGrid.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTableAddToOrderGrid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnTableAddToOrderGrid.Location = new System.Drawing.Point(5, 139);
            this.btnTableAddToOrderGrid.Name = "btnTableAddToOrderGrid";
            this.btnTableAddToOrderGrid.Size = new System.Drawing.Size(250, 60);
            this.btnTableAddToOrderGrid.TabIndex = 6;
            this.btnTableAddToOrderGrid.Text = "اضافة إلى الاوردر";
            this.btnTableAddToOrderGrid.UseVisualStyleBackColor = false;
            this.btnTableAddToOrderGrid.Click += new System.EventHandler(this.btnTableAddToOrderGrid_Click);
            // 
            // cmbTableSizeShow
            // 
            this.cmbTableSizeShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableSizeShow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbTableSizeShow.FormattingEnabled = true;
            this.cmbTableSizeShow.Location = new System.Drawing.Point(66, 88);
            this.cmbTableSizeShow.Name = "cmbTableSizeShow";
            this.cmbTableSizeShow.Size = new System.Drawing.Size(106, 27);
            this.cmbTableSizeShow.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(96, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "الحجم :";
            // 
            // txtTableAddQtty
            // 
            this.txtTableAddQtty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableAddQtty.Location = new System.Drawing.Point(85, 33);
            this.txtTableAddQtty.Multiline = true;
            this.txtTableAddQtty.Name = "txtTableAddQtty";
            this.txtTableAddQtty.Size = new System.Drawing.Size(75, 27);
            this.txtTableAddQtty.TabIndex = 11;
            this.txtTableAddQtty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTableAddQtty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTableAddQtty_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(94, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "الكمية :";
            // 
            // TableSizeQtty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableAddQtty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTableSizeShow);
            this.Controls.Add(this.btnTableAddToOrderGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableSizeQtty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableSizeQtty";
            this.Load += new System.EventHandler(this.OrderSizeQtty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTableAddToOrderGrid;
        private System.Windows.Forms.ComboBox cmbTableSizeShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableAddQtty;
        private System.Windows.Forms.Label label1;
    }
}