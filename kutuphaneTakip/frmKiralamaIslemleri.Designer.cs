namespace kutuphaneTakip
{
    partial class frmKiralamaIslemleri
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableKitaplar = new System.Windows.Forms.DataGridView();
            this.textKitapAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableUyeler = new System.Windows.Forms.DataGridView();
            this.txtUyeAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSecilenUye = new System.Windows.Forms.Label();
            this.lblSecilenKitap = new System.Windows.Forms.Label();
            this.dateVerilis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateİade = new System.Windows.Forms.DateTimePicker();
            this.btnKirala = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKitaplar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUyeler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 264);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tableKitaplar);
            this.groupBox2.Controls.Add(this.textKitapAra);
            this.groupBox2.Location = new System.Drawing.Point(461, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kitap Ara ";
            // 
            // tableKitaplar
            // 
            this.tableKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKitaplar.Location = new System.Drawing.Point(12, 66);
            this.tableKitaplar.Name = "tableKitaplar";
            this.tableKitaplar.RowHeadersWidth = 51;
            this.tableKitaplar.RowTemplate.Height = 24;
            this.tableKitaplar.Size = new System.Drawing.Size(472, 186);
            this.tableKitaplar.TabIndex = 2;
            this.tableKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableKitaplar_CellContentClick);
            // 
            // textKitapAra
            // 
            this.textKitapAra.Location = new System.Drawing.Point(105, 35);
            this.textKitapAra.Name = "textKitapAra";
            this.textKitapAra.Size = new System.Drawing.Size(152, 22);
            this.textKitapAra.TabIndex = 10;
            this.textKitapAra.TextChanged += new System.EventHandler(this.textKitapAra_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tableUyeler);
            this.groupBox1.Controls.Add(this.txtUyeAra);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Seçimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Üye Ara ";
            // 
            // tableUyeler
            // 
            this.tableUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUyeler.Location = new System.Drawing.Point(6, 66);
            this.tableUyeler.Name = "tableUyeler";
            this.tableUyeler.RowHeadersWidth = 51;
            this.tableUyeler.RowTemplate.Height = 24;
            this.tableUyeler.Size = new System.Drawing.Size(423, 186);
            this.tableUyeler.TabIndex = 1;
            this.tableUyeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableUyeler_CellContentClick);
            // 
            // txtUyeAra
            // 
            this.txtUyeAra.Location = new System.Drawing.Point(100, 32);
            this.txtUyeAra.Name = "txtUyeAra";
            this.txtUyeAra.Size = new System.Drawing.Size(152, 22);
            this.txtUyeAra.TabIndex = 8;
            this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seçilen Üye :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(102, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seçilen Kitap :";
            // 
            // lblSecilenUye
            // 
            this.lblSecilenUye.AutoSize = true;
            this.lblSecilenUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenUye.Location = new System.Drawing.Point(214, 321);
            this.lblSecilenUye.Name = "lblSecilenUye";
            this.lblSecilenUye.Size = new System.Drawing.Size(0, 16);
            this.lblSecilenUye.TabIndex = 12;
            // 
            // lblSecilenKitap
            // 
            this.lblSecilenKitap.AutoSize = true;
            this.lblSecilenKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenKitap.Location = new System.Drawing.Point(214, 378);
            this.lblSecilenKitap.Name = "lblSecilenKitap";
            this.lblSecilenKitap.Size = new System.Drawing.Size(0, 16);
            this.lblSecilenKitap.TabIndex = 13;
            // 
            // dateVerilis
            // 
            this.dateVerilis.Location = new System.Drawing.Point(594, 316);
            this.dateVerilis.Name = "dateVerilis";
            this.dateVerilis.Size = new System.Drawing.Size(200, 22);
            this.dateVerilis.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(470, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Veriliş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(472, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "İade Tarihi :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateİade
            // 
            this.dateİade.Location = new System.Drawing.Point(594, 378);
            this.dateİade.Name = "dateİade";
            this.dateİade.Size = new System.Drawing.Size(200, 22);
            this.dateİade.TabIndex = 17;
            // 
            // btnKirala
            // 
            this.btnKirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKirala.FlatAppearance.BorderSize = 0;
            this.btnKirala.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirala.Location = new System.Drawing.Point(662, 441);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(132, 37);
            this.btnKirala.TabIndex = 18;
            this.btnKirala.Text = "Kiralama Yap";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // frmKiralamaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 490);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.dateİade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateVerilis);
            this.Controls.Add(this.lblSecilenKitap);
            this.Controls.Add(this.lblSecilenUye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmKiralamaIslemleri";
            this.Text = "frmKiralamaIslemleri";
            this.Load += new System.EventHandler(this.frmKiralamaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKitaplar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableUyeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tableUyeler;
        private System.Windows.Forms.DataGridView tableKitaplar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKitapAra;
        private System.Windows.Forms.TextBox txtUyeAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSecilenUye;
        private System.Windows.Forms.Label lblSecilenKitap;
        private System.Windows.Forms.DateTimePicker dateVerilis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateİade;
        private System.Windows.Forms.Button btnKirala;
    }
}