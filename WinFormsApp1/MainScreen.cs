namespace WinFormsApp1
{   

    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        

        private void startButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.startButton.Hide();
            this.titleLabel.Hide();
            this.board.Show();
            this.backButton.Show();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            this.backButton.Hide();
            this.board.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resource.Shrek_transparent;
            this.startButton.Show();
            this.titleLabel.Show();
            this.backButton.Hide();
            this.board.Hide();
        }
    }
}