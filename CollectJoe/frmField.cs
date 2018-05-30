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
    public partial class frmField : Form
    {

        private frmOptionen _fieldOptionen = new frmOptionen();
        private frmEditScore _fieldEditScore;
        private frmScoreList _fieldScoreList;

        private Random random = new Random();

        private int _gameDuration = 39999;
        private int _playTime;

        private string _scorePath;

        private int _boxCountHorizontal;

        public frmField()
        {
            InitializeComponent();
        }

        private void frmField_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
