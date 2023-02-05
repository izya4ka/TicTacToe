namespace WinFormsApp1
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackgroundImage = global::WinFormsApp1.Resources.ehat;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Location = new System.Drawing.Point(624, 587);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 51);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Ехать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(11, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(305, 67);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Крестыноли";
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::WinFormsApp1.Resources.spina;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(11, 587);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 53);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Спина";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = global::WinFormsApp1.Resources.uborka;
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Location = new System.Drawing.Point(624, 587);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(181, 51);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Уборка";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WinFormsApp1.Resources.Shrek_transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(818, 652);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private Label titleLabel;
        private Button backButton;
        private Button clearButton;
    }
}