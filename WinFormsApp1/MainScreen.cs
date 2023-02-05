namespace WinFormsApp1
{

    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private Board board = new Board();

        private void startButton_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.fon2;
            startButton.Hide();
            titleLabel.Hide();
            backButton.Show();
            board.ShowAll();
            clearButton.Show();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            backButton.Hide();
            clearButton.Hide();
            foreach (Cell cell in board.board)
            {
                Controls.Add(cell);
                cell.Hide();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.Shrek_transparent;
            startButton.Show();
            titleLabel.Show();
            backButton.Hide();
            clearButton.Hide();
            board.HideAll();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            board.ClearBoard();
        }
    }
}