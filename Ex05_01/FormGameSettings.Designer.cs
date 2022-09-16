namespace Ex05_01
{
    partial class FormGameSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.buttonSize6X6 = new System.Windows.Forms.RadioButton();
            this.buttonSize8X8 = new System.Windows.Forms.RadioButton();
            this.buttonSize10X10 = new System.Windows.Forms.RadioButton();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelBoardSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBoardSize.Location = new System.Drawing.Point(20, 10);
            this.labelBoardSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(140, 26);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // buttonSize6X6
            // 
            this.buttonSize6X6.AutoSize = true;
            this.buttonSize6X6.Checked = true;
            this.buttonSize6X6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSize6X6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSize6X6.Location = new System.Drawing.Point(50, 50);
            this.buttonSize6X6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSize6X6.Name = "buttonSize6X6";
            this.buttonSize6X6.Size = new System.Drawing.Size(96, 30);
            this.buttonSize6X6.TabIndex = 10;
            this.buttonSize6X6.TabStop = true;
            this.buttonSize6X6.Text = "6 X 6";
            this.buttonSize6X6.UseVisualStyleBackColor = true;
            // 
            // buttonSize8X8
            // 
            this.buttonSize8X8.AutoSize = true;
            this.buttonSize8X8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSize8X8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSize8X8.Location = new System.Drawing.Point(180, 50);
            this.buttonSize8X8.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSize8X8.Name = "buttonSize8X8";
            this.buttonSize8X8.Size = new System.Drawing.Size(96, 30);
            this.buttonSize8X8.TabIndex = 20;
            this.buttonSize8X8.Text = "8 X 8";
            this.buttonSize8X8.UseVisualStyleBackColor = true;
            // 
            // buttonSize10X10
            // 
            this.buttonSize10X10.AutoSize = true;
            this.buttonSize10X10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSize10X10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSize10X10.Location = new System.Drawing.Point(310, 50);
            this.buttonSize10X10.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonSize10X10.Name = "buttonSize10X10";
            this.buttonSize10X10.Size = new System.Drawing.Size(124, 30);
            this.buttonSize10X10.TabIndex = 30;
            this.buttonSize10X10.Text = "10 X 10";
            this.buttonSize10X10.UseVisualStyleBackColor = true;
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayers.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labelPlayers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayers.Location = new System.Drawing.Point(20, 90);
            this.labelPlayers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(100, 26);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.SaddleBrown;
            this.labelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer1.Location = new System.Drawing.Point(50, 130);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(111, 26);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(200, 130);
            this.textBoxPlayer1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(234, 34);
            this.textBoxPlayer1.TabIndex = 40;
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.BackColor = System.Drawing.Color.SaddleBrown;
            this.checkBoxPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(50, 180);
            this.checkBoxPlayer2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(137, 30);
            this.checkBoxPlayer2.TabIndex = 50;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = false;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(200, 180);
            this.textBoxPlayer2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(234, 34);
            this.textBoxPlayer2.TabIndex = 60;
            this.textBoxPlayer2.Text = "[Computer]";
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone.Location = new System.Drawing.Point(300, 237);
            this.buttonDone.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(134, 38);
            this.buttonDone.TabIndex = 70;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // FormGameSettings
            // 
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(456, 290);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.buttonSize10X10);
            this.Controls.Add(this.buttonSize8X8);
            this.Controls.Add(this.buttonSize6X6);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.Controls.Add(this.labelBoardSize);
            this.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBoardSize;
        private RadioButton buttonSize6X6;
        private RadioButton buttonSize8X8;
        private RadioButton buttonSize10X10;
        private Label labelPlayers;
        private Label labelPlayer1;
        internal TextBox textBoxPlayer1;
        private CheckBox checkBoxPlayer2;
        internal TextBox textBoxPlayer2;
        internal Button buttonDone;
    }
}