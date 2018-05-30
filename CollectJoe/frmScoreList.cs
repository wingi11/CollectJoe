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
    public partial class frmScoreList : Form
    {

        private string _scorePfad = "";

        public frmScoreList(string scorePfad)
        {
            InitializeComponent();
            _scorePfad = scorePfad;
        }

        public void RefreshScore()
        {
            if (!File.Exists(_scorePfad)) return;

            string[] lines = File.ReadAllLines(_scorePfad);

            if (lines.Length == 0) txtRangliste.Text = "Rangliste nicht verfügbar!";
        }

        /// <summary>
        /// Schliesst das Fenster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            this.Hide();
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
