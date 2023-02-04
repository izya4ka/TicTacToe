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
            BackgroundImage = null;
            startButton.Hide();
            titleLabel.Hide();
            backButton.Show();
            board.ShowAll();
        }
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            backButton.Hide();
            foreach(Cell cell in board.board)
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
            board.HideAll();

        }
    }
}