namespace Calculator
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
            this.txtIslemEkrani = new System.Windows.Forms.RichTextBox();
            this.lblSonucGoster = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnACall = new System.Windows.Forms.Button();
            this.btnIsaretDegistir = new System.Windows.Forms.Button();
            this.btnYuzeBol = new System.Windows.Forms.Button();
            this.btnYedi = new System.Windows.Forms.Button();
            this.btnSekiz = new System.Windows.Forms.Button();
            this.btnDokuz = new System.Windows.Forms.Button();
            this.btnDort = new System.Windows.Forms.Button();
            this.btnBes = new System.Windows.Forms.Button();
            this.btnAlti = new System.Windows.Forms.Button();
            this.btnBir = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnUc = new System.Windows.Forms.Button();
            this.btnSifir = new System.Windows.Forms.Button();
            this.btnVirgul = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBolmeIslemi = new System.Windows.Forms.Button();
            this.btnCarpmaIslemi = new System.Windows.Forms.Button();
            this.btnCikarmaIslemi = new System.Windows.Forms.Button();
            this.btnToplamaIslemi = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIslemEkrani
            // 
            this.txtIslemEkrani.Enabled = false;
            this.txtIslemEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemEkrani.Location = new System.Drawing.Point(12, 61);
            this.txtIslemEkrani.Name = "txtIslemEkrani";
            this.txtIslemEkrani.Size = new System.Drawing.Size(300, 101);
            this.txtIslemEkrani.TabIndex = 0;
            this.txtIslemEkrani.Text = "0";
            // 
            // lblSonucGoster
            // 
            this.lblSonucGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonucGoster.Location = new System.Drawing.Point(13, 28);
            this.lblSonucGoster.Name = "lblSonucGoster";
            this.lblSonucGoster.Size = new System.Drawing.Size(299, 30);
            this.lblSonucGoster.TabIndex = 1;
            this.lblSonucGoster.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnACall);
            this.flowLayoutPanel1.Controls.Add(this.btnIsaretDegistir);
            this.flowLayoutPanel1.Controls.Add(this.btnYuzeBol);
            this.flowLayoutPanel1.Controls.Add(this.btnYedi);
            this.flowLayoutPanel1.Controls.Add(this.btnSekiz);
            this.flowLayoutPanel1.Controls.Add(this.btnDokuz);
            this.flowLayoutPanel1.Controls.Add(this.btnDort);
            this.flowLayoutPanel1.Controls.Add(this.btnBes);
            this.flowLayoutPanel1.Controls.Add(this.btnAlti);
            this.flowLayoutPanel1.Controls.Add(this.btnBir);
            this.flowLayoutPanel1.Controls.Add(this.btnIki);
            this.flowLayoutPanel1.Controls.Add(this.btnUc);
            this.flowLayoutPanel1.Controls.Add(this.btnSifir);
            this.flowLayoutPanel1.Controls.Add(this.btnVirgul);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 217);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(225, 358);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnACall
            // 
            this.btnACall.Location = new System.Drawing.Point(3, 3);
            this.btnACall.Name = "btnACall";
            this.btnACall.Size = new System.Drawing.Size(68, 62);
            this.btnACall.TabIndex = 1;
            this.btnACall.Text = "C";
            this.btnACall.UseVisualStyleBackColor = true;
            this.btnACall.Click += new System.EventHandler(this.btnACall_Click);
            // 
            // btnIsaretDegistir
            // 
            this.btnIsaretDegistir.Location = new System.Drawing.Point(77, 3);
            this.btnIsaretDegistir.Name = "btnIsaretDegistir";
            this.btnIsaretDegistir.Size = new System.Drawing.Size(68, 62);
            this.btnIsaretDegistir.TabIndex = 0;
            this.btnIsaretDegistir.Text = "+/-";
            this.btnIsaretDegistir.UseVisualStyleBackColor = true;
            this.btnIsaretDegistir.Click += new System.EventHandler(this.btnIsaretDegistir_Click);
            // 
            // btnYuzeBol
            // 
            this.btnYuzeBol.Location = new System.Drawing.Point(151, 3);
            this.btnYuzeBol.Name = "btnYuzeBol";
            this.btnYuzeBol.Size = new System.Drawing.Size(68, 62);
            this.btnYuzeBol.TabIndex = 2;
            this.btnYuzeBol.Text = "%";
            this.btnYuzeBol.UseVisualStyleBackColor = true;
            this.btnYuzeBol.Click += new System.EventHandler(this.btnYuzeBol_Click);
            // 
            // btnYedi
            // 
            this.btnYedi.Location = new System.Drawing.Point(3, 71);
            this.btnYedi.Name = "btnYedi";
            this.btnYedi.Size = new System.Drawing.Size(68, 62);
            this.btnYedi.TabIndex = 3;
            this.btnYedi.Text = "7";
            this.btnYedi.UseVisualStyleBackColor = true;
            this.btnYedi.Click += new System.EventHandler(this.btnYedi_Click);
            // 
            // btnSekiz
            // 
            this.btnSekiz.Location = new System.Drawing.Point(77, 71);
            this.btnSekiz.Name = "btnSekiz";
            this.btnSekiz.Size = new System.Drawing.Size(68, 62);
            this.btnSekiz.TabIndex = 4;
            this.btnSekiz.Text = "8";
            this.btnSekiz.UseVisualStyleBackColor = true;
            this.btnSekiz.Click += new System.EventHandler(this.btnSekiz_Click);
            // 
            // btnDokuz
            // 
            this.btnDokuz.Location = new System.Drawing.Point(151, 71);
            this.btnDokuz.Name = "btnDokuz";
            this.btnDokuz.Size = new System.Drawing.Size(68, 62);
            this.btnDokuz.TabIndex = 5;
            this.btnDokuz.Text = "9";
            this.btnDokuz.UseVisualStyleBackColor = true;
            this.btnDokuz.Click += new System.EventHandler(this.btnDokuz_Click);
            // 
            // btnDort
            // 
            this.btnDort.Location = new System.Drawing.Point(3, 139);
            this.btnDort.Name = "btnDort";
            this.btnDort.Size = new System.Drawing.Size(68, 62);
            this.btnDort.TabIndex = 6;
            this.btnDort.Text = "4";
            this.btnDort.UseVisualStyleBackColor = true;
            this.btnDort.Click += new System.EventHandler(this.btnDort_Click);
            // 
            // btnBes
            // 
            this.btnBes.Location = new System.Drawing.Point(77, 139);
            this.btnBes.Name = "btnBes";
            this.btnBes.Size = new System.Drawing.Size(68, 62);
            this.btnBes.TabIndex = 7;
            this.btnBes.Text = "5";
            this.btnBes.UseVisualStyleBackColor = true;
            this.btnBes.Click += new System.EventHandler(this.btnBes_Click);
            // 
            // btnAlti
            // 
            this.btnAlti.Location = new System.Drawing.Point(151, 139);
            this.btnAlti.Name = "btnAlti";
            this.btnAlti.Size = new System.Drawing.Size(68, 62);
            this.btnAlti.TabIndex = 8;
            this.btnAlti.Text = "6";
            this.btnAlti.UseVisualStyleBackColor = true;
            this.btnAlti.Click += new System.EventHandler(this.btnAlti_Click);
            // 
            // btnBir
            // 
            this.btnBir.Location = new System.Drawing.Point(3, 207);
            this.btnBir.Name = "btnBir";
            this.btnBir.Size = new System.Drawing.Size(68, 62);
            this.btnBir.TabIndex = 10;
            this.btnBir.Text = "1";
            this.btnBir.UseVisualStyleBackColor = true;
            this.btnBir.Click += new System.EventHandler(this.btnBir_Click);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(77, 207);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(68, 62);
            this.btnIki.TabIndex = 12;
            this.btnIki.Text = "2";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnUc
            // 
            this.btnUc.Location = new System.Drawing.Point(151, 207);
            this.btnUc.Name = "btnUc";
            this.btnUc.Size = new System.Drawing.Size(68, 62);
            this.btnUc.TabIndex = 11;
            this.btnUc.Text = "3";
            this.btnUc.UseVisualStyleBackColor = true;
            this.btnUc.Click += new System.EventHandler(this.btnUc_Click);
            // 
            // btnSifir
            // 
            this.btnSifir.Location = new System.Drawing.Point(3, 275);
            this.btnSifir.Name = "btnSifir";
            this.btnSifir.Size = new System.Drawing.Size(142, 62);
            this.btnSifir.TabIndex = 9;
            this.btnSifir.Text = "0";
            this.btnSifir.UseVisualStyleBackColor = true;
            this.btnSifir.Click += new System.EventHandler(this.btnSifir_Click);
            // 
            // btnVirgul
            // 
            this.btnVirgul.Location = new System.Drawing.Point(151, 275);
            this.btnVirgul.Name = "btnVirgul";
            this.btnVirgul.Size = new System.Drawing.Size(68, 62);
            this.btnVirgul.TabIndex = 13;
            this.btnVirgul.Text = ",";
            this.btnVirgul.UseVisualStyleBackColor = true;
            this.btnVirgul.Click += new System.EventHandler(this.btnVirgul_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnBolmeIslemi);
            this.flowLayoutPanel2.Controls.Add(this.btnCarpmaIslemi);
            this.flowLayoutPanel2.Controls.Add(this.btnCikarmaIslemi);
            this.flowLayoutPanel2.Controls.Add(this.btnToplamaIslemi);
            this.flowLayoutPanel2.Controls.Add(this.btnEsittir);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(237, 217);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(75, 358);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnBolmeIslemi
            // 
            this.btnBolmeIslemi.Location = new System.Drawing.Point(3, 3);
            this.btnBolmeIslemi.Name = "btnBolmeIslemi";
            this.btnBolmeIslemi.Size = new System.Drawing.Size(68, 62);
            this.btnBolmeIslemi.TabIndex = 14;
            this.btnBolmeIslemi.Text = "/";
            this.btnBolmeIslemi.UseVisualStyleBackColor = true;
            this.btnBolmeIslemi.Click += new System.EventHandler(this.btnBolmeIslemi_Click);
            // 
            // btnCarpmaIslemi
            // 
            this.btnCarpmaIslemi.Location = new System.Drawing.Point(3, 71);
            this.btnCarpmaIslemi.Name = "btnCarpmaIslemi";
            this.btnCarpmaIslemi.Size = new System.Drawing.Size(68, 62);
            this.btnCarpmaIslemi.TabIndex = 15;
            this.btnCarpmaIslemi.Text = "x";
            this.btnCarpmaIslemi.UseVisualStyleBackColor = true;
            this.btnCarpmaIslemi.Click += new System.EventHandler(this.btnCarpmaIslemi_Click);
            // 
            // btnCikarmaIslemi
            // 
            this.btnCikarmaIslemi.Location = new System.Drawing.Point(3, 139);
            this.btnCikarmaIslemi.Name = "btnCikarmaIslemi";
            this.btnCikarmaIslemi.Size = new System.Drawing.Size(68, 62);
            this.btnCikarmaIslemi.TabIndex = 16;
            this.btnCikarmaIslemi.Text = "-";
            this.btnCikarmaIslemi.UseVisualStyleBackColor = true;
            this.btnCikarmaIslemi.Click += new System.EventHandler(this.btnCikarmaIslemi_Click);
            // 
            // btnToplamaIslemi
            // 
            this.btnToplamaIslemi.Location = new System.Drawing.Point(3, 207);
            this.btnToplamaIslemi.Name = "btnToplamaIslemi";
            this.btnToplamaIslemi.Size = new System.Drawing.Size(68, 62);
            this.btnToplamaIslemi.TabIndex = 17;
            this.btnToplamaIslemi.Text = "+";
            this.btnToplamaIslemi.UseVisualStyleBackColor = true;
            this.btnToplamaIslemi.Click += new System.EventHandler(this.btnToplamaIslemi_Click);
            // 
            // btnEsittir
            // 
            this.btnEsittir.Location = new System.Drawing.Point(3, 275);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(68, 62);
            this.btnEsittir.TabIndex = 18;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = true;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.Location = new System.Drawing.Point(12, 168);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(300, 43);
            this.btnAllClear.TabIndex = 4;
            this.btnAllClear.Text = "AC";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 626);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblSonucGoster);
            this.Controls.Add(this.txtIslemEkrani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIslemEkrani;
        private System.Windows.Forms.Label lblSonucGoster;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnACall;
        private System.Windows.Forms.Button btnIsaretDegistir;
        private System.Windows.Forms.Button btnYuzeBol;
        private System.Windows.Forms.Button btnYedi;
        private System.Windows.Forms.Button btnSekiz;
        private System.Windows.Forms.Button btnDokuz;
        private System.Windows.Forms.Button btnDort;
        private System.Windows.Forms.Button btnBes;
        private System.Windows.Forms.Button btnAlti;
        private System.Windows.Forms.Button btnBir;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnUc;
        private System.Windows.Forms.Button btnSifir;
        private System.Windows.Forms.Button btnVirgul;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnBolmeIslemi;
        private System.Windows.Forms.Button btnCarpmaIslemi;
        private System.Windows.Forms.Button btnCikarmaIslemi;
        private System.Windows.Forms.Button btnToplamaIslemi;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnAllClear;
    }
}

