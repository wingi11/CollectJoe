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
    public partial class frmField : Form
    {

        private frmOptionen _fieldOptionen = new frmOptionen();
        private frmEditScore _fieldEditScore;
        private frmScoreList _fieldScoreList;

        private Random _random = new Random();

        private int _gameDuration = 39999;
        private int _playTime;

        private string _scorePath;

        private int _boxCountHorizontal;
        private int _boxCountVertical;
        private int _boxWidth;
        private int _boxHeight;
        private Color _boxColor;

        private List<Button> _buttons = new List<Button>();

        private int _lastButton;

        private Dictionary<Color, int> _dctFarbeUndWert = new Dictionary<Color, int>();

        private bool _gameRunning = false;

        private int[] _fieldPadding = new int[] { 10, 10 };

        public frmField()
        {
            InitializeComponent();

            _scorePath = Path.Combine(Environment.CurrentDirectory, "highscore.txt");
            if (!File.Exists(_scorePath))
            {
                File.AppendAllText(_scorePath, "");
            }

            _fieldEditScore = new frmEditScore(_scorePath);
            _fieldScoreList = new frmScoreList(_scorePath);
            SetOptions();
        }

        /// <summary>
        /// Setzt die Optinonen vom Optionenfeld
        /// </summary>
        public void SetOptions() {
            pnlFeld.BackColor = _fieldOptionen.GetColor("btnSpielfeldFarbe");

            _boxColor = _fieldOptionen.GetColor("btnBoxenFarbe");

            _boxCountHorizontal = _fieldOptionen.GetHorizontal();
            _boxCountVertical = _fieldOptionen.GetVertical();

            _boxWidth = (pnlFeld.Width - _fieldPadding[1] * 2) / _boxCountHorizontal;
            _boxHeight = (pnlFeld.Height - _fieldPadding[0] * 2) / _boxCountVertical;

            //Clear then fill dictionary
            _dctFarbeUndWert.Clear();
            for (int i = 1; i <= 3; i++)
            {
                _dctFarbeUndWert.Add(_fieldOptionen.GetColor("btnBoxtyp" + i + "Farbe"), _fieldOptionen.GetValue("txtBoxtyp" + i));
            }
        }

        /// <summary>
        /// Schaut ob eine Box geklickt wird und setzt danach den Punktestand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBox_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled)
            {

                if (_dctFarbeUndWert.ContainsKey(((Button)sender).BackColor))
                {
                    txtPunktestand.Text = Convert.ToString(Convert.ToInt32(txtPunktestand.Text) + _dctFarbeUndWert[(sender as Button).BackColor]);
                }
                if (Convert.ToInt32(txtPunktestand.Text) < 0)
                {
                    StopGame();
                }
            }
        }

        /// <summary>
        /// Baut das Feld mit den Buttons auf
        /// </summary>
        public void BuildButtonField()
        {
            pnlFeld.Controls.Clear();
            _buttons.Clear();

            for (int x = 0; x < _boxCountVertical; x++)
            {
                for (int y = 1; y <= _boxCountHorizontal; y++)
                {

                    int n;
                    if (x == 0)
                    {
                        n = y;
                    }
                    else
                    {
                        n = x * _boxCountHorizontal + y;
                    }

                    Button btn = new Button();
                    btn.Name = "btn_" + Convert.ToString(n);
                    btn.Height = _boxHeight;
                    btn.Width = _boxWidth;
                    btn.Location = new Point((y - 1) * _boxWidth + _fieldPadding[0], x * _boxHeight + _fieldPadding[1]);
                    btn.Text = "";
                    btn.BackColor = _boxColor;
                    btn.Click += new System.EventHandler(BtnBox_Click);

                    _buttons.Add(btn);
                }
            }

            foreach(Button btn in _buttons)
            {
                pnlFeld.Controls.Add(btn);
            }
        }

        /// <summary>
        /// Stopt das Spiel
        /// </summary>
        public void StopGame()
        {
            tmr.Stop();
            ResetField();

            if (Convert.ToInt32(txtPunktestand.Text) < 0)
            {
                MessageBox.Show("Game over", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _fieldEditScore.ShowDialog();
            }

            btnSpielStarten.Text = "Spiel starten";

            btnOptionen.Enabled = true;
            btnRanglisteAnzeigen.Enabled = true;
        }   

        /// <summary>
        /// Resettet das Feld
        /// </summary>
        public void ResetField()
        {
            foreach (Button btn in _buttons)
            {
                if (btn.BackColor != _boxColor) { btn.BackColor = _boxColor; };
            }
            foreach (Button btn in pnlFeld.Controls.OfType<Button>().ToArray())
            {
                if (btn.BackColor != _boxColor) { btn.BackColor = _boxColor; };
            }
        }

        /// <summary>
        /// Bei jedem Tick werden die Knöpfe neu eingefärbt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (_playTime == _gameDuration)
            {
                StopGame();
            }

            _buttons[_lastButton].BackColor = _boxColor;

            int randomNr = _random.Next(0, _buttons.Count);
            _buttons[randomNr].BackColor = _dctFarbeUndWert.ElementAt(_random.Next(0, _dctFarbeUndWert.Count)).Key;
            _lastButton = _buttons.IndexOf(_buttons[randomNr]);

            _gameDuration++;
            _gameRunning = true;
        }

        /// <summary>
        /// EventListener für den Spiel starten Buntton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpielStarten_Click(object sender, EventArgs e)
        {
            if (!_gameRunning)
            {
                btnOptionen.Enabled = false;
                btnRanglisteAnzeigen.Enabled = false;

                _playTime = 0;
                _lastButton = 0;
                txtPunktestand.Text = "0";
                _fieldEditScore.ReSetNameAndScore();

                SetOptions();

                BuildButtonField();

                ResetField();

                btnSpielStarten.Text = "Spiel Beenden";

                tmr.Start();
            } else
            {
                StopGame();
                btnSpielStarten.Text = "Spiel Starten";
                _gameRunning = false;
            }
        }

        /// <summary>
        /// EventListener für den Rangliste Anzeigen Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRanglisteAnzeigen_Click(object sender, EventArgs e)
        {
            _fieldScoreList.Show();
        }

        /// <summary>
        /// EventListener für den Optionen Anzeigen Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOptionen_Click(object sender, EventArgs e)
        {
            _fieldOptionen.Show();
        }
    }
}
