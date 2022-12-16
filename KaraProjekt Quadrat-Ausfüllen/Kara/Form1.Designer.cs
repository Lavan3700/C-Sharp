namespace KaraProjekt
{
    partial class Form1
    {
        private KaraWorld kara;
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.kara = new KaraProjekt.KaraWorld();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Teal;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnRun.FlatAppearance.BorderSize = 4;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRun.Location = new System.Drawing.Point(500, 1);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(182, 32);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Programmablauf starten";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.BackColor = System.Drawing.Color.Teal;
            this.btnEnde.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnde.FlatAppearance.BorderSize = 4;
            this.btnEnde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnde.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnde.Location = new System.Drawing.Point(688, 1);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(84, 32);
            this.btnEnde.TabIndex = 2;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = false;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // kara
            // 
            this.kara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kara.Location = new System.Drawing.Point(2, 39);
            this.kara.Name = "kara";
            this.kara.Size = new System.Drawing.Size(761, 576);
            this.kara.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eingaben für die Aufgaben:";
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(154, 11);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(37, 20);
            this.txtEingabe.TabIndex = 10;
            this.txtEingabe.Text = "0";
            this.txtEingabe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEingabe.TextChanged += new System.EventHandler(this.txtEingabe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 9);
            this.label3.TabIndex = 13;
            this.label3.Text = "by Barbara Bielawski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(775, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.kara);
            this.Name = "Form1";
            this.Text = "Kara Programmierumgebung Version 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Label label3;
    }
}

