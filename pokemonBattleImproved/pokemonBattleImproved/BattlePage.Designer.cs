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
            this.MoveButton1 = new System.Windows.Forms.Button();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerBox1 = new System.Windows.Forms.PictureBox();
            this.enemyImage = new System.Windows.Forms.PictureBox();
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.MoveButton2 = new System.Windows.Forms.Button();
            this.MoveButton3 = new System.Windows.Forms.Button();
            this.MoveButton4 = new System.Windows.Forms.Button();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveButton1
            // 
            this.MoveButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveButton1.ForeColor = System.Drawing.Color.Firebrick;
            this.MoveButton1.Location = new System.Drawing.Point(799, 533);
            this.MoveButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton1.Name = "MoveButton1";
            this.MoveButton1.Size = new System.Drawing.Size(186, 58);
            this.MoveButton1.TabIndex = 5;
            this.MoveButton1.Text = "Attack";
            this.MoveButton1.UseVisualStyleBackColor = false;
            this.MoveButton1.Click += new System.EventHandler(this.PokeballAttackButton_Click);
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Location = new System.Drawing.Point(865, 11);
            this.EnemyHealthBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(339, 34);
            this.EnemyHealthBar.TabIndex = 11;
            this.EnemyHealthBar.Value = 100;
            // 
            // playerBox1
            // 
            this.playerBox1.BackColor = System.Drawing.Color.Transparent;
            this.playerBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox1.Location = new System.Drawing.Point(101, 396);
            this.playerBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerBox1.Name = "playerBox1";
            this.playerBox1.Size = new System.Drawing.Size(322, 248);
            this.playerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerBox1.TabIndex = 8;
            this.playerBox1.TabStop = false;
            // 
            // enemyImage
            // 
            this.enemyImage.BackColor = System.Drawing.Color.Transparent;
            this.enemyImage.Image = global::pokemonBattleImproved.Properties.Resources.WEHATEBINICLE;
            this.enemyImage.Location = new System.Drawing.Point(774, 222);
            this.enemyImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enemyImage.Name = "enemyImage";
            this.enemyImage.Size = new System.Drawing.Size(242, 218);
            this.enemyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyImage.TabIndex = 4;
            this.enemyImage.TabStop = false;
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.Location = new System.Drawing.Point(21, 358);
            this.PlayerHealthBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(339, 34);
            this.PlayerHealthBar.TabIndex = 13;
            this.PlayerHealthBar.Value = 100;
            // 
            // MoveButton2
            // 
            this.MoveButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoveButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveButton2.ForeColor = System.Drawing.Color.Firebrick;
            this.MoveButton2.Location = new System.Drawing.Point(1018, 533);
            this.MoveButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton2.Name = "MoveButton2";
            this.MoveButton2.Size = new System.Drawing.Size(186, 58);
            this.MoveButton2.TabIndex = 15;
            this.MoveButton2.Text = "Attack";
            this.MoveButton2.UseVisualStyleBackColor = false;
            this.MoveButton2.Click += new System.EventHandler(this.MoveButton2_Click);
            // 
            // MoveButton3
            // 
            this.MoveButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoveButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveButton3.ForeColor = System.Drawing.Color.Firebrick;
            this.MoveButton3.Location = new System.Drawing.Point(799, 619);
            this.MoveButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton3.Name = "MoveButton3";
            this.MoveButton3.Size = new System.Drawing.Size(186, 58);
            this.MoveButton3.TabIndex = 16;
            this.MoveButton3.Text = "Attack";
            this.MoveButton3.UseVisualStyleBackColor = false;
            this.MoveButton3.Click += new System.EventHandler(this.MoveButton3_Click);
            // 
            // MoveButton4
            // 
            this.MoveButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MoveButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveButton4.ForeColor = System.Drawing.Color.Firebrick;
            this.MoveButton4.Location = new System.Drawing.Point(1018, 619);
            this.MoveButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton4.Name = "MoveButton4";
            this.MoveButton4.Size = new System.Drawing.Size(186, 58);
            this.MoveButton4.TabIndex = 17;
            this.MoveButton4.Text = "Attack";
            this.MoveButton4.UseVisualStyleBackColor = false;
            this.MoveButton4.Click += new System.EventHandler(this.MoveButton4_Click);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerNameLabel.Location = new System.Drawing.Point(21, 321);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(339, 35);
            this.PlayerNameLabel.TabIndex = 18;
            this.PlayerNameLabel.Text = "label1";
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.EnemyNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnemyNameLabel.Location = new System.Drawing.Point(865, 47);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(339, 35);
            this.EnemyNameLabel.TabIndex = 19;
            this.EnemyNameLabel.Text = "label2";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusBox.Location = new System.Drawing.Point(12, 9);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(411, 129);
            this.statusBox.TabIndex = 20;
            // 
            // BattlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::pokemonBattleImproved.Properties.Resources.space_void;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1228, 700);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.EnemyNameLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.MoveButton4);
            this.Controls.Add(this.MoveButton3);
            this.Controls.Add(this.MoveButton2);
            this.Controls.Add(this.PlayerHealthBar);
            this.Controls.Add(this.playerBox1);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(this.MoveButton1);
            this.Controls.Add(this.enemyImage);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BattlePage";
            this.RightToLeftLayout = true;
            this.Text = "battlePage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyImage)).EndInit();
            this.ResumeLayout(false);

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