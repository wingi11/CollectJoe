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
                x = Convert.ToInt16(txtBoxenHorizontal.Text);
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
                x = Convert.ToInt16(txtBoxenVertikal.Text);
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

        public int GetValue(string txtName)
        {
            Control[] controls = this.Controls.Find(txtName, true);
            TextBox activeTextBox = (TextBox)controls[0];

            return 0;
        }
    }
}
