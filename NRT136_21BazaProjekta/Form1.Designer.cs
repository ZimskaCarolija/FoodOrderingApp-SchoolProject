
namespace NRT136_21BazaProjekta
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSortiraj = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbPrilozi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCenaJela = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.listBoxPOrudbina = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.btnKupi = new System.Windows.Forms.Button();
            this.btnOduzmi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sortiraj";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSortiraj
            // 
            this.cmbSortiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortiraj.FormattingEnabled = true;
            this.cmbSortiraj.Location = new System.Drawing.Point(103, 51);
            this.cmbSortiraj.Name = "cmbSortiraj";
            this.cmbSortiraj.Size = new System.Drawing.Size(121, 28);
            this.cmbSortiraj.TabIndex = 1;
            this.cmbSortiraj.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(28, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(812, 84);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(311, 52);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(160, 26);
            this.txtNaziv.TabIndex = 5;
            // 
            // cmbPrilozi
            // 
            this.cmbPrilozi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrilozi.FormattingEnabled = true;
            this.cmbPrilozi.Location = new System.Drawing.Point(372, 240);
            this.cmbPrilozi.Name = "cmbPrilozi";
            this.cmbPrilozi.Size = new System.Drawing.Size(184, 28);
            this.cmbPrilozi.TabIndex = 6;
            this.cmbPrilozi.SelectedIndexChanged += new System.EventHandler(this.cmbPrilozi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prilozi :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cena Jela :";
            // 
            // lblCenaJela
            // 
            this.lblCenaJela.AutoSize = true;
            this.lblCenaJela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCenaJela.Location = new System.Drawing.Point(682, 248);
            this.lblCenaJela.Name = "lblCenaJela";
            this.lblCenaJela.Size = new System.Drawing.Size(18, 20);
            this.lblCenaJela.TabIndex = 9;
            this.lblCenaJela.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Naziv Jela :";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(108, 247);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(38, 20);
            this.lblNaziv.TabIndex = 11;
            this.lblNaziv.Text = "Jelo";
            // 
            // listBoxPOrudbina
            // 
            this.listBoxPOrudbina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPOrudbina.FormattingEnabled = true;
            this.listBoxPOrudbina.ItemHeight = 20;
            this.listBoxPOrudbina.Location = new System.Drawing.Point(28, 371);
            this.listBoxPOrudbina.Name = "listBoxPOrudbina";
            this.listBoxPOrudbina.Size = new System.Drawing.Size(812, 84);
            this.listBoxPOrudbina.TabIndex = 14;
            this.listBoxPOrudbina.SelectedIndexChanged += new System.EventHandler(this.listBoxPOrudbina_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ukupna Cena :";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnaCena.Location = new System.Drawing.Point(178, 505);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(20, 24);
            this.lblUkupnaCena.TabIndex = 16;
            this.lblUkupnaCena.Text = "0";
            // 
            // btnKupi
            // 
            this.btnKupi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(169)))));
            this.btnKupi.FlatAppearance.BorderSize = 0;
            this.btnKupi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupi.Image = global::NRT136_21BazaProjekta.Properties.Resources.Pare;
            this.btnKupi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKupi.Location = new System.Drawing.Point(258, 497);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(126, 42);
            this.btnKupi.TabIndex = 17;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKupi.UseVisualStyleBackColor = false;
            this.btnKupi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOduzmi
            // 
            this.btnOduzmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.btnOduzmi.FlatAppearance.BorderSize = 0;
            this.btnOduzmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOduzmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOduzmi.Image = global::NRT136_21BazaProjekta.Properties.Resources.minus_sign;
            this.btnOduzmi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOduzmi.Location = new System.Drawing.Point(182, 284);
            this.btnOduzmi.Name = "btnOduzmi";
            this.btnOduzmi.Size = new System.Drawing.Size(116, 41);
            this.btnOduzmi.TabIndex = 13;
            this.btnOduzmi.Text = "Oduzmi";
            this.btnOduzmi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOduzmi.UseVisualStyleBackColor = false;
            this.btnOduzmi.Click += new System.EventHandler(this.btnOduzmi_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(232)))), ((int)(((byte)(169)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::NRT136_21BazaProjekta.Properties.Resources.plus;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(28, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Dodaj";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NRT136_21BazaProjekta.Properties.Resources.Pretraga;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(724, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtriraj";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(976, 680);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.lblUkupnaCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxPOrudbina);
            this.Controls.Add(this.btnOduzmi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCenaJela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPrilozi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbSortiraj);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Poruci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSortiraj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbPrilozi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCenaJela;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOduzmi;
        private System.Windows.Forms.ListBox listBoxPOrudbina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Button btnKupi;
    }
}

