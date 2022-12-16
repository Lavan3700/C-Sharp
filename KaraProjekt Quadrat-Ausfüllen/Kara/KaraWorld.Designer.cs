namespace KaraProjekt
{
    partial class KaraWorld
    {
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWorld = new System.Windows.Forms.Panel();
            this.lstZellinhalt = new System.Windows.Forms.ListBox();
            this.btnPositioniere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZeile = new System.Windows.Forms.TextBox();
            this.txtSpalte = new System.Windows.Forms.TextBox();
            this.btnDrehe = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSuperSchnell = new System.Windows.Forms.RadioButton();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbSchnell = new System.Windows.Forms.RadioButton();
            this.btnSpeichereWorld = new System.Windows.Forms.Button();
            this.btnLadeWorld = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorld
            // 
            this.pnlWorld.Location = new System.Drawing.Point(140, 61);
            this.pnlWorld.Name = "pnlWorld";
            this.pnlWorld.Size = new System.Drawing.Size(573, 482);
            this.pnlWorld.TabIndex = 0;
            // 
            // lstZellinhalt
            // 
            this.lstZellinhalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstZellinhalt.ForeColor = System.Drawing.Color.Teal;
            this.lstZellinhalt.FormattingEnabled = true;
            this.lstZellinhalt.ItemHeight = 15;
            this.lstZellinhalt.Items.AddRange(new object[] {
            "Leer",
            "Baum",
            "Kleeblatt"});
            this.lstZellinhalt.Location = new System.Drawing.Point(3, 133);
            this.lstZellinhalt.Name = "lstZellinhalt";
            this.lstZellinhalt.Size = new System.Drawing.Size(108, 49);
            this.lstZellinhalt.TabIndex = 3;
            this.lstZellinhalt.SelectedIndexChanged += new System.EventHandler(this.lstZellinhalt_SelectedIndexChanged);
            // 
            // btnPositioniere
            // 
            this.btnPositioniere.BackColor = System.Drawing.Color.Teal;
            this.btnPositioniere.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPositioniere.FlatAppearance.BorderSize = 4;
            this.btnPositioniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositioniere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositioniere.Location = new System.Drawing.Point(233, 1);
            this.btnPositioniere.Name = "btnPositioniere";
            this.btnPositioniere.Size = new System.Drawing.Size(139, 32);
            this.btnPositioniere.TabIndex = 4;
            this.btnPositioniere.Text = "positioniere Kara";
            this.btnPositioniere.UseVisualStyleBackColor = false;
            this.btnPositioniere.Click += new System.EventHandler(this.btnPositioniere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zeile:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spalte:";
            // 
            // txtZeile
            // 
            this.txtZeile.Location = new System.Drawing.Point(266, 35);
            this.txtZeile.Name = "txtZeile";
            this.txtZeile.Size = new System.Drawing.Size(29, 20);
            this.txtZeile.TabIndex = 1;
            this.txtZeile.Text = "2";
            this.txtZeile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpalte
            // 
            this.txtSpalte.Location = new System.Drawing.Point(339, 35);
            this.txtSpalte.Name = "txtSpalte";
            this.txtSpalte.Size = new System.Drawing.Size(29, 20);
            this.txtSpalte.TabIndex = 1;
            this.txtSpalte.Text = "3";
            this.txtSpalte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDrehe
            // 
            this.btnDrehe.BackColor = System.Drawing.Color.Teal;
            this.btnDrehe.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDrehe.FlatAppearance.BorderSize = 4;
            this.btnDrehe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrehe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrehe.Location = new System.Drawing.Point(3, 1);
            this.btnDrehe.Name = "btnDrehe";
            this.btnDrehe.Size = new System.Drawing.Size(99, 32);
            this.btnDrehe.TabIndex = 7;
            this.btnDrehe.Text = "drehe Kara";
            this.btnDrehe.UseVisualStyleBackColor = false;
            this.btnDrehe.Click += new System.EventHandler(this.btnDrehe_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Teal;
            this.btnMove.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMove.FlatAppearance.BorderSize = 4;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(111, 1);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(113, 32);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "bewege Kara";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSuperSchnell);
            this.groupBox2.Controls.Add(this.rdbNormal);
            this.groupBox2.Controls.Add(this.rdbSchnell);
            this.groupBox2.Location = new System.Drawing.Point(3, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 79);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geschwindigkeit";
            // 
            // rdbSuperSchnell
            // 
            this.rdbSuperSchnell.AutoSize = true;
            this.rdbSuperSchnell.Location = new System.Drawing.Point(6, 54);
            this.rdbSuperSchnell.Name = "rdbSuperSchnell";
            this.rdbSuperSchnell.Size = new System.Drawing.Size(87, 17);
            this.rdbSuperSchnell.TabIndex = 2;
            this.rdbSuperSchnell.Text = "super-schnell";
            this.rdbSuperSchnell.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Location = new System.Drawing.Point(6, 14);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(56, 17);
            this.rdbNormal.TabIndex = 1;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            this.rdbNormal.CheckedChanged += new System.EventHandler(this.rdbNormal_CheckedChanged);
            // 
            // rdbSchnell
            // 
            this.rdbSchnell.AutoSize = true;
            this.rdbSchnell.Location = new System.Drawing.Point(6, 34);
            this.rdbSchnell.Name = "rdbSchnell";
            this.rdbSchnell.Size = new System.Drawing.Size(58, 17);
            this.rdbSchnell.TabIndex = 0;
            this.rdbSchnell.Text = "schnell";
            this.rdbSchnell.UseVisualStyleBackColor = true;
            this.rdbSchnell.CheckedChanged += new System.EventHandler(this.rdbSchnell_CheckedChanged);
            // 
            // btnSpeichereWorld
            // 
            this.btnSpeichereWorld.BackColor = System.Drawing.Color.Teal;
            this.btnSpeichereWorld.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSpeichereWorld.FlatAppearance.BorderSize = 4;
            this.btnSpeichereWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeichereWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeichereWorld.Location = new System.Drawing.Point(381, 1);
            this.btnSpeichereWorld.Name = "btnSpeichereWorld";
            this.btnSpeichereWorld.Size = new System.Drawing.Size(142, 32);
            this.btnSpeichereWorld.TabIndex = 9;
            this.btnSpeichereWorld.Text = "Speichere World";
            this.btnSpeichereWorld.UseVisualStyleBackColor = false;
            this.btnSpeichereWorld.Click += new System.EventHandler(this.btnSpeicherWorld_Click);
            // 
            // btnLadeWorld
            // 
            this.btnLadeWorld.BackColor = System.Drawing.Color.Teal;
            this.btnLadeWorld.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnLadeWorld.FlatAppearance.BorderSize = 4;
            this.btnLadeWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLadeWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLadeWorld.Location = new System.Drawing.Point(532, 1);
            this.btnLadeWorld.Name = "btnLadeWorld";
            this.btnLadeWorld.Size = new System.Drawing.Size(124, 32);
            this.btnLadeWorld.TabIndex = 9;
            this.btnLadeWorld.Text = "Lade World";
            this.btnLadeWorld.UseVisualStyleBackColor = false;
            this.btnLadeWorld.Click += new System.EventHandler(this.btnLadeWorld_Click);
            // 
            // KaraWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSpeichereWorld);
            this.Controls.Add(this.btnLadeWorld);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnDrehe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPositioniere);
            this.Controls.Add(this.lstZellinhalt);
            this.Controls.Add(this.txtSpalte);
            this.Controls.Add(this.txtZeile);
            this.Controls.Add(this.pnlWorld);
            this.Name = "KaraWorld";
            this.Size = new System.Drawing.Size(725, 596);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorld;
        private System.Windows.Forms.ListBox lstZellinhalt;
        private System.Windows.Forms.Button btnPositioniere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZeile;
        private System.Windows.Forms.TextBox txtSpalte;
        private System.Windows.Forms.Button btnDrehe;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbSchnell;
        private System.Windows.Forms.Button btnSpeichereWorld;
        private System.Windows.Forms.Button btnLadeWorld;
        private System.Windows.Forms.RadioButton rdbSuperSchnell;
    }
}
