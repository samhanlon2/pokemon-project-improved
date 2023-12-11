using System.Media;

namespace pokemonBattleImproved
{
		public partial class MainMenu : Form
		{
				SoundPlayer menumusic = new SoundPlayer(pokemonBattleImproved.Properties.Resources.Calm);
				public MainMenu()
				{
						InitializeComponent();

						menumusic.Play();
				}

				private void programExit_Click(object sender, EventArgs e)
				{
						SoundPlayer leave = new SoundPlayer(pokemonBattleImproved.Properties.Resources.CelesticaFlute);
						leave.Play();
						Environment.Exit(0);
				}

				private void Form1_Load(object sender, EventArgs e)
				{

				}

				private void next_Click(object sender, EventArgs e)
				{


						PokemonSelection setup = new PokemonSelection();
						menumusic.Stop();
						setup.Show();
						this.Hide();
				}

				private void pictureBox2_Click(object sender, EventArgs e)
				{

				}

				private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
				{
						SoundPlayer leave = new SoundPlayer(pokemonBattleImproved.Properties.Resources.CelesticaFlute);
						leave.Play();
						Environment.Exit(0);
				}
		}
}