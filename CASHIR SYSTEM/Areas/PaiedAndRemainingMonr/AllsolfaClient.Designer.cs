namespace CASHIR_SYSTEM.Areas.PaiedAndRemainingMonr
{
    partial class AllsolfaClient
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
            this.EditClient = new System.Windows.Forms.Button();
            this.phoneSearchTextBox = new System.Windows.Forms.TextBox();
            this.NameSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletclient = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditClient
            // 
            this.EditClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditClient.Location = new System.Drawing.Point(423, 50);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(159, 45);
            this.EditClient.TabIndex = 14;
            this.EditClient.Text = "تعديل بيانات العميل";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // phoneSearchTextBox
            // 
            this.phoneSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchTextBox.Location = new System.Drawing.Point(12, 111);
            this.phoneSearchTextBox.Name = "phoneSearchTextBox";
            this.phoneSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phoneSearchTextBox.Size = new System.Drawing.Size(277, 28);
            this.phoneSearchTextBox.TabIndex = 12;
            this.phoneSearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneSearchTextBox_KeyPress);
            this.phoneSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.phoneSearchTextBox_KeyUp);
            // 
            // NameSearchTextBox
            // 
            this.NameSearchTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearchTextBox.Location = new System.Drawing.Point(423, 111);
            this.NameSearchTextBox.Name = "NameSearchTextBox";
            this.NameSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameSearchTextBox.Size = new System.Drawing.Size(225, 28);
            this.NameSearchTextBox.TabIndex = 13;
            this.NameSearchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameSearchTextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(270, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "قائمة اصحاب السلفات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "بحث برقم الهاتف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "بحث بالاسم";
            // 
            // deletclient
            // 
            this.deletclient.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletclient.Location = new System.Drawing.Point(12, 50);
            this.deletclient.Name = "deletclient";
            this.deletclient.Size = new System.Drawing.Size(129, 46);
            this.deletclient.TabIndex = 7;
            this.deletclient.Text = "حذف االعميل";
            this.deletclient.UseVisualStyleBackColor = true;
            this.deletclient.Click += new System.EventHandler(this.deletclient_Click);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(588, 50);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(143, 46);
            this.details.TabIndex = 8;
            this.details.Text = "بيانات تفصيلية";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(719, 322);
            this.dataGridView1.TabIndex = 5;
            // 
            // AllsolfaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.EditClient);
            this.Controls.Add(this.phoneSearchTextBox);
            this.Controls.Add(this.NameSearchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletclient);
            this.Controls.Add(this.details);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllsolfaClient";
            this.Text = "AllsolfaClient";
            this.Load += new System.EventHandler(this.AllsolfaClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.TextBox phoneSearchTextBox;
        private System.Windows.Forms.TextBox NameSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletclient;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}