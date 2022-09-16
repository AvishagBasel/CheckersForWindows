namespace Ex05_01
{
    internal class ButtonChecker : Button
    {
        internal int ColInMatrix { get; set; }
        internal int RowInMatrix { get; set; }

        internal ButtonChecker(int i_Col, int i_Row, int i_SquaredSize)
        {
            this.ColInMatrix = i_Col;
            this.RowInMatrix = i_Row;
            this.Size = new Size(i_SquaredSize, i_SquaredSize);
            this.Location = new Point(i_Col * i_SquaredSize + i_SquaredSize / 2, i_Row * i_SquaredSize + i_SquaredSize);
            checkIfEnabled(i_Col, i_Row);
        }

        private void checkIfEnabled(int i_Col, int i_Row)
        {
            if((i_Row % 2 == 0 && i_Col % 2 == 0) || (i_Row % 2 != 0 && i_Col % 2 != 0))
            {
                this.BackColor = Color.DimGray;
                this.Enabled = false;
            }
            else
            {
                this.BackColor = Color.SandyBrown;
                this.TabStop = false;
            }
        }
    }
}
