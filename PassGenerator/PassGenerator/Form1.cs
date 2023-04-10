using System.Text;

namespace PassGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum= 32;
            numericUpDown1.Minimum= 12;

            btnCopy.Enabled = false;

        }
        public void PassGenerator(int length)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }
            lblPassword.Text = password.ToString();
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(numericUpDown1.Value);
            PassGenerator(length);
            lblMassage.Text = "Created!";

            if (lblPassword.Text.Length >= 12)
            {
                btnCopy.Enabled = true;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
            lblMassage.Text = "Copied!";
        }
    }
}