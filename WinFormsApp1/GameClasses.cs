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

        public void SetState(States receivedState)
        {
            state = receivedState;

            switch (receivedState)
            {
                case States.None:
                    Text = " ";
                    break;
                case States.X:
                    Text = "X";
                    break;
                case States.O:
                    Text = "O";
                    break;

            }
        }
    }

    internal class Board
    {
        public readonly Cell[,] board = {
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() }
        };

        private void DoAIStep()
        {
            int y;
            int x;
            var random = new Random();
            do
            {
                x = random.Next(3);
                y = random.Next(3);
            } while (board[x, y].GetState() != Cell.States.None);
            board[x, y].SetState(Cell.States.O);
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            if (cell.GetState() == Cell.States.None)
            {
                cell.SetState(Cell.States.X);
                Cell.States winner = CheckWin();
                if (winner == Cell.States.None && !CheckNobody())
                {
                    DoAIStep();
                }
                winner = CheckWin();
                if (winner != Cell.States.None)
                {
                    var result = MessageBox.Show(winner + " выеграл!!");
                    if (result == DialogResult.OK) ClearBoard();
                }
            }
        }

        private bool CheckNobody()
        {
            byte count = 0;
            foreach (Cell cell in board)
            {
                if (cell.GetState() != Cell.States.None)
                {
                    count += 1;
                }
            }
            if (count == 9)
            {
                var result = MessageBox.Show("Некто не выеграл!!!!");
                if (result == DialogResult.OK) ClearBoard();
                return true;
            }
            return false;
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
            byte count_x;
            byte count_y;
            for (byte y = 0; y < 3; y++)
            {
                count_x = 0;
                count_y = 0;
                for (byte x = 0; x < 3; x++)
                {
                    if (board[y, x].GetState() == Cell.States.X) count_x += 1;
                    if (board[y, x].GetState() == Cell.States.O) count_y += 1;
                    if (count_x == 3 || count_y == 3) return board[y, x].GetState();
                }

            }
            for (byte x = 0; x < 3; x++)
            {
                count_x = 0;
                count_y = 0;
                for (byte y = 0; y < 3; y++)
                {
                    if (board[y, x].GetState() == Cell.States.X) count_x += 1;
                    if (board[y, x].GetState() == Cell.States.O) count_y += 1;
                    if (count_x == 3 || count_y == 3) return board[y, x].GetState();
                }

            }

            count_x = 0;
            count_y = 0;
            for (byte i = 0; i < 3; i++)
            {
                if (board[i, i].GetState() == Cell.States.X) count_x += 1;
                if (board[i, i].GetState() == Cell.States.O) count_y += 1;
                if (count_x == 3 || count_y == 3) return board[i, i].GetState();
            }

            count_x = 0;
            count_y = 0;
            for (sbyte r = 2; r >= 0; r--)
            {
                if (board[r, Math.Abs(r - 2)].GetState() == Cell.States.X) count_x += 1;
                if (board[r, Math.Abs(r - 2)].GetState() == Cell.States.O) count_y += 1;
                if (count_x == 3 || count_y == 3) return board[r, Math.Abs(r - 2)].GetState();
            }
            return Cell.States.None;
        }
    }
}
