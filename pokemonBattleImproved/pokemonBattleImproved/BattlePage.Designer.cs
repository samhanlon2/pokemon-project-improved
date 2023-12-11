namespace pokemonBattleImproved
{
    partial class BattlePage
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
						MoveButton1 = new Button();
						EnemyHealthBar = new ProgressBar();
						playerBox1 = new PictureBox();
						enemyImage = new PictureBox();
						PlayerHealthBar = new ProgressBar();
						MoveButton2 = new Button();
						MoveButton3 = new Button();
						MoveButton4 = new Button();
						PlayerNameLabel = new Label();
						EnemyNameLabel = new Label();
						statusBox = new Label();
						((System.ComponentModel.ISupportInitialize)playerBox1).BeginInit();
						((System.ComponentModel.ISupportInitialize)enemyImage).BeginInit();
						SuspendLayout();
						// 
						// MoveButton1
						// 
						MoveButton1.BackColor = Color.LightCoral;
						MoveButton1.FlatStyle = FlatStyle.Popup;
						MoveButton1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
						MoveButton1.ForeColor = Color.Black;
						MoveButton1.Location = new Point(920, 653);
						MoveButton1.Name = "MoveButton1";
						MoveButton1.Size = new Size(213, 77);
						MoveButton1.TabIndex = 5;
						MoveButton1.Text = "Attack";
						MoveButton1.UseVisualStyleBackColor = false;
						MoveButton1.Click += PokeballAttackButton_Click;
						// 
						// EnemyHealthBar
						// 
						EnemyHealthBar.Location = new Point(989, 165);
						EnemyHealthBar.Name = "EnemyHealthBar";
						EnemyHealthBar.Size = new Size(387, 45);
						EnemyHealthBar.TabIndex = 11;
						EnemyHealthBar.Value = 100;
						// 
						// playerBox1
						// 
						playerBox1.BackColor = Color.Transparent;
						playerBox1.BackgroundImageLayout = ImageLayout.Stretch;
						playerBox1.Location = new Point(115, 528);
						playerBox1.Name = "playerBox1";
						playerBox1.Size = new Size(368, 331);
						playerBox1.SizeMode = PictureBoxSizeMode.Zoom;
						playerBox1.TabIndex = 8;
						playerBox1.TabStop = false;
						// 
						// enemyImage
						// 
						enemyImage.BackColor = Color.Transparent;
						enemyImage.Image = Properties.Resources.WEHATEBINICLE;
						enemyImage.Location = new Point(885, 296);
						enemyImage.Name = "enemyImage";
						enemyImage.Size = new Size(277, 291);
						enemyImage.SizeMode = PictureBoxSizeMode.Zoom;
						enemyImage.TabIndex = 4;
						enemyImage.TabStop = false;
						// 
						// PlayerHealthBar
						// 
						PlayerHealthBar.Location = new Point(24, 477);
						PlayerHealthBar.Name = "PlayerHealthBar";
						PlayerHealthBar.Size = new Size(387, 45);
						PlayerHealthBar.TabIndex = 13;
						PlayerHealthBar.Value = 100;
						// 
						// MoveButton2
						// 
						MoveButton2.BackColor = Color.SandyBrown;
						MoveButton2.FlatStyle = FlatStyle.Popup;
						MoveButton2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
						MoveButton2.ForeColor = Color.Black;
						MoveButton2.Location = new Point(1170, 653);
						MoveButton2.Name = "MoveButton2";
						MoveButton2.Size = new Size(213, 77);
						MoveButton2.TabIndex = 15;
						MoveButton2.Text = "Attack";
						MoveButton2.UseVisualStyleBackColor = false;
						MoveButton2.Click += MoveButton2_Click;
						// 
						// MoveButton3
						// 
						MoveButton3.BackColor = Color.YellowGreen;
						MoveButton3.FlatStyle = FlatStyle.Popup;
						MoveButton3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
						MoveButton3.ForeColor = Color.Black;
						MoveButton3.Location = new Point(920, 767);
						MoveButton3.Name = "MoveButton3";
						MoveButton3.Size = new Size(213, 77);
						MoveButton3.TabIndex = 16;
						MoveButton3.Text = "Attack";
						MoveButton3.UseVisualStyleBackColor = false;
						MoveButton3.Click += MoveButton3_Click;
						// 
						// MoveButton4
						// 
						MoveButton4.BackColor = Color.Turquoise;
						MoveButton4.FlatStyle = FlatStyle.Popup;
						MoveButton4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
						MoveButton4.ForeColor = Color.Black;
						MoveButton4.Location = new Point(1170, 767);
						MoveButton4.Name = "MoveButton4";
						MoveButton4.Size = new Size(213, 77);
						MoveButton4.TabIndex = 17;
						MoveButton4.Text = "Attack";
						MoveButton4.UseVisualStyleBackColor = false;
						MoveButton4.Click += MoveButton4_Click;
						// 
						// PlayerNameLabel
						// 
						PlayerNameLabel.BackColor = Color.AliceBlue;
						PlayerNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
						PlayerNameLabel.Location = new Point(24, 428);
						PlayerNameLabel.Name = "PlayerNameLabel";
						PlayerNameLabel.Size = new Size(255, 47);
						PlayerNameLabel.TabIndex = 18;
						PlayerNameLabel.Text = "label1";
						PlayerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
						// 
						// EnemyNameLabel
						// 
						EnemyNameLabel.BackColor = Color.AliceBlue;
						EnemyNameLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
						EnemyNameLabel.Location = new Point(989, 115);
						EnemyNameLabel.Name = "EnemyNameLabel";
						EnemyNameLabel.Size = new Size(261, 47);
						EnemyNameLabel.TabIndex = 19;
						EnemyNameLabel.Text = "label2";
						EnemyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
						// 
						// statusBox
						// 
						statusBox.BackColor = SystemColors.ButtonFace;
						statusBox.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
						statusBox.Location = new Point(24, 94);
						statusBox.Name = "statusBox";
						statusBox.Size = new Size(470, 172);
						statusBox.TabIndex = 20;
						statusBox.TextAlign = ContentAlignment.MiddleCenter;
						// 
						// BattlePage
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						BackColor = Color.MidnightBlue;
						BackgroundImage = Properties.Resources.space_void;
						BackgroundImageLayout = ImageLayout.Zoom;
						ClientSize = new Size(1403, 933);
						Controls.Add(statusBox);
						Controls.Add(EnemyNameLabel);
						Controls.Add(PlayerNameLabel);
						Controls.Add(MoveButton4);
						Controls.Add(MoveButton3);
						Controls.Add(MoveButton2);
						Controls.Add(PlayerHealthBar);
						Controls.Add(playerBox1);
						Controls.Add(EnemyHealthBar);
						Controls.Add(MoveButton1);
						Controls.Add(enemyImage);
						DoubleBuffered = true;
						Name = "BattlePage";
						RightToLeftLayout = true;
						Text = "battlePage";
						FormClosed += BattlePage_FormClosed;
						Load += Form2_Load;
						((System.ComponentModel.ISupportInitialize)playerBox1).EndInit();
						((System.ComponentModel.ISupportInitialize)enemyImage).EndInit();
						ResumeLayout(false);
				}

				#endregion
				private System.Windows.Forms.PictureBox enemyImage;
        private System.Windows.Forms.Button MoveButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar EnemyHealthBar;
        private PictureBox playerBox1;
        private ProgressBar PlayerHealthBar;
        private Button MoveButton2;
        private Button MoveButton3;
        private Button MoveButton4;
        private Label PlayerNameLabel;
        private Label EnemyNameLabel;
        private Label statusBox;
    }
}