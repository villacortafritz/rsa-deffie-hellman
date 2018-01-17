using System;
using System.Windows.Forms;

namespace Graphify
{
    public partial class ceasar : UserControl
    {
        public ceasar()
        {
            InitializeComponent();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            int bobPrivate = Convert.ToInt32(txtBobPrivate.Text);
            int alicePrivate = Convert.ToInt32(txtAlicePrivate.Text);
            int publicKey = Convert.ToInt32(txtPublic.Text);
            int generator = Convert.ToInt32(txtGenerator.Text);
            
            double firstsend = (Math.Pow(generator, bobPrivate)%publicKey);
            txtAliceKey.Text = firstsend.ToString();
            System.Threading.Thread.Sleep(1000);
            txtAliceKey.Refresh();
            
            double secondsend = (Math.Pow(generator, alicePrivate) % publicKey);
            txtBobKey.Text = secondsend.ToString();
            
            int fromAlice = Convert.ToInt32(txtBobKey.Text);
            double bobCalculate = (Math.Pow(fromAlice, bobPrivate) % publicKey);

            int fromBob = Convert.ToInt32(txtAliceKey.Text);
            double aliceCalculate = (Math.Pow(fromBob, alicePrivate) % publicKey);
            txtBobText.Text = bobCalculate.ToString();
            txtAliceText.Text = aliceCalculate.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAliceKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void ceasar_Load(object sender, EventArgs e)
        {

        }
    }
}
