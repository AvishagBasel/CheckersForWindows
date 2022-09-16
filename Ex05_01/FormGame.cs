using Ex05_02;
using static Ex05_02.Enums;

namespace Ex05_01
{
    internal class FormGame : Form
    {
        private const int k_CellSize = 70;
        private int m_BoardWidth;
        private int m_BoardHeight;
        internal FormGameSettings FormGameSettings { get; } = new FormGameSettings();
        internal GameSettingsStruct GameSettingsDetails { get; private set; }
        internal Label LabelRoundNumber { get; } = new Label();
        internal Label LabelPlayer1Score { get; } = new Label();
        internal Label LabelPlayer2Score { get; } = new Label();
        internal Label LabelCurrentTurnPlayerName { get; } = new Label();
        internal eCheckerType[,] BoardAsMatrix { get; set; }
        private bool m_IsSourcePressed;
        internal ButtonChecker ButtonSourceChecker { get; private set; }
        internal ButtonChecker ButtonDestChecker { get; private set; }
        private bool m_AreTwoButtonsBecamePressed;
        public event Action TwoButtonsBecamePressed;
        private bool AreTwoButtonsBecamePressed
        {
            set
            {
                m_AreTwoButtonsBecamePressed = value;
                if(m_AreTwoButtonsBecamePressed)
                {
                    OnTwoButtonsBecamePressed();
                }
            }
        }

        internal void Run()
        {
            this.FormGameSettings.buttonDone.Click += new EventHandler(this.buttonDone_Click);
            this.FormGameSettings.ShowDialog();
        }

        internal void buttonDone_Click(object sender, EventArgs e)
        {
            if(this.FormGameSettings.ensureDetailsFilled())
            {
                this.GameSettingsDetails = new GameSettingsStruct(
                    this.FormGameSettings.textBoxPlayer1.Text,
                    this.FormGameSettings.textBoxPlayer2.Text,
                    this.FormGameSettings.getBoardSize(),
                    this.FormGameSettings.getNumOfPlayers());
                this.m_BoardWidth = k_CellSize * ((int)this.GameSettingsDetails.BoardSize + 1);
                this.m_BoardHeight = k_CellSize * ((int)this.GameSettingsDetails.BoardSize + 2);
                this.FormGameSettings.DialogResult = DialogResult.OK;
            }
        }

        internal void SetFormGameAroundBoard(Round i_Round)
        {
            InitializeComponent();
            SetRoundLabels();
            setFormGameEventListeners(i_Round);
        }

