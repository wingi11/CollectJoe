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
            RefreshScore();
        }

        /// <summary>
        /// Liest die hoghscoresdatei aus
        /// </summary>
        public void RefreshScore()
        {
            if (_scorePfad == "" || _scorePfad == null || !File.Exists(_scorePfad))
            {
                txtRangliste.Text = "Rangliste nicht verfügbar.";
            }
            else
            {

                string[] lines = File.ReadAllLines(_scorePfad);
                foreach(string line in lines)
                {
                    txtRangliste.AppendText(line + "\n");
                }
            }
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
