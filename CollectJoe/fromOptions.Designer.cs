namespace CollectJoe
{
    partial class frmOptionen
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
            this.gpxSpielfeld = new System.Windows.Forms.GroupBox();
            this.lblSpielfeld = new System.Windows.Forms.Label();
            this.gpxSpielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxSpielfeld
            // 
            this.gpxSpielfeld.Controls.Add(this.lblSpielfeld);
            this.gpxSpielfeld.Location = new System.Drawing.Point(53, 71);
            this.gpxSpielfeld.Name = "gpxSpielfeld";
            this.gpxSpielfeld.Size = new System.Drawing.Size(257, 163);
            this.gpxSpielfeld.TabIndex = 0;
            this.gpxSpielfeld.TabStop = false;
            // 
            // lblSpielfeld
            // 
            this.lblSpielfeld.AutoSize = true;
            this.lblSpielfeld.Location = new System.Drawing.Point(7, 20);
            this.lblSpielfeld.Name = "lblSpielfeld";
            this.lblSpielfeld.Size = new System.Drawing.Size(35, 13);
            this.lblSpielfeld.TabIndex = 0;
            this.lblSpielfeld.Text = "label1";
            // 
            // frmOptionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 501);
            this.Controls.Add(this.gpxSpielfeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptionen";
            this.Text = "Optionen";
            this.gpxSpielfeld.ResumeLayout(false);
            this.gpxSpielfeld.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxSpielfeld;
        private System.Windows.Forms.Label lblSpielfeld;
    }
}