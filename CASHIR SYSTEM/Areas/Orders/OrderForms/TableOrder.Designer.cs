namespace CASHIR_SYSTEM.Areas.Orders.OrderForms
{
    partial class TableOrder
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
            this.fpnlCatTable = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fpnltemTable = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataTableOrderView = new System.Windows.Forms.DataGridView();
            this.btnPrintMTB5 = new System.Windows.Forms.Button();
            this.btnFinalPrint = new System.Windows.Forms.Button();
            this.btnDeleteSelectItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // fpnlCatTable
            // 
            this.fpnlCatTable.AutoScroll = true;
            this.fpnlCatTable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fpnlCatTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlCatTable.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpnlCatTable.Location = new System.Drawing.Point(3, 21);
            this.fpnlCatTable.Name = "fpnlCatTable";
            this.fpnlCatTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpnlCatTable.Size = new System.Drawing.Size(168, 328);
            this.fpnlCatTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.fpnlCatTable);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المجموعات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fpnltemTable);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(192, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 349);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاصناف";
            // 
            // fpnltemTable
            // 
            this.fpnltemTable.AutoScroll = true;
            this.fpnltemTable.BackColor = System.Drawing.SystemColors.Menu;
            this.fpnltemTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnltemTable.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpnltemTable.Location = new System.Drawing.Point(3, 21);
            this.fpnltemTable.Name = "fpnltemTable";
            this.fpnltemTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpnltemTable.Size = new System.Drawing.Size(455, 325);
            this.fpnltemTable.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataTableOrderView);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox3.Location = new System.Drawing.Point(659, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 166);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الاوردر";
            // 
            // dataTableOrderView
            // 
            this.dataTableOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableOrderView.Location = new System.Drawing.Point(3, 18);
            this.dataTableOrderView.Name = "dataTableOrderView";
            this.dataTableOrderView.Size = new System.Drawing.Size(296, 145);
            this.dataTableOrderView.TabIndex = 0;
            this.dataTableOrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableOrderView_CellContentClick);
            // 
            // btnPrintMTB5
            // 
            this.btnPrintMTB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintMTB5.Location = new System.Drawing.Point(280, 415);
            this.btnPrintMTB5.Name = "btnPrintMTB5";
            this.btnPrintMTB5.Size = new System.Drawing.Size(256, 39);
            this.btnPrintMTB5.TabIndex = 6;
            this.btnPrintMTB5.Text = "طباعة مطبخ";
            this.btnPrintMTB5.UseVisualStyleBackColor = true;
            this.btnPrintMTB5.Click += new System.EventHandler(this.btnPrintMTB5_Click);
            // 
            // btnFinalPrint
            // 
            this.btnFinalPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalPrint.Location = new System.Drawing.Point(618, 415);
            this.btnFinalPrint.Name = "btnFinalPrint";
            this.btnFinalPrint.Size = new System.Drawing.Size(256, 39);
            this.btnFinalPrint.TabIndex = 7;
            this.btnFinalPrint.Text = "طباعة نهائي";
            this.btnFinalPrint.UseVisualStyleBackColor = true;
            this.btnFinalPrint.Click += new System.EventHandler(this.btnFinalPrint_Click);
            // 
            // btnDeleteSelectItem
            // 
            this.btnDeleteSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelectItem.Location = new System.Drawing.Point(659, 238);
            this.btnDeleteSelectItem.Name = "btnDeleteSelectItem";
            this.btnDeleteSelectItem.Size = new System.Drawing.Size(138, 33);
            this.btnDeleteSelectItem.TabIndex = 8;
            this.btnDeleteSelectItem.Text = "حذف الصنف المحدد";
            this.btnDeleteSelectItem.UseVisualStyleBackColor = true;
            this.btnDeleteSelectItem.Click += new System.EventHandler(this.btnDeleteSelectItem_Click);
            // 
            // TableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 476);
            this.Controls.Add(this.btnDeleteSelectItem);
            this.Controls.Add(this.btnFinalPrint);
            this.Controls.Add(this.btnPrintMTB5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableOrder";
            this.Load += new System.EventHandler(this.TableOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOrderView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlCatTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel fpnltemTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataTableOrderView;
        private System.Windows.Forms.Button btnPrintMTB5;
        private System.Windows.Forms.Button btnFinalPrint;
        private System.Windows.Forms.Button btnDeleteSelectItem;
    }
}