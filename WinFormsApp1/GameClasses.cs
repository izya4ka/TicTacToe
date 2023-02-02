namespace WinFormsApp1
{
    internal class Cell
    {
        private char state = ' ';
        private char[] allowedCharacters = { 'X', 'Y', ' ' };

        public char GetState() => state;

        public void SetState(char receivedState)
        {
            if (allowedCharacters.Contains(receivedState))
            {
                state = receivedState;
            }
            else
            {
                throw new Exception("State must be 'X', 'O' or ' '");
            }
        }
    }

    internal class Board
    {
        private readonly Cell[,] board = {
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() },
            { new Cell(), new Cell(), new Cell() }
        };

        public void ChangeCellState(byte x, byte y, char state)
        {
            if (x > 2 || y > 2)
            {
                throw new Exception("X and Y must be less than 3");
            }
            else
            {
                board[x, y].SetState(state);
            }
        }

        public char CheckWin()
        {
            byte count;
            for (byte y = 0; y < 3; y++)
            {
                count = 0;
                for (byte x = 0; x < 3; x++)
                {
                    if (board[y, x].GetState() != ' ') count += 1;
                    if (count == 3) return board[y, x].GetState();
                }

            }
            for (byte x = 0; x < 3; x++)
            {
                count = 0;
                for (byte y = 0; y < 3; y++)
                {
                    if (board[y, x].GetState() != ' ') count += 1;
                    if (count == 3) return board[y, x].GetState();
                }

            }

            count = 0;
            for (byte i = 0; i < 3; i++)
            {
                if (board[i, i].GetState() != ' ') count += 1;
                if (count == 3) return board[i, i].GetState();
            }

            count = 0;
            for (byte i = 2; i > 0; i--)
            {
                if (board[i, i].GetState() != ' ') count += 1;
                if (count == 3) return board[i, i].GetState();
            }
            return ' ';
        }
    };
}