        // $G$ CSS-999 (-3) Private methods should start with an lowercase letter.
        private void InitializeComponent()
        {
            this.Text = "Damka";
            this.ClientSize = new Size(this.m_BoardWidth, this.m_BoardHeight);
            this.BackColor = Color.SaddleBrown;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        internal void SetRoundLabels()
        {
            int labelIndex = 0;
            string fontFamily = "Verdana";

            this.Controls.Add(this.LabelRoundNumber);
            this.Controls.Add(this.LabelPlayer1Score);
            this.Controls.Add(this.LabelPlayer2Score);
            this.Controls.Add(this.LabelCurrentTurnPlayerName);
            foreach (Label label in this.Controls.OfType<Label>())
            {
                if (labelIndex == 0)
                {
                    label.Font = new Font(fontFamily, (float)this.GameSettingsDetails.BoardSize + 3, System.Drawing.FontStyle.Bold);
                }
                else if (labelIndex == 3)
                {
                    label.Font = new Font(fontFamily, (float)this.GameSettingsDetails.BoardSize + 4);
                }
                else
                {
                    label.Font = new Font(fontFamily, Math.Max((float)this.GameSettingsDetails.BoardSize + 2, 9));
                }

                label.ForeColor = Color.White;
                label.AutoSize = true;
                labelIndex++;
            }
        }

        private void setFormGameEventListeners(Round i_Round)
        {
            i_Round.BecameInitialized += new Action<Round>(this.labelsOfRound_TextChanged);
            i_Round.CurrentTurnPlayerChanged += new Action<Round>(this.labelCurrentTurnPlayer_TextChanged);
        }

        private void labelsOfRound_TextChanged(Round i_Round)
        {
            this.LabelRoundNumber.Text = string.Format("Round number: {0}", i_Round.RoundNumber);
            this.LabelRoundNumber.Location = new Point(this.ClientSize.Width / 2 - this.LabelRoundNumber.Width / 2, k_CellSize / 8);
            
            this.LabelPlayer1Score.Text = string.Format("Player 1's score: {0}", i_Round.Player1.PlayerScore);
            this.LabelPlayer1Score.Location = new Point(k_CellSize / 8, k_CellSize / 2);
            
            this.LabelPlayer2Score.Text = string.Format("Player 2's score: {0}", i_Round.Player2.PlayerScore);
            this.LabelPlayer2Score.Location = new Point(this.ClientSize.Width - this.LabelPlayer2Score.Width - k_CellSize / 8, k_CellSize / 2);
        }

        private void labelCurrentTurnPlayer_TextChanged(Round i_Round)
        {
            string playerName = i_Round.CurrentTurnPlayer == ePlayerNumber.Player1
                                    ? this.GameSettingsDetails.Player1Name
                                    : this.GameSettingsDetails.Player2Name;

            this.LabelCurrentTurnPlayerName.Text = string.Format("{0} ({1}) is the current player.", playerName, i_Round.CurrentTurnPlayer);
            this.LabelCurrentTurnPlayerName.Location = new Point(
                this.ClientSize.Width / 2 - this.LabelCurrentTurnPlayerName.Width / 2,
                this.ClientSize.Height - k_CellSize + this.LabelCurrentTurnPlayerName.Height / 2);
        }

        internal void SetFormGameBoard(Round i_Round)
        {
            this.BoardAsMatrix = i_Round.BoardAsMatrix;
            buildBoard();
        }

        private void buildBoard()
        {
            ButtonChecker checker;

            for(int i = 0; i < (int)this.GameSettingsDetails.BoardSize; i++)
            {
                for(int j = 0; j < (int)this.GameSettingsDetails.BoardSize; j++)
                {
                    checker = new ButtonChecker(j, i, k_CellSize);
                    setCheckerSign(checker);
                    this.Controls.Add(checker);
                    checker.Click += new EventHandler(this.buttonChecker_Click);
                }
            }
        }

        private void setCheckerSign(ButtonChecker i_ButtonChecker)
        {
            string imagePath;

            if(this.BoardAsMatrix[i_ButtonChecker.RowInMatrix, i_ButtonChecker.ColInMatrix] != eCheckerType.BlankCell)
            {
                if(this.BoardAsMatrix[i_ButtonChecker.RowInMatrix, i_ButtonChecker.ColInMatrix] == eCheckerType.Man1)
                {
                    imagePath = @"..\..\..\Checker'sImg\blackChecker.png";
                }
                else if(this.BoardAsMatrix[i_ButtonChecker.RowInMatrix, i_ButtonChecker.ColInMatrix] == eCheckerType.Man2)
                {
                    imagePath = @"..\..\..\Checker'sImg\whiteChecker.png";
                }
                else if(this.BoardAsMatrix[i_ButtonChecker.RowInMatrix, i_ButtonChecker.ColInMatrix] == eCheckerType.King1)
                {
                    imagePath = @"..\..\..\Checker'sImg\blackKing.png";
                }
                else
                {
                    imagePath = @"..\..\..\Checker'sImg\whiteKing.png";
                }

                i_ButtonChecker.Image = new Bitmap(
                    new Bitmap(imagePath),
                    new Size(k_CellSize - 10, k_CellSize - 10));

            }
            else
            {
                i_ButtonChecker.Image = null;
            }
        }

        private void buttonChecker_Click(object? sender, EventArgs e)
        {
            ButtonChecker buttonClicked = sender as ButtonChecker;

            if(isCheckerOnButton(buttonClicked))
            {
                checkIfSourcePressed(buttonClicked);
            }
            else if(this.m_IsSourcePressed)
            {
                this.ButtonDestChecker = buttonClicked;
                this.AreTwoButtonsBecamePressed = true;
            }
        }

        private bool isCheckerOnButton(ButtonChecker i_ButtonChecker)
        {
            return this.BoardAsMatrix[i_ButtonChecker.RowInMatrix, i_ButtonChecker.ColInMatrix] != eCheckerType.BlankCell;
        }

        private void checkIfSourcePressed(ButtonChecker i_ButtonChecker)
        {
            if(!this.m_IsSourcePressed)
            {
                this.ButtonSourceChecker = i_ButtonChecker;
                this.m_IsSourcePressed = true;
                i_ButtonChecker.BackColor = Color.DodgerBlue;
                i_ButtonChecker.ForeColor = Color.White;
            }
            else if(this.m_IsSourcePressed && this.ButtonSourceChecker == i_ButtonChecker)
            {
                this.m_IsSourcePressed = false;
                i_ButtonChecker.BackColor = Color.SandyBrown;
                i_ButtonChecker.ForeColor = Color.Black;
            }
            else if(this.m_IsSourcePressed)
            {
                this.ButtonDestChecker = i_ButtonChecker;
                this.AreTwoButtonsBecamePressed = true;
            }
        }

        protected virtual void OnTwoButtonsBecamePressed()
        {
            if(TwoButtonsBecamePressed != null)
            {
                TwoButtonsBecamePressed.Invoke();
            }
        }

        internal void UnPressSourceAndDestButtons()
        {
            this.m_IsSourcePressed = false;
            this.AreTwoButtonsBecamePressed = false;
            this.ButtonSourceChecker.BackColor = Color.SandyBrown;
            this.ButtonSourceChecker.ForeColor = Color.Black;
        }

        internal void UpdateCheckersOnBoard()
        {
            foreach(ButtonChecker buttonChecker in this.Controls.OfType<ButtonChecker>())
            {
                setCheckerSign(buttonChecker);
            }
        }
    }
}
