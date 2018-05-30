using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectJoe
{
    public partial class frmOptionen : Form
    {
        public frmOptionen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gibt die Horizontale länge zurück
        /// </summary>
        /// <returns>int länge</returns>
        public int GetHorizontal()
        {
            int x = 20;
            try
            {
                x = Convert.ToInt32(txtBoxenHorizontal.Text);
                if (x == null || x == 0 || x > 20)
                {
                    x = 20;
                    return x;
                } else if(x < 1)
                {
                    x = 10;
                    return x;
                }
            } catch(Exception e)
            {
                Console.WriteLine("Keine Zahl eingegeben!");
            }
            return x;
        }

        /// <summary>
        /// gibt die Vertikale länge zurück
        /// </summary>
        /// <returns>int höhe</returns>
        public int GetVertical()
        {
            int x = 10;
            try
            {
                x = Convert.ToInt32(txtBoxenVertikal.Text);
                if (x == null || x == 0 || x > 10)
                {
                    x = 10;
                    return x;
                }
                else if (x < 1)
                {
                    x = 10;
                    return x;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Keine Zahl eingegeben!");
            }
            return x;
        }

        /// <summary>
        /// Gibt den Inhalt eines Textfeldes zurück
        /// </summary>
        /// <param name="txtName">Name des Textfeldes</param>
        /// <returns>Den Inhalt als int</returns>
        public int GetValue(string txtName)
        {
            Control[] controls = this.Controls.Find(txtName, true);
            TextBox activeTextBox = (TextBox)controls[0];

            return Convert.ToInt32(activeTextBox.Text);
        }

        /// <summary>
        /// Gibt die Farbe eines bestimmten Knopfes zurück um die eingestellten Farben herauszufinden
        /// </summary>
        /// <param name="btnName">Name des Knopfes</param>
        /// <returns>Hintergrundfarbe des Knopfes</returns>
        public Color GetColor(string btnName)
        {
            Control[] controls = this.Controls.Find(btnName, true);
            Button activeButton = (Button)controls[0];

            return activeButton.BackColor;
        }

        /// <summary>
        /// Wählt die Farbe für den Knopf aus sobald draufgeklickt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        /// Vergleicht die Farben und versteckt das Einstellungen Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            Button[] buttons = { btnBoxenFarbe, btnSpielfeldFarbe, btnBoxtyp1Farbe, btnBoxtyp2Farbe, btnBoxtyp3Farbe };

            bool isUnique = true;

            foreach(Button btn1 in buttons)
            {
                foreach(Button btn2 in buttons)
                {
                    if(btn1 != btn2)
                    {
                        if (btn1.BackColor == btn2.BackColor) isUnique = false;
                    }
                }
            }

            if (isUnique)
            {
                this.Hide();
            } else
            {
                MessageBox.Show("Du darfst keine Farbe doppelt verwenden!");
            }
        }

        /// <summary>
        /// Verhindert das schliessen des Programms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOptionen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
