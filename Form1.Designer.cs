namespace Homework_W5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detailnama = new System.Windows.Forms.TextBox();
            this.detailstock = new System.Windows.Forms.TextBox();
            this.detailharga = new System.Windows.Forms.TextBox();
            this.detailkategori = new System.Windows.Forms.ComboBox();
            this.addbarang = new System.Windows.Forms.Button();
            this.editbarang = new System.Windows.Forms.Button();
            this.hapusbarang = new System.Windows.Forms.Button();
            this.datakategori = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.namakategori = new System.Windows.Forms.TextBox();
            this.addkategori = new System.Windows.Forms.Button();
            this.hapuskategori = new System.Windows.Forms.Button();
            this.databarang = new System.Windows.Forms.DataGridView();
            this.listbarang = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databarang)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(489, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(489, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(15, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price        :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(15, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 29);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock       :";
            // 
            // detailnama
            // 
            this.detailnama.Location = new System.Drawing.Point(168, 320);
            this.detailnama.Name = "detailnama";
            this.detailnama.Size = new System.Drawing.Size(263, 26);
            this.detailnama.TabIndex = 8;
            // 
            // detailstock
            // 
            this.detailstock.Location = new System.Drawing.Point(168, 454);
            this.detailstock.Name = "detailstock";
            this.detailstock.Size = new System.Drawing.Size(263, 26);
            this.detailstock.TabIndex = 9;
            this.detailstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detailstock_KeyPress);
            // 
            // detailharga
            // 
            this.detailharga.Location = new System.Drawing.Point(168, 411);
            this.detailharga.Name = "detailharga";
            this.detailharga.Size = new System.Drawing.Size(263, 26);
            this.detailharga.TabIndex = 10;
            this.detailharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.detailharga_KeyPress);
            // 
            // detailkategori
            // 
            this.detailkategori.FormattingEnabled = true;
            this.detailkategori.Location = new System.Drawing.Point(168, 361);
            this.detailkategori.Name = "detailkategori";
            this.detailkategori.Size = new System.Drawing.Size(263, 28);
            this.detailkategori.TabIndex = 11;
            // 
            // addbarang
            // 
            this.addbarang.Location = new System.Drawing.Point(20, 507);
            this.addbarang.Name = "addbarang";
            this.addbarang.Size = new System.Drawing.Size(152, 52);
            this.addbarang.TabIndex = 12;
            this.addbarang.Text = "Add Product";
            this.addbarang.UseVisualStyleBackColor = true;
            this.addbarang.Click += new System.EventHandler(this.addbarang_Click);
            // 
            // editbarang
            // 
            this.editbarang.Location = new System.Drawing.Point(178, 507);
            this.editbarang.Name = "editbarang";
            this.editbarang.Size = new System.Drawing.Size(148, 52);
            this.editbarang.TabIndex = 13;
            this.editbarang.Text = "Edit Product";
            this.editbarang.UseVisualStyleBackColor = true;
            this.editbarang.Click += new System.EventHandler(this.editbarang_Click);
            // 
            // hapusbarang
            // 
            this.hapusbarang.Location = new System.Drawing.Point(20, 565);
            this.hapusbarang.Name = "hapusbarang";
            this.hapusbarang.Size = new System.Drawing.Size(306, 54);
            this.hapusbarang.TabIndex = 14;
            this.hapusbarang.Text = "Remove Product";
            this.hapusbarang.UseVisualStyleBackColor = true;
            this.hapusbarang.Click += new System.EventHandler(this.hapusbarang_Click);
            // 
            // datakategori
            // 
            this.datakategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datakategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakategori.Location = new System.Drawing.Point(496, 52);
            this.datakategori.Name = "datakategori";
            this.datakategori.ReadOnly = true;
            this.datakategori.RowHeadersVisible = false;
            this.datakategori.RowHeadersWidth = 62;
            this.datakategori.RowTemplate.Height = 28;
            this.datakategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datakategori.Size = new System.Drawing.Size(277, 179);
            this.datakategori.TabIndex = 15;
            this.datakategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakategori_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(795, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name :";
            // 
            // namakategori
            // 
            this.namakategori.Location = new System.Drawing.Point(800, 93);
            this.namakategori.Name = "namakategori";
            this.namakategori.Size = new System.Drawing.Size(240, 26);
            this.namakategori.TabIndex = 17;
            // 
            // addkategori
            // 
            this.addkategori.Location = new System.Drawing.Point(800, 136);
            this.addkategori.Name = "addkategori";
            this.addkategori.Size = new System.Drawing.Size(163, 38);
            this.addkategori.TabIndex = 18;
            this.addkategori.Text = "Add Category";
            this.addkategori.UseVisualStyleBackColor = true;
            this.addkategori.Click += new System.EventHandler(this.addkategori_Click);
            // 
            // hapuskategori
            // 
            this.hapuskategori.Location = new System.Drawing.Point(800, 193);
            this.hapuskategori.Name = "hapuskategori";
            this.hapuskategori.Size = new System.Drawing.Size(163, 38);
            this.hapuskategori.TabIndex = 19;
            this.hapuskategori.Text = "Remove Category";
            this.hapuskategori.UseVisualStyleBackColor = true;
            this.hapuskategori.Click += new System.EventHandler(this.hapuskategori_Click);
            // 
            // databarang
            // 
            this.databarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.databarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databarang.Location = new System.Drawing.Point(496, 301);
            this.databarang.Name = "databarang";
            this.databarang.ReadOnly = true;
            this.databarang.RowHeadersVisible = false;
            this.databarang.RowHeadersWidth = 62;
            this.databarang.RowTemplate.Height = 28;
            this.databarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databarang.Size = new System.Drawing.Size(544, 318);
            this.databarang.TabIndex = 20;
            this.databarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databarang_CellClick);
            // 
            // listbarang
            // 
            this.listbarang.Enabled = false;
            this.listbarang.FormattingEnabled = true;
            this.listbarang.Location = new System.Drawing.Point(892, 267);
            this.listbarang.Name = "listbarang";
            this.listbarang.Size = new System.Drawing.Size(148, 28);
            this.listbarang.TabIndex = 22;
            this.listbarang.SelectionChangeCommitted += new System.EventHandler(this.listbarang_SelectionChangeCommitted);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(811, 267);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(75, 28);
            this.filter.TabIndex = 23;
            this.filter.Text = "Filter :";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(742, 267);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(63, 28);
            this.all.TabIndex = 24;
            this.all.Text = "All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1052, 640);
            this.Controls.Add(this.all);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.listbarang);
            this.Controls.Add(this.databarang);
            this.Controls.Add(this.hapuskategori);
            this.Controls.Add(this.addkategori);
            this.Controls.Add(this.namakategori);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datakategori);
            this.Controls.Add(this.hapusbarang);
            this.Controls.Add(this.editbarang);
            this.Controls.Add(this.addbarang);
            this.Controls.Add(this.detailkategori);
            this.Controls.Add(this.detailharga);
            this.Controls.Add(this.detailstock);
            this.Controls.Add(this.detailnama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "ZARA STORE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datakategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox detailnama;
        private System.Windows.Forms.TextBox detailstock;
        private System.Windows.Forms.TextBox detailharga;
        private System.Windows.Forms.ComboBox detailkategori;
        private System.Windows.Forms.Button addbarang;
        private System.Windows.Forms.Button editbarang;
        private System.Windows.Forms.Button hapusbarang;
        private System.Windows.Forms.DataGridView datakategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox namakategori;
        private System.Windows.Forms.Button addkategori;
        private System.Windows.Forms.Button hapuskategori;
        private System.Windows.Forms.DataGridView databarang;
        private System.Windows.Forms.ComboBox listbarang;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button all;
    }
}

