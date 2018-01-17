using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphify
{
    public partial class playfair : UserControl
    {
        public playfair()
        {
            InitializeComponent();
        }
        public string key;
        public int preparedLength;
        public string encryptedText;

        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            int p1 = Convert.ToInt32(txtP1.Text);
            int p2 = Convert.ToInt32(txtP2.Text);
            int message = Convert.ToInt32(txtMessage.Text);
            int key = Convert.ToInt32(txtE.Text);

            int n = p1 * p2;
            txtN.Text = n.ToString();

            int phi_n = (p1 - 1) * (p2 - 1);

            double encrypted = (Math.Pow(message, key) % n);
            txtEncrypted.Text = encrypted.ToString();

            int k = 0;
            double d=0;

            for (int i = 1; i > 0; i++)
            {
                k = 2;
                d = (k * phi_n + 1) / key;
                if ((d % 1) == 0)
                {
                    break;
                }
            }

            txtK.Text = k.ToString();
                
            txtD.Text = d.ToString();

            double decrypted = (Math.Pow(encrypted, d) % n);
            txtResult.Text = decrypted.ToString();
        }
        
    }
}
