namespace CollectJoe
{
    partial class frmField
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpxSpielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxSpielfeld
            // 
            this.gpxSpielfeld.Controls.Add(this.label2);
            this.gpxSpielfeld.Location = new System.Drawing.Point(28, 85);
            this.gpxSpielfeld.Name = "gpxSpielfeld";
            this.gpxSpielfeld.Size = new System.Drawing.Size(200, 100);
            this.gpxSpielfeld.TabIndex = 0;
            this.gpxSpielfeld.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Einstellungen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpxSpielfeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmField";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmField_Load);
            this.gpxSpielfeld.ResumeLayout(false);
            this.gpxSpielfeld.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxSpielfeld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}