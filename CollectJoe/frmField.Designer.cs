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
            this.components = new System.ComponentModel.Container();
            this.pnlFeld = new System.Windows.Forms.Panel();
            this.btnSpielStarten = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPunktestand = new System.Windows.Forms.Label();
            this.txtPunktestand = new System.Windows.Forms.TextBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlFeld
            // 
            this.pnlFeld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlFeld.Location = new System.Drawing.Point(13, 13);
            this.pnlFeld.Name = "pnlFeld";
            this.pnlFeld.Size = new System.Drawing.Size(839, 431);
            this.pnlFeld.TabIndex = 0;
            // 
            // btnSpielStarten
            // 
            this.btnSpielStarten.Location = new System.Drawing.Point(12, 459);
            this.btnSpielStarten.Name = "btnSpielStarten";
            this.btnSpielStarten.Size = new System.Drawing.Size(125, 30);
            this.btnSpielStarten.TabIndex = 9;
            this.btnSpielStarten.Text = "Spiel Starten";
            this.btnSpielStarten.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(727, 459);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 30);
            this.label.TabIndex = 10;
            this.label.Text = "Einstellungen";
            this.label.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Rangliste anzeigen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPunktestand
            // 
            this.lblPunktestand.AutoSize = true;
            this.lblPunktestand.Location = new System.Drawing.Point(205, 468);
            this.lblPunktestand.Name = "lblPunktestand";
            this.lblPunktestand.Size = new System.Drawing.Size(67, 13);
            this.lblPunktestand.TabIndex = 12;
            this.lblPunktestand.Text = "Punktestand";
            // 
            // txtPunktestand
            // 
            this.txtPunktestand.Enabled = false;
            this.txtPunktestand.Location = new System.Drawing.Point(278, 465);
            this.txtPunktestand.Name = "txtPunktestand";
            this.txtPunktestand.Size = new System.Drawing.Size(100, 20);
            this.txtPunktestand.TabIndex = 13;
            this.txtPunktestand.Text = "0";
            // 
            // frmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 501);
            this.Controls.Add(this.txtPunktestand);
            this.Controls.Add(this.lblPunktestand);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnSpielStarten);
            this.Controls.Add(this.pnlFeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmField";
            this.Text = "CollectJoe";
            this.Load += new System.EventHandler(this.frmField_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFeld;
        private System.Windows.Forms.Button btnSpielStarten;
        private System.Windows.Forms.Button label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPunktestand;
        private System.Windows.Forms.TextBox txtPunktestand;
        private System.Windows.Forms.Timer tmr;
    }
}