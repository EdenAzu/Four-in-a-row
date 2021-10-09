using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex05.FourInARow.UI
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        public string FirstPlayer { get; private set; } = "Player 1";

        public string SecondPlayer { get; private set; } = "Computer";

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public bool Player2Human { get; private set; }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Rows = (int)numberOfRows.Value;
            Cols = (int)numberOfCols.Value;
            DialogResult = DialogResult.OK;
        }

        private void FourInARow_Load(object sender, EventArgs e)
        {
        }

        private void namePlayer1_TextChanged(object sender, EventArgs e)
        {
            FirstPlayer = namePlayer1.Text;
        }

        // $G$ CSS-010 (-3) Private method should start with a lower case letter.
        private void Player2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPlayer2.Checked)
            {
                namePlayer2.Text = string.Empty;
                namePlayer2.Enabled = true;
                SecondPlayer = namePlayer2.Text;
                namePlayer2.BackColor = Color.White;
                Player2Human = true;
            }
            else
            {
                SecondPlayer = "[computer]";
                namePlayer2.Text = "[computer]";
                namePlayer2.Enabled = false;
                namePlayer2.BackColor = Color.LightGray;
            }
        }

        private void namePlayer2_TextChanged(object sender, EventArgs e)
        {
            SecondPlayer = namePlayer2.Text;
        }

        private void numberOfRows_SelectedItemChanged(object sender, EventArgs e)
        {
            Rows = (int)numberOfRows.Value;
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            FirstPlayer = namePlayer1.Text;
        }

        private void numbersOfCols_SelectedItemChanged(object sender, EventArgs e)
        {
            Cols = (int)numberOfCols.Value;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numberOfCols_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}