using Ex05_02;
using static Ex05_02.Enums;

namespace Ex05_01
{
    internal class GameManagement
    {
        // $G$ DSN-999 (-3) This object should be readonly.
        private FormGame m_FormGame = new FormGame();
        private Round m_Round;

        internal void Run()
        {
            this.m_FormGame.Run();
            if(this.m_FormGame.FormGameSettings.DialogResult == DialogResult.OK)
            {
                setGameFields();
                this.m_FormGame.ShowDialog();
            }
        }

        private void setGameFields()
        {
            this.m_Round = new Round((int)this.m_FormGame.GameSettingsDetails.BoardSize, (int)this.m_FormGame.GameSettingsDetails.NumOfPlayers);
            this.m_FormGame.SetFormGameAroundBoard(this.m_Round);
            this.m_Round.InitRound();
            this.m_FormGame.SetFormGameBoard(this.m_Round);
            setGameManagementEventListeners();
        }

        private void setGameManagementEventListeners()
        {
            this.m_FormGame.TwoButtonsBecamePressed += new Action(this.sourceAndDestCheckers_Pressed);
            this.m_Round.BecameOver += new Action(this.currentRound_Over);
        }

        private void sourceAndDestCheckers_Pressed()
        {
            playMove();
        }

        private void playMove()
        {
            ButtonChecker sourceChecker = this.m_FormGame.ButtonSourceChecker;
            ButtonChecker destChecker = this.m_FormGame.ButtonDestChecker;
            int errorCode;

            if(!this.m_Round.IsValidTurn(
                   sourceChecker.ColInMatrix,
                   sourceChecker.RowInMatrix,
                   destChecker.ColInMatrix,
                   destChecker.RowInMatrix,
                   out errorCode))
            {
                MessageBox.Show(getErrorMessage(errorCode), "Invalid move!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.m_Round.MakeTurn(
                    sourceChecker.ColInMatrix,
                    sourceChecker.RowInMatrix,
                    destChecker.ColInMatrix,
                    destChecker.RowInMatrix);
                this.m_FormGame.UpdateCheckersOnBoard();
            }

            this.m_FormGame.UnPressSourceAndDestButtons();
        }

        private void currentRound_Over()
        {
            string message;

            if(this.m_Round.EndWithWinning)
            {
                message = this.m_Round.CurrentTurnPlayer == ePlayerNumber.Player1
                              ? string.Format("{0} Won!", this.m_FormGame.GameSettingsDetails.Player1Name)
                              : string.Format("{0} Won!", this.m_FormGame.GameSettingsDetails.Player2Name);
            }
            else
            {
                message = "Tie!";
            }

            if(MessageBox.Show(
                   string.Format("{0}\nAnother Round?", message),
                   "Damka",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.m_Round.InitRound();
            }
            else
            { 
                this.m_FormGame.Close();
            }
        }

        private static string getErrorMessage(int i_ErrorCode)
        {
            string message = "";

            if(i_ErrorCode == 1)
            {
                message = "Please choose a valid checker.";
            }
            else if(i_ErrorCode == 2)
            {
                message = "Please make a legal step.";
            }
            else if(i_ErrorCode == 3)
            {
                message = "You must make a capture if you can.";
            }
            else if(i_ErrorCode == 4)
            {
                message = "You made a capture and you have another one available, you must do so!";
            }
            else if(i_ErrorCode == 5)
            {
                message = "Touch-Move rule: You need to move with the last one you mistaked with!";
            }

            return message;
        }
    }
}
