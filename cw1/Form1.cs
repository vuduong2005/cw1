namespace cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            // Validate length
            if (password.Length > 40)
            {
                MessageBox.Show("Password must not exceed 40 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate uppercase letters only
            if (!password.All(char.IsUpper))
            {
                MessageBox.Show("Password must contain only uppercase letters (A-Z).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate shift input
            if (!int.TryParse(txtShift.Text, out int shift) || shift < -25 || shift > 25)
            {
                MessageBox.Show("Please enter a valid shift value between -25 and 25.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtEncoded.Text = EncodePassword(password, shift);
        }

        private string EncodePassword(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsUpper(letter)) // No need to check lowercase since it's already validated
                {
                    buffer[i] = (char)(((letter + shift - 'A' + 26) % 26) + 'A');
                }
            }
            return new string(buffer);
        }

        private void txtEncoded_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            txtEncoded.Text = SortEncodedText(txtEncoded.Text);
        }

        private string SortEncodedText(string input)
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return new string(arr);
        }

    }
}
