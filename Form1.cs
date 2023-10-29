namespace openKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void choiseEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choiseEncrypt.SelectedIndex == 0)
            {

            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (choiseEncrypt.SelectedIndex == 0)
                itogEncrypt.Text = RSA.Decoding(entryMassenge.Text);
        }

    }
}