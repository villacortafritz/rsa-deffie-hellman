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

        public int final_key = 3;

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBobPrivate.Text = "";
            txtAliceKey.Text = "";
            txtAlicePrivate.Text = "";
            txtAliceText.Text = "";
            txtBobKey.Text = "";
            txtBobText.Text = "";
            txtGenerator.Text = "";
            txtPublic.Text = "";

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

            //final_key = (Convert.ToInt32(fromBob)%3);
        }

        public bool primeCheck(int num)
        {
            bool flag = true;

            for(int i=2; i<num/2; i++)
            {
                if(num%i != 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtBobText.Text);
            String message = replyBob.Text;
            String encrypted;
            int length = message.Length;
            char[] encrypted_message = new char[length];
            char c;
            Boolean flag = true;

            for (int i = 0; i < length; i++)
            {
                c = message[i];

                if (c >= 'a' && c <= 'z')
                {
                    c = (char)(c + key);
                    if (c > 'z')
                    {
                        c = (char)(c - 'z' + 'a' - 1);
                    }

                    encrypted_message[i] = c;
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + key);
                    if (c > 'Z')
                    {
                        c = (char)(c - 'Z' + 'A' - 1);
                    }

                    encrypted_message[i] = c;
                }
                else if (c == ' ')
                {
                    c = (char)(c + key);
                    encrypted_message[i] = c;
                }
                else
                {
                    MessageBox.Show("No numbers or symbols allowed!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtEncrypt.Text = "";
                    flag = false;
                    break;
                }
            }

            if (flag == true)
            {
                encrypted = new String(encrypted_message);
                replyAlice.Text = encrypted;
            }
        }
    }
}
