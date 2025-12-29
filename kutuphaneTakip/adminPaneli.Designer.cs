namespace kutuphaneTakip
{
    partial class frmAdmin
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
            this.btnKiralamaIslemleri = new System.Windows.Forms.Button();
            this.btnKitapIslemleri = new System.Windows.Forms.Button();
            this.btnUyeIslemleri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblToplamKitap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblToplamUye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblKiralamalar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableKiralamalar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKiralamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.btnKiralamaIslemleri);
            this.panel1.Controls.Add(this.btnKitapIslemleri);
            this.panel1.Controls.Add(this.btnUyeIslemleri);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnKiralamaIslemleri
            // 
            this.btnKiralamaIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiralamaIslemleri.FlatAppearance.BorderSize = 0;
            this.btnKiralamaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKiralamaIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralamaIslemleri.Location = new System.Drawing.Point(42, 301);
            this.btnKiralamaIslemleri.Name = "btnKiralamaIslemleri";
            this.btnKiralamaIslemleri.Size = new System.Drawing.Size(131, 44);
            this.btnKiralamaIslemleri.TabIndex = 2;
            this.btnKiralamaIslemleri.Text = "Kiralama İşlemleri";
            this.btnKiralamaIslemleri.UseVisualStyleBackColor = true;
            this.btnKiralamaIslemleri.Click += new System.EventHandler(this.btnKiralamaIslemleri_Click);
            // 
            // btnKitapIslemleri
            // 
            this.btnKitapIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslemleri.FlatAppearance.BorderSize = 0;
            this.btnKitapIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKitapIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapIslemleri.Location = new System.Drawing.Point(41, 191);
            this.btnKitapIslemleri.Name = "btnKitapIslemleri";
            this.btnKitapIslemleri.Size = new System.Drawing.Size(132, 37);
            this.btnKitapIslemleri.TabIndex = 2;
            this.btnKitapIslemleri.Text = "Kitap İşlemleri";
            this.btnKitapIslemleri.UseVisualStyleBackColor = true;
            this.btnKitapIslemleri.Click += new System.EventHandler(this.btnKitapIslemleri_Click);
            // 
            // btnUyeIslemleri
            // 
            this.btnUyeIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeIslemleri.FlatAppearance.BorderSize = 0;
            this.btnUyeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnUyeIslemleri.Location = new System.Drawing.Point(42, 82);
            this.btnUyeIslemleri.Name = "btnUyeIslemleri";
            this.btnUyeIslemleri.Size = new System.Drawing.Size(131, 36);
            this.btnUyeIslemleri.TabIndex = 1;
            this.btnUyeIslemleri.Text = "Üye İşlemleri";
            this.btnUyeIslemleri.UseVisualStyleBackColor = true;
            this.btnUyeIslemleri.Click += new System.EventHandler(this.btnUyeIslemleri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.lblToplamKitap);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(478, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 101);
            this.panel2.TabIndex = 1;
            // 
            // lblToplamKitap
            // 
            this.lblToplamKitap.AutoSize = true;
            this.lblToplamKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKitap.Location = new System.Drawing.Point(13, 52);
            this.lblToplamKitap.Name = "lblToplamKitap";
            this.lblToplamKitap.Size = new System.Drawing.Size(17, 17);
            this.lblToplamKitap.TabIndex = 5;
            this.lblToplamKitap.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Kitap";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.lblToplamUye);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(232, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 101);
            this.panel4.TabIndex = 3;
            // 
            // lblToplamUye
            // 
            this.lblToplamUye.AutoSize = true;
            this.lblToplamUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUye.Location = new System.Drawing.Point(13, 54);
            this.lblToplamUye.Name = "lblToplamUye";
            this.lblToplamUye.Size = new System.Drawing.Size(17, 17);
            this.lblToplamUye.TabIndex = 5;
            this.lblToplamUye.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplam Üye";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Controls.Add(this.lblKiralamalar);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(739, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 101);
            this.panel5.TabIndex = 4;
            // 
            // lblKiralamalar
            // 
            this.lblKiralamalar.AutoSize = true;
            this.lblKiralamalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiralamalar.Location = new System.Drawing.Point(13, 54);
            this.lblKiralamalar.Name = "lblKiralamalar";
            this.lblKiralamalar.Size = new System.Drawing.Size(17, 17);
            this.lblKiralamalar.TabIndex = 5;
            this.lblKiralamalar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kiralanmış Kitaplar";
            // 
            // tableKiralamalar
            // 
            this.tableKiralamalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableKiralamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKiralamalar.Location = new System.Drawing.Point(232, 191);
            this.tableKiralamalar.Name = "tableKiralamalar";
            this.tableKiralamalar.RowHeadersWidth = 51;
            this.tableKiralamalar.RowTemplate.Height = 24;
            this.tableKiralamalar.Size = new System.Drawing.Size(678, 235);
            this.tableKiralamalar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(229, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiralamalar";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableKiralamalar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKiralamalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKiralamaIslemleri;
        private System.Windows.Forms.Button btnKitapIslemleri;
        private System.Windows.Forms.Button btnUyeIslemleri;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToplamKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblToplamUye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblKiralamalar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tableKiralamalar;
        private System.Windows.Forms.Label label3;
    }
}