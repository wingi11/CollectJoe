using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CollectJoe
{
    public partial class frmEditScore : Form
    {

        private string _scorePfad = "";

        public frmEditScore(string scorePfad)
        {
            InitializeComponent();
            _scorePfad = scorePfad;
        }

        /// <summary>
        /// Setzt den Score in das Label
        /// </summary>
        /// <param name="score">Score als string</param>
        public void SetScore(string score)
        {
            lblPunktzahl.Text = score;
        }
        
        /// <summary>
        /// Setzt die Punktzahl auf 0
        /// </summary>
        public void ReSetNameAndScore()
        {
            lblPunktzahl.Text = "0";
        }

        /// <summary>
        /// Speichert den Score im File ab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Keinen Namen eingegeben.", "Bitte geben Sie ihren Namen ein.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            File.AppendAllText(_scorePfad,lblPunktzahl.Text + ";" + txtName.Text+"\n");
            this.Hide();
        }

        /// <summary>
        /// Schliesst das Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Schliesst das Fenster und verhindert das das Programm beendet wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
