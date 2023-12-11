namespace pokemonBattleImproved
{
    partial class MainMenu
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
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
						next = new Button();
						programExit = new Button();
						pictureBox1 = new PictureBox();
						pictureBox2 = new PictureBox();
						pictureBox3 = new PictureBox();
						pictureBox4 = new PictureBox();
						((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
						((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
						((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
						((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
						SuspendLayout();
						// 
						// next
						// 
						next.BackColor = Color.Teal;
						next.Font = new Font("Sitka Banner", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
						next.ForeColor = Color.Black;
						next.Location = new Point(36, 554);
						next.Margin = new Padding(3, 4, 3, 4);
						next.Name = "next";
						next.Size = new Size(571, 200);
						next.TabIndex = 0;
						next.Text = "Start Game";
						next.UseVisualStyleBackColor = false;
						next.Click += next_Click;
						// 
						// programExit
						// 
						programExit.BackColor = Color.Firebrick;
						programExit.Font = new Font("Sitka Banner", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
						programExit.Location = new Point(731, 554);
						programExit.Margin = new Padding(3, 4, 3, 4);
						programExit.Name = "programExit";
						programExit.Size = new Size(571, 200);
						programExit.TabIndex = 1;
						programExit.Text = "Exit Application";
						programExit.UseVisualStyleBackColor = false;
						programExit.Click += programExit_Click;
						// 
						// pictureBox1
						// 
						pictureBox1.BackColor = Color.Transparent;
						pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
						pictureBox1.Location = new Point(400, -43);
						pictureBox1.Margin = new Padding(3, 4, 3, 4);
						pictureBox1.Name = "pictureBox1";
						pictureBox1.Size = new Size(571, 373);
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
						pictureBox1.TabIndex = 2;
						pictureBox1.TabStop = false;
						// 
						// pictureBox2
						// 
						pictureBox2.BackColor = Color.Transparent;
						pictureBox2.Image = Properties.Resources.NicePng_pokeball_png_124701;
						pictureBox2.Location = new Point(575, 260);
						pictureBox2.Margin = new Padding(3, 4, 3, 4);
						pictureBox2.Name = "pictureBox2";
						pictureBox2.Size = new Size(230, 235);
						pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
						pictureBox2.TabIndex = 3;
						pictureBox2.TabStop = false;
						pictureBox2.Click += pictureBox2_Click;
						// 
						// pictureBox3
						// 
						pictureBox3.BackColor = Color.Transparent;
						pictureBox3.Image = Properties.Resources.animated_bike;
						pictureBox3.Location = new Point(605, 787);
						pictureBox3.Name = "pictureBox3";
						pictureBox3.Size = new Size(125, 129);
						pictureBox3.TabIndex = 4;
						pictureBox3.TabStop = false;
						// 
						// pictureBox4
						// 
						pictureBox4.BackColor = Color.Transparent;
						pictureBox4.Image = Properties.Resources.lugia;
						pictureBox4.Location = new Point(961, 250);
						pictureBox4.Name = "pictureBox4";
						pictureBox4.Size = new Size(375, 229);
						pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
						pictureBox4.TabIndex = 5;
						pictureBox4.TabStop = false;
						// 
						// MainMenu
						// 
						AutoScaleDimensions = new SizeF(8F, 20F);
						AutoScaleMode = AutoScaleMode.Font;
						BackgroundImage = Properties.Resources.Ocean;
						BackgroundImageLayout = ImageLayout.Stretch;
						ClientSize = new Size(1382, 953);
						Controls.Add(pictureBox3);
						Controls.Add(pictureBox2);
						Controls.Add(pictureBox1);
						Controls.Add(programExit);
						Controls.Add(next);
						Controls.Add(pictureBox4);
						Margin = new Padding(3, 4, 3, 4);
						Name = "MainMenu";
						Text = "Pokemon Select";
						FormClosed += MainMenu_FormClosed;
						Load += Form1_Load;
						((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
						((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
						((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
						((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
						ResumeLayout(false);
				}

				#endregion

				private Button next;
        private Button programExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}