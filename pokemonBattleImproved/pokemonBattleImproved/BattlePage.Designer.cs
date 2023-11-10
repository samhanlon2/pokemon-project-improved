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
            System.Windows.Forms.PictureBox pokemonLabel;
            this.AttackButton = new System.Windows.Forms.Button();
            this.EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerBox1 = new System.Windows.Forms.PictureBox();
            this.AttackPokeballPicture = new System.Windows.Forms.PictureBox();
            this.HealButton = new System.Windows.Forms.Button();
            this.PlayerHealthBar = new System.Windows.Forms.ProgressBar();
            this.DialogueBox = new System.Windows.Forms.TextBox();
            pokemonLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pokemonLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackPokeballPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonLabel
            // 
            pokemonLabel.BackColor = System.Drawing.Color.Transparent;
            pokemonLabel.Image = global::pokemonBattleImproved.Properties.Resources.PokemonSign_Image;
            pokemonLabel.Location = new System.Drawing.Point(-53, -84);
            pokemonLabel.Name = "pokemonLabel";
            pokemonLabel.Size = new System.Drawing.Size(371, 280);
            pokemonLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pokemonLabel.TabIndex = 10;
            pokemonLabel.TabStop = false;
            // 
            // AttackButton
            // 
            this.AttackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AttackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AttackButton.ForeColor = System.Drawing.Color.Firebrick;
            this.AttackButton.Location = new System.Drawing.Point(377, 579);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(213, 77);
            this.AttackButton.TabIndex = 5;
            this.AttackButton.Text = "Attack";
            this.AttackButton.UseVisualStyleBackColor = false;
            this.AttackButton.Click += new System.EventHandler(this.PokeballAttackButton_Click);
            // 
            // EnemyHealthBar
            // 
            this.EnemyHealthBar.Location = new System.Drawing.Point(843, 477);
            this.EnemyHealthBar.Name = "EnemyHealthBar";
            this.EnemyHealthBar.Size = new System.Drawing.Size(387, 45);
            this.EnemyHealthBar.TabIndex = 11;
            this.EnemyHealthBar.Value = 100;
            // 
            // playerBox1
            // 
            this.playerBox1.BackColor = System.Drawing.Color.Transparent;
            this.playerBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playerBox1.Location = new System.Drawing.Point(189, 279);
            this.playerBox1.Name = "playerBox1";
            this.playerBox1.Size = new System.Drawing.Size(240, 240);
            this.playerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerBox1.TabIndex = 8;
            this.playerBox1.TabStop = false;
            // 
            // AttackPokeballPicture
            // 
            this.AttackPokeballPicture.BackColor = System.Drawing.Color.Transparent;
            this.AttackPokeballPicture.Image = global::pokemonBattleImproved.Properties.Resources.WEHATEBINICLE;
            this.AttackPokeballPicture.Location = new System.Drawing.Point(930, 181);
            this.AttackPokeballPicture.Name = "AttackPokeballPicture";
            this.AttackPokeballPicture.Size = new System.Drawing.Size(218, 245);
            this.AttackPokeballPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttackPokeballPicture.TabIndex = 4;
            this.AttackPokeballPicture.TabStop = false;
            // 
            // HealButton
            // 
            this.HealButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HealButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HealButton.ForeColor = System.Drawing.Color.Firebrick;
            this.HealButton.Location = new System.Drawing.Point(70, 579);
            this.HealButton.Name = "HealButton";
            this.HealButton.Size = new System.Drawing.Size(213, 77);
            this.HealButton.TabIndex = 12;
            this.HealButton.Text = "Heal";
            this.HealButton.UseVisualStyleBackColor = false;
            this.HealButton.Click += new System.EventHandler(this.PokeballHealButton_Click);
            // 
            // PlayerHealthBar
            // 
            this.PlayerHealthBar.Location = new System.Drawing.Point(91, 212);
            this.PlayerHealthBar.Name = "PlayerHealthBar";
            this.PlayerHealthBar.Size = new System.Drawing.Size(387, 45);
            this.PlayerHealthBar.TabIndex = 13;
            this.PlayerHealthBar.Value = 100;
            // 
            // DialogueBox
            // 
            this.DialogueBox.BackColor = System.Drawing.Color.SteelBlue;
            this.DialogueBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DialogueBox.Location = new System.Drawing.Point(566, 293);
            this.DialogueBox.Multiline = true;
            this.DialogueBox.Name = "DialogueBox";
            this.DialogueBox.Size = new System.Drawing.Size(175, 195);
            this.DialogueBox.TabIndex = 14;
            // 
            // BattlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1403, 933);
            this.Controls.Add(this.DialogueBox);
            this.Controls.Add(this.PlayerHealthBar);
            this.Controls.Add(this.playerBox1);
            this.Controls.Add(this.HealButton);
            this.Controls.Add(this.EnemyHealthBar);
            this.Controls.Add(pokemonLabel);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.AttackPokeballPicture);
            this.Name = "BattlePage";
            this.RightToLeftLayout = true;
            this.Text = "battlePage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(pokemonLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackPokeballPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox AttackPokeballPicture;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pokemonLabel;
        private System.Windows.Forms.ProgressBar EnemyHealthBar;
        private System.Windows.Forms.Button HealButton;
        private PictureBox playerBox1;
        private ProgressBar PlayerHealthBar;
        private TextBox DialogueBox;
    }
}