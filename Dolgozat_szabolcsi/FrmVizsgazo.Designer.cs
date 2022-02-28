
namespace Dolgozat_szabolcsi
{
    partial class FrmVizsgazo
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
            this.idtb = new System.Windows.Forms.TextBox();
            this.nev = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.szul = new System.Windows.Forms.TextBox();
            this.Torles = new System.Windows.Forms.Button();
            this.modostit = new System.Windows.Forms.Button();
            this.uj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(188, 83);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(163, 20);
            this.idtb.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(188, 140);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(163, 20);
            this.nev.TabIndex = 1;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(188, 208);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(163, 20);
            this.tel.TabIndex = 2;
            // 
            // szul
            // 
            this.szul.Location = new System.Drawing.Point(188, 271);
            this.szul.Name = "szul";
            this.szul.Size = new System.Drawing.Size(163, 20);
            this.szul.TabIndex = 3;
            // 
            // Torles
            // 
            this.Torles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Torles.Location = new System.Drawing.Point(501, 46);
            this.Torles.Name = "Torles";
            this.Torles.Size = new System.Drawing.Size(93, 93);
            this.Torles.TabIndex = 4;
            this.Torles.Text = "Törlés";
            this.Torles.UseVisualStyleBackColor = true;
            this.Torles.Click += new System.EventHandler(this.Torles_Click);
            // 
            // modostit
            // 
            this.modostit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.modostit.Location = new System.Drawing.Point(501, 154);
            this.modostit.Name = "modostit";
            this.modostit.Size = new System.Drawing.Size(93, 93);
            this.modostit.TabIndex = 5;
            this.modostit.Text = "Módosítás";
            this.modostit.UseVisualStyleBackColor = true;
            this.modostit.Click += new System.EventHandler(this.modostit_Click);
            // 
            // uj
            // 
            this.uj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uj.Location = new System.Drawing.Point(501, 262);
            this.uj.Name = "uj";
            this.uj.Size = new System.Drawing.Size(93, 93);
            this.uj.TabIndex = 6;
            this.uj.Text = "Új jelentkező";
            this.uj.UseVisualStyleBackColor = true;
            this.uj.Click += new System.EventHandler(this.uj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Születési dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefonszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(ID)";
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uj);
            this.Controls.Add(this.modostit);
            this.Controls.Add(this.Torles);
            this.Controls.Add(this.szul);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.idtb);
            this.Name = "FrmVizsgazo";
            this.Text = "FrmVizsgazo";
            this.Load += new System.EventHandler(this.FrmVizsgazo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox szul;
        private System.Windows.Forms.Button Torles;
        private System.Windows.Forms.Button modostit;
        private System.Windows.Forms.Button uj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}