
namespace NRT136_21BazaProjekta
{
    partial class Najprodavanije
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
            this.lblNajprodavanije = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNajprodavanije
            // 
            this.lblNajprodavanije.AutoSize = true;
            this.lblNajprodavanije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNajprodavanije.Location = new System.Drawing.Point(395, 45);
            this.lblNajprodavanije.Name = "lblNajprodavanije";
            this.lblNajprodavanije.Size = new System.Drawing.Size(60, 24);
            this.lblNajprodavanije.TabIndex = 1;
            this.lblNajprodavanije.Text = "label1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::NRT136_21BazaProjekta.Properties.Resources.Pretraga;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(556, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 37);
            this.button3.TabIndex = 24;
            this.button3.Text = "Filtriraj";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateDo
            // 
            this.dateDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDo.Location = new System.Drawing.Point(334, 91);
            this.dateDo.Name = "dateDo";
            this.dateDo.Size = new System.Drawing.Size(200, 26);
            this.dateDo.TabIndex = 23;
            this.dateDo.ValueChanged += new System.EventHandler(this.dateDo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Do";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateOd
            // 
            this.dateOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOd.Location = new System.Drawing.Point(96, 91);
            this.dateOd.Name = "dateOd";
            this.dateOd.Size = new System.Drawing.Size(200, 26);
            this.dateOd.TabIndex = 21;
            this.dateOd.ValueChanged += new System.EventHandler(this.dateOd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Datum Od";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Najprodavanije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(997, 635);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dateDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNajprodavanije);
            this.Name = "Najprodavanije";
            this.Text = "Najprodavanije";
            this.Load += new System.EventHandler(this.Najprodavanije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNajprodavanije;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOd;
        private System.Windows.Forms.Label label2;
    }
}