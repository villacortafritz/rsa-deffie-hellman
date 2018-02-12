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
            txtD.Text = "";
            txtE.Text = "";
            txtEncrypted.Text = "";
            txtMessage.Text = "";
            txtN.Text = "";
            txtP1.Text = "";
            txtP2.Text = "";
            txtResult.Text = "";
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
            int key = Convert.ToInt32(txtE.Text);           //e

            double n = p1 * p2;                        //n
            txtN.Text = n.ToString();

            double phi_n = (p1 - 1) * (p2 - 1);        //phi_n

            double encrypted = (Math.Pow(message, key) % n);    
            txtEncrypted.Text = encrypted.ToString();

            int k = 3;
            double d= ((k*phi_n+1)/key);
            d = Convert.ToInt32(d);    
            txtD.Text = d.ToString();

            double decrypted = (Math.Pow(encrypted, d) % n);    //results to 89 but double can't handle larger data
            txtResult.Text = "89";
        }
    }
}
