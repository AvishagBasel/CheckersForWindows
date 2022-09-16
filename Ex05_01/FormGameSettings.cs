using static Ex05_01.Enums;

namespace Ex05_01
{
    internal partial class FormGameSettings : Form
    {
        internal FormGameSettings()
        {
            InitializeComponent();
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayer2.Enabled = checkBoxPlayer2.Checked;
            textBoxPlayer2.Text = checkBoxPlayer2.Checked ? String.Empty : "[Computer]";
        }

        // $G$ CSS-999 (-3) Internal methods should start with an uppercase letter.
        internal bool ensureDetailsFilled()
        {
            bool areDetailsFilledCorrectly;

            if(!(areDetailsFilledCorrectly = textBoxPlayer1.Text != String.Empty))
            {
                MessageBox.Show("Please write player 1's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(areDetailsFilledCorrectly = textBoxPlayer1.Text.Length <=10))
            {
                MessageBox.Show("Please write at most 10 characters as player 1's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!(areDetailsFilledCorrectly = !(checkBoxPlayer2.Checked
                                                     && textBoxPlayer2.Text == String.Empty)))
            {
                MessageBox.Show("Please write player 2's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!(areDetailsFilledCorrectly = !(checkBoxPlayer2.Checked && textBoxPlayer2.Text.Length > 10)))
            {
                MessageBox.Show("Please write at most 10 characters as player 2's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return areDetailsFilledCorrectly;
        }

        // $G$ CSS-999 (-3) Internal methods should start with an uppercase letter.
        internal eBoardSize getBoardSize()
        {
            eBoardSize size;
            
            if(buttonSize6X6.Checked)
            {
                size = eBoardSize.Small;
            }
            else if(buttonSize8X8.Checked)
            {
                size = eBoardSize.Medium;
            }
            else
            {
                size = eBoardSize.Large;
            }

            return size;
        }

        // $G$ CSS-999 (-3) Internal methods should start with an uppercase letter.
        internal eNumOfPlayers getNumOfPlayers()
        {
            eNumOfPlayers numOfPlayers = checkBoxPlayer2.Checked ? eNumOfPlayers.Two : eNumOfPlayers.One;

            return numOfPlayers;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            this.buttonDone.BackColor = Color.Black;
            this.buttonDone.ForeColor = Color.White;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            this.buttonDone.BackColor = Color.White;
            this.buttonDone.ForeColor = Color.Black;
        }
    }
}
