namespace CollectJoe
{
    partial class frmEditScore
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
            this.lblEintragen = new System.Windows.Forms.Label();
            this.lblPunktzahl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDeinName = new System.Windows.Forms.Label();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEintragen
            // 
            this.lblEintragen.AutoSize = true;
            this.lblEintragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblEintragen.Location = new System.Drawing.Point(12, 26);
            this.lblEintragen.Name = "lblEintragen";
            this.lblEintragen.Size = new System.Drawing.Size(139, 31);
            this.lblEintragen.TabIndex = 10;
            this.lblEintragen.Text = "Eintragen";
            // 
            // lblPunktzahl
            // 
            this.lblPunktzahl.AutoSize = true;
            this.lblPunktzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPunktzahl.Location = new System.Drawing.Point(12, 74);
            this.lblPunktzahl.Name = "lblPunktzahl";
            this.lblPunktzahl.Size = new System.Drawing.Size(29, 31);
            this.lblPunktzahl.TabIndex = 11;
            this.lblPunktzahl.Text = "0";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(104, 20);
            this.txtName.TabIndex = 13;
            // 
            // lblDeinName
            // 
            this.lblDeinName.AutoSize = true;
            this.lblDeinName.Location = new System.Drawing.Point(15, 143);
            this.lblDeinName.Name = "lblDeinName";
            this.lblDeinName.Size = new System.Drawing.Size(63, 13);
            this.lblDeinName.TabIndex = 12;
            this.lblDeinName.Text = "Dein Name:";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(18, 187);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(104, 30);
            this.btnSpeichern.TabIndex = 14;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Location = new System.Drawing.Point(129, 187);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(104, 30);
            this.btnAbbrechen.TabIndex = 15;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // frmEditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 233);
            this.Controls.Add(this.btnAbbrechen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDeinName);
            this.Controls.Add(this.lblPunktzahl);
            this.Controls.Add(this.lblEintragen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditScore";
            this.Text = "Resultat Speichern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEintragen;
        private System.Windows.Forms.Label lblPunktzahl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeinName;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Button btnAbbrechen;
    }
}