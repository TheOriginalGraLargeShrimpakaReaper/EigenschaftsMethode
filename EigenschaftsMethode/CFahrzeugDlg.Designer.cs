namespace EigenschaftsMethode
{
    partial class CFahrzeugDlg
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHubraum = new System.Windows.Forms.TextBox();
            this.txtPassagiere = new System.Windows.Forms.TextBox();
            this.txtKmStand = new System.Windows.Forms.TextBox();
            this.lblHubraum = new System.Windows.Forms.Label();
            this.lblPassagiere = new System.Windows.Forms.Label();
            this.lbKmStand = new System.Windows.Forms.Label();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.btoEigenschaftenSetzen = new System.Windows.Forms.Button();
            this.btoAnzeigen = new System.Windows.Forms.Button();
            this.btoSchneller = new System.Windows.Forms.Button();
            this.btoLangsamer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHubraum
            // 
            this.txtHubraum.Location = new System.Drawing.Point(113, 38);
            this.txtHubraum.Name = "txtHubraum";
            this.txtHubraum.Size = new System.Drawing.Size(100, 20);
            this.txtHubraum.TabIndex = 0;
            // 
            // txtPassagiere
            // 
            this.txtPassagiere.Location = new System.Drawing.Point(113, 64);
            this.txtPassagiere.Name = "txtPassagiere";
            this.txtPassagiere.Size = new System.Drawing.Size(100, 20);
            this.txtPassagiere.TabIndex = 1;
            // 
            // txtKmStand
            // 
            this.txtKmStand.Location = new System.Drawing.Point(113, 90);
            this.txtKmStand.Name = "txtKmStand";
            this.txtKmStand.Size = new System.Drawing.Size(100, 20);
            this.txtKmStand.TabIndex = 2;
            // 
            // lblHubraum
            // 
            this.lblHubraum.AutoSize = true;
            this.lblHubraum.Location = new System.Drawing.Point(12, 38);
            this.lblHubraum.Name = "lblHubraum";
            this.lblHubraum.Size = new System.Drawing.Size(50, 13);
            this.lblHubraum.TabIndex = 3;
            this.lblHubraum.Text = "Hubraum";
            // 
            // lblPassagiere
            // 
            this.lblPassagiere.AutoSize = true;
            this.lblPassagiere.Location = new System.Drawing.Point(15, 64);
            this.lblPassagiere.Name = "lblPassagiere";
            this.lblPassagiere.Size = new System.Drawing.Size(59, 13);
            this.lblPassagiere.TabIndex = 4;
            this.lblPassagiere.Text = "Passagiere";
            // 
            // lbKmStand
            // 
            this.lbKmStand.AutoSize = true;
            this.lbKmStand.Location = new System.Drawing.Point(15, 90);
            this.lbKmStand.Name = "lbKmStand";
            this.lbKmStand.Size = new System.Drawing.Size(53, 13);
            this.lbKmStand.TabIndex = 5;
            this.lbKmStand.Text = "Km Stand";
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(15, 120);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(16, 13);
            this.lblAnzeige.TabIndex = 6;
            this.lblAnzeige.Text = "...";
            // 
            // btoEigenschaftenSetzen
            // 
            this.btoEigenschaftenSetzen.Location = new System.Drawing.Point(220, 38);
            this.btoEigenschaftenSetzen.Name = "btoEigenschaftenSetzen";
            this.btoEigenschaftenSetzen.Size = new System.Drawing.Size(75, 23);
            this.btoEigenschaftenSetzen.TabIndex = 7;
            this.btoEigenschaftenSetzen.Text = "setzen";
            this.btoEigenschaftenSetzen.UseVisualStyleBackColor = true;
            this.btoEigenschaftenSetzen.Click += new System.EventHandler(this.btoEigenschaftenSetzen_Click);
            // 
            // btoAnzeigen
            // 
            this.btoAnzeigen.Location = new System.Drawing.Point(220, 64);
            this.btoAnzeigen.Name = "btoAnzeigen";
            this.btoAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.btoAnzeigen.TabIndex = 8;
            this.btoAnzeigen.Text = "Anzeigen";
            this.btoAnzeigen.UseVisualStyleBackColor = true;
            this.btoAnzeigen.Click += new System.EventHandler(this.btoAnzeigen_Click);
            // 
            // btoSchneller
            // 
            this.btoSchneller.Location = new System.Drawing.Point(220, 90);
            this.btoSchneller.Name = "btoSchneller";
            this.btoSchneller.Size = new System.Drawing.Size(75, 23);
            this.btoSchneller.TabIndex = 9;
            this.btoSchneller.Text = "schneller";
            this.btoSchneller.UseVisualStyleBackColor = true;
            this.btoSchneller.Click += new System.EventHandler(this.btoSchneller_Click);
            // 
            // btoLangsamer
            // 
            this.btoLangsamer.Location = new System.Drawing.Point(220, 120);
            this.btoLangsamer.Name = "btoLangsamer";
            this.btoLangsamer.Size = new System.Drawing.Size(75, 23);
            this.btoLangsamer.TabIndex = 10;
            this.btoLangsamer.Text = "langsamer";
            this.btoLangsamer.UseVisualStyleBackColor = true;
            this.btoLangsamer.Click += new System.EventHandler(this.btoLangsamer_Click);
            // 
            // CFahrzeugDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 200);
            this.Controls.Add(this.btoLangsamer);
            this.Controls.Add(this.btoSchneller);
            this.Controls.Add(this.btoAnzeigen);
            this.Controls.Add(this.btoEigenschaftenSetzen);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.lbKmStand);
            this.Controls.Add(this.lblPassagiere);
            this.Controls.Add(this.lblHubraum);
            this.Controls.Add(this.txtKmStand);
            this.Controls.Add(this.txtPassagiere);
            this.Controls.Add(this.txtHubraum);
            this.Name = "CFahrzeugDlg";
            this.Text = "Eigenschaftsmethode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHubraum;
        private System.Windows.Forms.TextBox txtPassagiere;
        private System.Windows.Forms.TextBox txtKmStand;
        private System.Windows.Forms.Label lblHubraum;
        private System.Windows.Forms.Label lblPassagiere;
        private System.Windows.Forms.Label lbKmStand;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button btoEigenschaftenSetzen;
        private System.Windows.Forms.Button btoAnzeigen;
        private System.Windows.Forms.Button btoSchneller;
        private System.Windows.Forms.Button btoLangsamer;
    }
}

