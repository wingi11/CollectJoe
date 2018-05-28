namespace CollectJoe
{
    partial class frmScoreList
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
            this.lblRangliste = new System.Windows.Forms.Label();
            this.txtRangliste = new System.Windows.Forms.TextBox();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRangliste
            // 
            this.lblRangliste.AutoSize = true;
            this.lblRangliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblRangliste.Location = new System.Drawing.Point(12, 47);
            this.lblRangliste.Name = "lblRangliste";
            this.lblRangliste.Size = new System.Drawing.Size(137, 31);
            this.lblRangliste.TabIndex = 10;
            this.lblRangliste.Text = "Rangliste";
            // 
            // txtRangliste
            // 
            this.txtRangliste.Location = new System.Drawing.Point(18, 92);
            this.txtRangliste.Multiline = true;
            this.txtRangliste.Name = "txtRangliste";
            this.txtRangliste.ReadOnly = true;
            this.txtRangliste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRangliste.Size = new System.Drawing.Size(274, 286);
            this.txtRangliste.TabIndex = 11;
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(18, 393);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(125, 30);
            this.btnSchliessen.TabIndex = 12;
            this.btnSchliessen.Text = "Schliessen";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            // 
            // frmScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 469);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.txtRangliste);
            this.Controls.Add(this.lblRangliste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmScoreList";
            this.Text = "Rangliste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRangliste;
        private System.Windows.Forms.TextBox txtRangliste;
        private System.Windows.Forms.Button btnSchliessen;
    }
}