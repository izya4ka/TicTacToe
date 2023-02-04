namespace WinFormsApp1
{
    internal class Cell : Button
    {
        public enum States
        {
            X,
            O,
            None
        };

        static public readonly byte X_SIZE = 64;
        static public readonly byte Y_SIZE = 64;

        private States state = States.None;


        public States GetState() => state;

        public void SetState(States receivedState) => state = receivedState;
    }

    internal class Board
    {
        public readonly Cell[,] board = {
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() }
        };

        private void GameButtonClick(object sender, EventArgs e)
        {
            ((Cell)sender).SetState(Cell.States.X);
            ((Cell)sender).Text = "X";
            Cell.States winner = CheckWin();
            if (winner != Cell.States.None)
            {
                ClearBoard();
                MessageBox.Show(winner + " won the game!");
            }

        }

        public Board()
        {
            byte curr_y = 1;
            for (sbyte i = 2; i >= 0; i--)
            {
                byte curr_x = 1;
                for (byte j = 0; j < 3; j++)
                {
                    board[i, j].Text = " ";
                    board[i, j].Width = Cell.X_SIZE;
                    board[i, j].Height = Cell.Y_SIZE;
                    board[i, j].Location = new Point(Cell.X_SIZE * curr_x, Cell.Y_SIZE * curr_y);
                    board[i, j].Click += new EventHandler(GameButtonClick);
                    curr_x += 1;
                }
                curr_y += 1;
                curr_x = 1;
            }
        }
        public void ClearBoard()
        {
            foreach (Cell cell in board)
            {
                cell.SetState(Cell.States.None);
            }
        }

        public void HideAll()
        {
            foreach (Cell cell in board)
            {
                cell.Hide();
            }
        }

        public void ShowAll()
        {
            foreach (Cell cell in board)
            {
                cell.Show();
            }
        }

        public Cell.States CheckWin()
        {
            byte count;
            for (byte y = 0; y < 3; y++)
            {
                count = 0;
                for (byte x = 0; x < 3; x++)
                {
                    if (board[y, x].GetState() != Cell.States.None) count += 1;
                    if (count == 3) return board[y, x].GetState();
                }

            }
            for (byte x = 0; x < 3; x++)
            {
                count = 0;
                for (byte y = 0; y < 3; y++)
                {
                    if (board[y, x].GetState() != Cell.States.None) count += 1;
                    if (count == 3) return board[y, x].GetState();
                }

            }

            count = 0;
            for (byte i = 0; i < 3; i++)
            {
                if (board[i, i].GetState() != Cell.States.None) count += 1;
                if (count == 3) return board[i, i].GetState();
            }

            count = 0;
            for (byte i = 2; i > 0; i--)
            {
                if (board[i, i].GetState() != Cell.States.None) count += 1;
                if (count == 3) return board[i, i].GetState();
            }
            return Cell.States.None;
        }
    };
}
