﻿namespace CollectJoe
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
            this.txtBoxenVertikal = new System.Windows.Forms.TextBox();
            this.txtBoxenHorizontal = new System.Windows.Forms.TextBox();
            this.lblBoxenVertikal = new System.Windows.Forms.Label();
            this.lblBoxenHorizontal = new System.Windows.Forms.Label();
            this.lblSpielfeld = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxtyp3 = new System.Windows.Forms.TextBox();
            this.lblBoxtyp3 = new System.Windows.Forms.Label();
            this.txtBoxtyp2 = new System.Windows.Forms.TextBox();
            this.txtBoxtyp1 = new System.Windows.Forms.TextBox();
            this.lblBoxtyp2 = new System.Windows.Forms.Label();
            this.lblBoxtyp1 = new System.Windows.Forms.Label();
            this.lblWertungen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoxtyp3Farbe = new System.Windows.Forms.Button();
            this.lblBoxtyp3Farbe = new System.Windows.Forms.Label();
            this.btnBoxtyp2Farbe = new System.Windows.Forms.Button();
            this.lblBoxtyp2Farbe = new System.Windows.Forms.Label();
            this.btnSpielfeldFarbe = new System.Windows.Forms.Button();
            this.btnBoxenFarbe = new System.Windows.Forms.Button();
            this.btnBoxtyp1Farbe = new System.Windows.Forms.Button();
            this.lblBoxtyp1Farbe = new System.Windows.Forms.Label();
            this.lblSpielfeldFarbe = new System.Windows.Forms.Label();
            this.lblBoxen = new System.Windows.Forms.Label();
            this.lblFarben = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.lblEinstellungen = new System.Windows.Forms.Label();
            this.gpxSpielfeld.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxSpielfeld
            // 
            this.gpxSpielfeld.Controls.Add(this.txtBoxenVertikal);
            this.gpxSpielfeld.Controls.Add(this.txtBoxenHorizontal);
            this.gpxSpielfeld.Controls.Add(this.lblBoxenVertikal);
            this.gpxSpielfeld.Controls.Add(this.lblBoxenHorizontal);
            this.gpxSpielfeld.Controls.Add(this.lblSpielfeld);
            this.gpxSpielfeld.Location = new System.Drawing.Point(53, 71);
            this.gpxSpielfeld.Name = "gpxSpielfeld";
            this.gpxSpielfeld.Size = new System.Drawing.Size(274, 146);
            this.gpxSpielfeld.TabIndex = 0;
            this.gpxSpielfeld.TabStop = false;
            // 
            // txtBoxenVertikal
            // 
            this.txtBoxenVertikal.Location = new System.Drawing.Point(123, 92);
            this.txtBoxenVertikal.Name = "txtBoxenVertikal";
            this.txtBoxenVertikal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxenVertikal.TabIndex = 4;
            this.txtBoxenVertikal.Text = "10";
            this.txtBoxenVertikal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxenHorizontal
            // 
            this.txtBoxenHorizontal.Location = new System.Drawing.Point(123, 62);
            this.txtBoxenHorizontal.Name = "txtBoxenHorizontal";
            this.txtBoxenHorizontal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxenHorizontal.TabIndex = 3;
            this.txtBoxenHorizontal.Text = "20";
            this.txtBoxenHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBoxenVertikal
            // 
            this.lblBoxenVertikal.AutoSize = true;
            this.lblBoxenVertikal.Location = new System.Drawing.Point(9, 95);
            this.lblBoxenVertikal.Name = "lblBoxenVertikal";
            this.lblBoxenVertikal.Size = new System.Drawing.Size(74, 13);
            this.lblBoxenVertikal.TabIndex = 2;
            this.lblBoxenVertikal.Text = "Boxen vertikal";
            // 
            // lblBoxenHorizontal
            // 
            this.lblBoxenHorizontal.AutoSize = true;
            this.lblBoxenHorizontal.Location = new System.Drawing.Point(9, 69);
            this.lblBoxenHorizontal.Name = "lblBoxenHorizontal";
            this.lblBoxenHorizontal.Size = new System.Drawing.Size(85, 13);
            this.lblBoxenHorizontal.TabIndex = 1;
            this.lblBoxenHorizontal.Text = "Boxen horizontal";
            // 
            // lblSpielfeld
            // 
            this.lblSpielfeld.AutoSize = true;
            this.lblSpielfeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielfeld.Location = new System.Drawing.Point(7, 20);
            this.lblSpielfeld.Name = "lblSpielfeld";
            this.lblSpielfeld.Size = new System.Drawing.Size(118, 29);
            this.lblSpielfeld.TabIndex = 0;
            this.lblSpielfeld.Text = "Spielfeld";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxtyp3);
            this.groupBox1.Controls.Add(this.lblBoxtyp3);
            this.groupBox1.Controls.Add(this.txtBoxtyp2);
            this.groupBox1.Controls.Add(this.txtBoxtyp1);
            this.groupBox1.Controls.Add(this.lblBoxtyp2);
            this.groupBox1.Controls.Add(this.lblBoxtyp1);
            this.groupBox1.Controls.Add(this.lblWertungen);
            this.groupBox1.Location = new System.Drawing.Point(53, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtBoxtyp3
            // 
            this.txtBoxtyp3.Location = new System.Drawing.Point(123, 120);
            this.txtBoxtyp3.Name = "txtBoxtyp3";
            this.txtBoxtyp3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxtyp3.TabIndex = 6;
            this.txtBoxtyp3.Text = "-50";
            this.txtBoxtyp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBoxtyp3
            // 
            this.lblBoxtyp3.AutoSize = true;
            this.lblBoxtyp3.Location = new System.Drawing.Point(9, 120);
            this.lblBoxtyp3.Name = "lblBoxtyp3";
            this.lblBoxtyp3.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp3.TabIndex = 5;
            this.lblBoxtyp3.Text = "3. Boxtyp";
            // 
            // txtBoxtyp2
            // 
            this.txtBoxtyp2.Location = new System.Drawing.Point(123, 92);
            this.txtBoxtyp2.Name = "txtBoxtyp2";
            this.txtBoxtyp2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxtyp2.TabIndex = 4;
            this.txtBoxtyp2.Text = "10";
            this.txtBoxtyp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxtyp1
            // 
            this.txtBoxtyp1.Location = new System.Drawing.Point(123, 62);
            this.txtBoxtyp1.Name = "txtBoxtyp1";
            this.txtBoxtyp1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxtyp1.TabIndex = 3;
            this.txtBoxtyp1.Text = "1";
            this.txtBoxtyp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBoxtyp2
            // 
            this.lblBoxtyp2.AutoSize = true;
            this.lblBoxtyp2.Location = new System.Drawing.Point(9, 95);
            this.lblBoxtyp2.Name = "lblBoxtyp2";
            this.lblBoxtyp2.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp2.TabIndex = 2;
            this.lblBoxtyp2.Text = "2. Boxtyp";
            // 
            // lblBoxtyp1
            // 
            this.lblBoxtyp1.AutoSize = true;
            this.lblBoxtyp1.Location = new System.Drawing.Point(9, 69);
            this.lblBoxtyp1.Name = "lblBoxtyp1";
            this.lblBoxtyp1.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp1.TabIndex = 1;
            this.lblBoxtyp1.Text = "1. Boxtyp";
            // 
            // lblWertungen
            // 
            this.lblWertungen.AutoSize = true;
            this.lblWertungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWertungen.Location = new System.Drawing.Point(7, 20);
            this.lblWertungen.Name = "lblWertungen";
            this.lblWertungen.Size = new System.Drawing.Size(139, 29);
            this.lblWertungen.TabIndex = 0;
            this.lblWertungen.Text = "Wertungen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBoxtyp3Farbe);
            this.groupBox2.Controls.Add(this.lblBoxtyp3Farbe);
            this.groupBox2.Controls.Add(this.btnBoxtyp2Farbe);
            this.groupBox2.Controls.Add(this.lblBoxtyp2Farbe);
            this.groupBox2.Controls.Add(this.btnSpielfeldFarbe);
            this.groupBox2.Controls.Add(this.btnBoxenFarbe);
            this.groupBox2.Controls.Add(this.btnBoxtyp1Farbe);
            this.groupBox2.Controls.Add(this.lblBoxtyp1Farbe);
            this.groupBox2.Controls.Add(this.lblSpielfeldFarbe);
            this.groupBox2.Controls.Add(this.lblBoxen);
            this.groupBox2.Controls.Add(this.lblFarben);
            this.groupBox2.Location = new System.Drawing.Point(366, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 355);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnBoxtyp3Farbe
            // 
            this.btnBoxtyp3Farbe.BackColor = System.Drawing.Color.Red;
            this.btnBoxtyp3Farbe.Location = new System.Drawing.Point(123, 290);
            this.btnBoxtyp3Farbe.Name = "btnBoxtyp3Farbe";
            this.btnBoxtyp3Farbe.Size = new System.Drawing.Size(105, 23);
            this.btnBoxtyp3Farbe.TabIndex = 13;
            this.btnBoxtyp3Farbe.UseVisualStyleBackColor = false;
            this.btnBoxtyp3Farbe.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblBoxtyp3Farbe
            // 
            this.lblBoxtyp3Farbe.AutoSize = true;
            this.lblBoxtyp3Farbe.Location = new System.Drawing.Point(9, 296);
            this.lblBoxtyp3Farbe.Name = "lblBoxtyp3Farbe";
            this.lblBoxtyp3Farbe.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp3Farbe.TabIndex = 12;
            this.lblBoxtyp3Farbe.Text = "3. Boxtyp";
            // 
            // btnBoxtyp2Farbe
            // 
            this.btnBoxtyp2Farbe.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBoxtyp2Farbe.Location = new System.Drawing.Point(123, 261);
            this.btnBoxtyp2Farbe.Name = "btnBoxtyp2Farbe";
            this.btnBoxtyp2Farbe.Size = new System.Drawing.Size(105, 23);
            this.btnBoxtyp2Farbe.TabIndex = 11;
            this.btnBoxtyp2Farbe.UseVisualStyleBackColor = false;
            this.btnBoxtyp2Farbe.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblBoxtyp2Farbe
            // 
            this.lblBoxtyp2Farbe.AutoSize = true;
            this.lblBoxtyp2Farbe.Location = new System.Drawing.Point(9, 267);
            this.lblBoxtyp2Farbe.Name = "lblBoxtyp2Farbe";
            this.lblBoxtyp2Farbe.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp2Farbe.TabIndex = 10;
            this.lblBoxtyp2Farbe.Text = "2. Boxtyp";
            // 
            // btnSpielfeldFarbe
            // 
            this.btnSpielfeldFarbe.BackColor = System.Drawing.Color.Gray;
            this.btnSpielfeldFarbe.Location = new System.Drawing.Point(123, 90);
            this.btnSpielfeldFarbe.Name = "btnSpielfeldFarbe";
            this.btnSpielfeldFarbe.Size = new System.Drawing.Size(105, 23);
            this.btnSpielfeldFarbe.TabIndex = 9;
            this.btnSpielfeldFarbe.UseVisualStyleBackColor = false;
            this.btnSpielfeldFarbe.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBoxenFarbe
            // 
            this.btnBoxenFarbe.BackColor = System.Drawing.Color.LightGray;
            this.btnBoxenFarbe.Location = new System.Drawing.Point(123, 60);
            this.btnBoxenFarbe.Name = "btnBoxenFarbe";
            this.btnBoxenFarbe.Size = new System.Drawing.Size(105, 23);
            this.btnBoxenFarbe.TabIndex = 8;
            this.btnBoxenFarbe.UseVisualStyleBackColor = false;
            this.btnBoxenFarbe.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBoxtyp1Farbe
            // 
            this.btnBoxtyp1Farbe.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBoxtyp1Farbe.Location = new System.Drawing.Point(123, 232);
            this.btnBoxtyp1Farbe.Name = "btnBoxtyp1Farbe";
            this.btnBoxtyp1Farbe.Size = new System.Drawing.Size(105, 23);
            this.btnBoxtyp1Farbe.TabIndex = 7;
            this.btnBoxtyp1Farbe.UseVisualStyleBackColor = false;
            this.btnBoxtyp1Farbe.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblBoxtyp1Farbe
            // 
            this.lblBoxtyp1Farbe.AutoSize = true;
            this.lblBoxtyp1Farbe.Location = new System.Drawing.Point(9, 238);
            this.lblBoxtyp1Farbe.Name = "lblBoxtyp1Farbe";
            this.lblBoxtyp1Farbe.Size = new System.Drawing.Size(51, 13);
            this.lblBoxtyp1Farbe.TabIndex = 5;
            this.lblBoxtyp1Farbe.Text = "1. Boxtyp";
            // 
            // lblSpielfeldFarbe
            // 
            this.lblSpielfeldFarbe.AutoSize = true;
            this.lblSpielfeldFarbe.Location = new System.Drawing.Point(9, 95);
            this.lblSpielfeldFarbe.Name = "lblSpielfeldFarbe";
            this.lblSpielfeldFarbe.Size = new System.Drawing.Size(47, 13);
            this.lblSpielfeldFarbe.TabIndex = 2;
            this.lblSpielfeldFarbe.Text = "Spielfeld";
            // 
            // lblBoxen
            // 
            this.lblBoxen.AutoSize = true;
            this.lblBoxen.Location = new System.Drawing.Point(9, 69);
            this.lblBoxen.Name = "lblBoxen";
            this.lblBoxen.Size = new System.Drawing.Size(37, 13);
            this.lblBoxen.TabIndex = 1;
            this.lblBoxen.Text = "Boxen";
            // 
            // lblFarben
            // 
            this.lblFarben.AutoSize = true;
            this.lblFarben.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarben.Location = new System.Drawing.Point(7, 20);
            this.lblFarben.Name = "lblFarben";
            this.lblFarben.Size = new System.Drawing.Size(96, 29);
            this.lblFarben.TabIndex = 0;
            this.lblFarben.Text = "Farben";
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(53, 448);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(125, 30);
            this.btnSpeichern.TabIndex = 8;
            this.btnSpeichern.Text = "Übernehmen";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // lblEinstellungen
            // 
            this.lblEinstellungen.AutoSize = true;
            this.lblEinstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblEinstellungen.Location = new System.Drawing.Point(60, 20);
            this.lblEinstellungen.Name = "lblEinstellungen";
            this.lblEinstellungen.Size = new System.Drawing.Size(190, 31);
            this.lblEinstellungen.TabIndex = 9;
            this.lblEinstellungen.Text = "Einstellungen";
            // 
            // frmOptionen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 501);
            this.Controls.Add(this.lblEinstellungen);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpxSpielfeld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptionen";
            this.Text = "Optionen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOptionen_FormClosing);
            this.gpxSpielfeld.ResumeLayout(false);
            this.gpxSpielfeld.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxSpielfeld;
        private System.Windows.Forms.Label lblSpielfeld;
        private System.Windows.Forms.TextBox txtBoxenVertikal;
        private System.Windows.Forms.TextBox txtBoxenHorizontal;
        private System.Windows.Forms.Label lblBoxenVertikal;
        private System.Windows.Forms.Label lblBoxenHorizontal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxtyp3;
        private System.Windows.Forms.Label lblBoxtyp3;
        private System.Windows.Forms.TextBox txtBoxtyp2;
        private System.Windows.Forms.TextBox txtBoxtyp1;
        private System.Windows.Forms.Label lblBoxtyp2;
        private System.Windows.Forms.Label lblBoxtyp1;
        private System.Windows.Forms.Label lblWertungen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBoxtyp3Farbe;
        private System.Windows.Forms.Label lblBoxtyp3Farbe;
        private System.Windows.Forms.Button btnBoxtyp2Farbe;
        private System.Windows.Forms.Label lblBoxtyp2Farbe;
        private System.Windows.Forms.Button btnSpielfeldFarbe;
        private System.Windows.Forms.Button btnBoxenFarbe;
        private System.Windows.Forms.Button btnBoxtyp1Farbe;
        private System.Windows.Forms.Label lblBoxtyp1Farbe;
        private System.Windows.Forms.Label lblSpielfeldFarbe;
        private System.Windows.Forms.Label lblBoxen;
        private System.Windows.Forms.Label lblFarben;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.Label lblEinstellungen;
    }
}