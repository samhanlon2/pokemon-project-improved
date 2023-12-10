using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace pokemonBattleImproved
{
		public partial class PokemonSelection : Form
		{

				int CardHP = 0;
				int CardSpeed = 0;
				int CardAttack = 0;
				int CardDefense = 0;
				public PokemonSelection()
				{
						InitializeComponent();
				}
				private string pokemonPicked;
				private void PokemonSelection_Load(object sender, EventArgs e)
				{
						// make custom message box?

						// shows message before selection page opens
						//  MessageBox.Show("It's Time to Choose Your Pokemon!", "!POKEMON!");
				}

				// Charmander Selected
				private void CharmanderSelectionButton_Click(object sender, EventArgs e)
				{

						ResetStatBars();    // calls fucntion to resets stats bars
						pokemonPicked = "charmander";
						SoundPlayer CharmanderCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.CharmanderCry);
						CharmanderCry.Play();

						// changes Charmander choice color
						CharmanderSelectionButton.BackColor = Color.OrangeRed; // maybe we can use to say already looked at?? or not neccessary (can delete)

						// changes other button colors back to midnight blue
						CharmanderSelectedChangeOthersColorBack();

						// resetting the stats with pokemon stats
						CardHP = 39;
						CardSpeed = 30;
						CardAttack = 52;
						CardDefense = 43;

						// this section changes the information on the card to the selected pokemon

						// sets the card photo to selected pokemon by accessing the image list
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[0];
						// sets the card color to seledted pokemon by accessing image list
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[0];


						// changing card label to pokemon name 
						PokemonProfileName.Text = "Charmander";
						PokemonProfileName1.Text = " ヒトカゲ ";


						// changing card stat label to amount
						ProfileCardHPAmountLabel.Text = "39/100";
						ProfileCardSpeedAmountLabel.Text = "30/100";
						ProfileCardAttackAmountLabel.Text = "52/100";
						ProfileCardDefenseAmountLabel.Text = "43/100";


						// this section changes the colors of the card to selected pokemon

						// changes profile picture color
						PokemonProfilePicture.BackColor = Color.OrangeRed;

						// changing name label color
						PokemonProfileName.BackColor = Color.DarkOrange;
						PokemonProfileName1.BackColor = Color.DarkOrange;
						// changes stat label color
						ProfileCardHPLabel.BackColor = Color.DarkOrange;
						ProfileCardSpeedLabel.BackColor = Color.DarkOrange;
						ProfileCardAttackLabel.BackColor = Color.DarkOrange;
						ProfileCardDefenseLabel.BackColor = Color.DarkOrange;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.OrangeRed;
						ProfileCardSpeedAmountLabel.BackColor = Color.OrangeRed;
						ProfileCardAttackAmountLabel.BackColor = Color.OrangeRed;
						ProfileCardDefenseAmountLabel.BackColor = Color.OrangeRed;



						// incrementing the stats progress bars with selected pokemon stats
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						// enables choice button since it's disabled by default
						PokemonSelectionButton.Enabled = true;
				}

				private void CharmanderSelectedChangeOthersColorBack()
				{
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}


				// Elgyem Selected
				private void ElgyemSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "elgyem";
						SoundPlayer ElgyemCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.ElgyemCry);
						ElgyemCry.Play();

						// changes Elgyem choice color
						ElgyemSelectionButton.BackColor = Color.MediumTurquoise;

						// changes other button colors back to midnight blue
						ElgyemSelectedChangeOthersColorBack();

						CardHP = 55;
						CardSpeed = 30;
						CardAttack = 55;
						CardDefense = 55;

						// this section changes the information on the card to the selected pokemon

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[1];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[1];

						// name label change
						PokemonProfileName.Text = " Elgyem ";
						PokemonProfileName1.Text = " リグレー ";

						// card stat label change
						ProfileCardHPAmountLabel.Text = "55/100";
						ProfileCardSpeedAmountLabel.Text = "30/100";
						ProfileCardAttackAmountLabel.Text = "55/100";
						ProfileCardDefenseAmountLabel.Text = "55/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.MediumTurquoise;

						// name label color change
						PokemonProfileName.BackColor = Color.CornflowerBlue;
						PokemonProfileName1.BackColor = Color.CornflowerBlue;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.CornflowerBlue;
						ProfileCardSpeedLabel.BackColor = Color.CornflowerBlue;
						ProfileCardAttackLabel.BackColor = Color.CornflowerBlue;
						ProfileCardDefenseLabel.BackColor = Color.CornflowerBlue;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardSpeedAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardAttackAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardDefenseAmountLabel.BackColor = Color.RoyalBlue;


						// incrementing the stats progress bars with selected pokemon stats
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;
				}

				private void ElgyemSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}

				// Evee Selected
				private void EveeSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "eevee";
						SoundPlayer EeveeCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.EeveeCry);
						EeveeCry.Play();

						// changes Evee choice color
						EveeSelectionButton.BackColor = Color.SaddleBrown;

						// changes other button colors back to midnight blue
						EveeSelectedChangeOthersColorBack();

						CardHP = 55;
						CardSpeed = 55;
						CardAttack = 55;
						CardDefense = 50;

						// this section changes the information on the card to the selected pokemon

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[2];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[2];


						// name label change
						PokemonProfileName.Text = "Eevee";
						PokemonProfileName1.Text = " イーブイ ";


						// card stat label change
						ProfileCardHPAmountLabel.Text = "55/100";
						ProfileCardSpeedAmountLabel.Text = "55/100";
						ProfileCardAttackAmountLabel.Text = "55/100";
						ProfileCardDefenseAmountLabel.Text = "50/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.SaddleBrown;

						// name label color change
						PokemonProfileName.BackColor = Color.SandyBrown;
						PokemonProfileName1.BackColor = Color.SandyBrown;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.SandyBrown;
						ProfileCardSpeedLabel.BackColor = Color.SandyBrown;
						ProfileCardAttackLabel.BackColor = Color.SandyBrown;
						ProfileCardDefenseLabel.BackColor = Color.SandyBrown;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.SaddleBrown;
						ProfileCardSpeedAmountLabel.BackColor = Color.SaddleBrown;
						ProfileCardAttackAmountLabel.BackColor = Color.SaddleBrown;
						ProfileCardDefenseAmountLabel.BackColor = Color.SaddleBrown;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;
				}
				void EveeSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Froakie Selected
				private void FroakieSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "froakie";
						SoundPlayer FroakieCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.FroakieCry);
						FroakieCry.Play();

						// changes Froakie choice color
						FroakieSelectionButton.BackColor = Color.Navy;

						// changes other button colors back to midnight blue
						FroakieSelectedChangeOthersColorBack();

						CardHP = 41;
						CardSpeed = 71;
						CardAttack = 56;
						CardDefense = 40;

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[3];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[3];

						// name label change
						PokemonProfileName.Text = "Froakie";
						PokemonProfileName1.Text = " ケロマツ ";

						// card stat label change
						ProfileCardHPAmountLabel.Text = "41/100";
						ProfileCardSpeedAmountLabel.Text = "71/100";
						ProfileCardAttackAmountLabel.Text = "56/100";
						ProfileCardDefenseAmountLabel.Text = "40/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.Navy;

						// name label color change
						PokemonProfileName.BackColor = Color.CornflowerBlue;
						PokemonProfileName1.BackColor = Color.CornflowerBlue;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.CornflowerBlue;
						ProfileCardSpeedLabel.BackColor = Color.CornflowerBlue;
						ProfileCardAttackLabel.BackColor = Color.CornflowerBlue;
						ProfileCardDefenseLabel.BackColor = Color.CornflowerBlue;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardSpeedAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardAttackAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardDefenseAmountLabel.BackColor = Color.RoyalBlue;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;
				}
				void FroakieSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Pikachu Selected
				private void PikachuSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "pikachu";
						SoundPlayer PikachuCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.PikachuCry);
						PikachuCry.Play();

						// changes Pikachu choice color
						PikachuSelectionButton.BackColor = Color.Gold;

						// changes other button colors back to midnight blue
						PikachuSelectedChangeOthersColorBack();

						CardHP = 35;
						CardSpeed = 90;
						CardAttack = 55;
						CardDefense = 40;


						// this section changes the card information to selected pokemon

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[4];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[4];

						// name label change
						PokemonProfileName.Text = "Pikachu";
						PokemonProfileName1.Text = " ピカチュウ ";

						// card stat label change
						ProfileCardHPAmountLabel.Text = "35/100";
						ProfileCardSpeedAmountLabel.Text = "90/100";
						ProfileCardAttackAmountLabel.Text = "55/100";
						ProfileCardDefenseAmountLabel.Text = "40/100";



						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.Gold;

						// name label color change
						PokemonProfileName.BackColor = Color.DarkOrange;
						PokemonProfileName1.BackColor = Color.DarkOrange;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.Orange;
						ProfileCardSpeedLabel.BackColor = Color.Orange;
						ProfileCardAttackLabel.BackColor = Color.Orange;
						ProfileCardDefenseLabel.BackColor = Color.Orange;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardSpeedAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardAttackAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardDefenseAmountLabel.BackColor = Color.DarkOrange;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;
				}
				void PikachuSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Rowlet Selected
				private void RowletSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "rowlet";
						SoundPlayer RowletCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.RowletCry);
						RowletCry.Play();

						// changes Rowlet choice color
						RowletSelectionButton.BackColor = Color.MediumSeaGreen;

						// changes other button colors back to midnight blue
						RowletSelectedChangeOthersColorBack();

						CardHP = 68;
						CardSpeed = 42;
						CardAttack = 55;
						CardDefense = 55;

						// profile picture name
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[5];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[5];

						// name label change
						PokemonProfileName.Text = "Rowlet";
						PokemonProfileName1.Text = " モクロー ";


						// card stat label change
						ProfileCardHPAmountLabel.Text = "68/100";
						ProfileCardSpeedAmountLabel.Text = "42/100";
						ProfileCardAttackAmountLabel.Text = "55/100";
						ProfileCardDefenseAmountLabel.Text = "55/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.MediumSeaGreen;

						// name label color change
						PokemonProfileName.BackColor = Color.MediumSeaGreen;
						PokemonProfileName1.BackColor = Color.MediumSeaGreen;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardSpeedLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardAttackLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardDefenseLabel.BackColor = Color.MediumSeaGreen;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardSpeedAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardAttackAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardDefenseAmountLabel.BackColor = Color.SeaGreen;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;
				}
				void RowletSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Sandshrew Selected
				private void SandshrewSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "sandshrew";
						SoundPlayer SandshrewCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.SandshrewCry);
						SandshrewCry.Play();


						// changes Sandshrew choice color
						SandshrewSelectionButton.BackColor = Color.Goldenrod;

						// changes other button colors back to midnight blue
						SandshrewSelectedChangeOthersColorBack();

						CardHP = 50;
						CardSpeed = 30;
						CardAttack = 75;
						CardDefense = 85;

						// this section changes the card information to selected pokemon

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[6];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[6];

						// name label change
						PokemonProfileName.Text = "Sandshrew";
						PokemonProfileName1.Text = " サンド ";



						// card stat label change
						ProfileCardHPAmountLabel.Text = "50/100";
						ProfileCardSpeedAmountLabel.Text = "30/100";
						ProfileCardAttackAmountLabel.Text = "75/100";
						ProfileCardDefenseAmountLabel.Text = "85/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.Goldenrod;

						// name label color change
						PokemonProfileName.BackColor = Color.DarkOrange;
						PokemonProfileName1.BackColor = Color.DarkOrange;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.DarkOrange;
						ProfileCardSpeedLabel.BackColor = Color.DarkOrange;
						ProfileCardAttackLabel.BackColor = Color.DarkOrange;
						ProfileCardDefenseLabel.BackColor = Color.DarkOrange;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardSpeedAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardAttackAmountLabel.BackColor = Color.DarkOrange;
						ProfileCardDefenseAmountLabel.BackColor = Color.DarkOrange;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);


						PokemonSelectionButton.Enabled = true;

				}
				void SandshrewSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Shinx Selected
				private void ShinxSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "shinx";
						SoundPlayer ShinxCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.ShinxCry);
						ShinxCry.Play();

						// changes Shinx choice color
						ShinxSelectionButton.BackColor = Color.PowderBlue;

						// changes other button colors back to midnight blue
						ShinxSelectedChangeOthersColorBack();

						CardHP = 39;
						CardSpeed = 65;
						CardAttack = 52;
						CardDefense = 35;

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[7];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[7];

						// name label change
						PokemonProfileName.Text = "Shinx";
						PokemonProfileName1.Text = " コリンク ";

						// card stat label change
						ProfileCardHPAmountLabel.Text = "39/100";
						ProfileCardSpeedAmountLabel.Text = "65/100";
						ProfileCardAttackAmountLabel.Text = "52/100";
						ProfileCardDefenseAmountLabel.Text = "35/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.PowderBlue;

						// name label color change
						PokemonProfileName.BackColor = Color.CornflowerBlue;
						PokemonProfileName1.BackColor = Color.CornflowerBlue;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.CornflowerBlue;
						ProfileCardSpeedLabel.BackColor = Color.CornflowerBlue;
						ProfileCardAttackLabel.BackColor = Color.CornflowerBlue;
						ProfileCardDefenseLabel.BackColor = Color.CornflowerBlue;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardSpeedAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardAttackAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardDefenseAmountLabel.BackColor = Color.RoyalBlue;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;

				}
				void ShinxSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Spinarak Selected
				private void SpinarakSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "spinarak";
						SoundPlayer SpinarakCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.SpinarakCry);
						SpinarakCry.Play();

						// changes Spinarak choice color
						SpinarakSelectionButton.BackColor = Color.MediumSeaGreen;

						// changes other button colors back to midnight blue
						SpinarakSelectedChangeOthersColorBack();

						CardHP = 40;
						CardSpeed = 55;
						CardAttack = 60;
						CardDefense = 50;

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[8];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[8];

						// name label change
						PokemonProfileName.Text = "Spinarak";
						PokemonProfileName1.Text = " イトマル ";

						// card stat label change
						ProfileCardHPAmountLabel.Text = "40/100";
						ProfileCardSpeedAmountLabel.Text = "55/100";
						ProfileCardAttackAmountLabel.Text = "60/100";
						ProfileCardDefenseAmountLabel.Text = "50/100";

						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.MediumSeaGreen;

						// name label color change
						PokemonProfileName.BackColor = Color.MediumSeaGreen;
						PokemonProfileName1.BackColor = Color.MediumSeaGreen;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardSpeedLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardAttackLabel.BackColor = Color.MediumSeaGreen;
						ProfileCardDefenseLabel.BackColor = Color.MediumSeaGreen;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardSpeedAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardAttackAmountLabel.BackColor = Color.SeaGreen;
						ProfileCardDefenseAmountLabel.BackColor = Color.SeaGreen;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;

				}
				void SpinarakSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Squirtle Selected
				private void SquirtleSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "squirtle";
						SoundPlayer SquirtleCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.SquirtleCry);
						SquirtleCry.Play();

						// changes Squirtle choice color
						SquirtleSelectionButton.BackColor = Color.PowderBlue;

						// changes other button colors back to midnight blue
						SquirtleSelectedChangeOthersColorBack();

						CardHP = 44;
						CardSpeed = 43;
						CardAttack = 48;
						CardDefense = 65;

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[9];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[9];


						// name label change
						PokemonProfileName.Text = "Squirtle";
						PokemonProfileName1.Text = " ゼニガメ ";


						// card stat label change
						ProfileCardHPAmountLabel.Text = "44/100";
						ProfileCardSpeedAmountLabel.Text = "43/100";
						ProfileCardAttackAmountLabel.Text = "48/100";
						ProfileCardDefenseAmountLabel.Text = "65/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.PowderBlue;

						// name label color change
						PokemonProfileName.BackColor = Color.CornflowerBlue;
						PokemonProfileName1.BackColor = Color.CornflowerBlue;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.CornflowerBlue;
						ProfileCardSpeedLabel.BackColor = Color.CornflowerBlue;
						ProfileCardAttackLabel.BackColor = Color.CornflowerBlue;
						ProfileCardDefenseLabel.BackColor = Color.CornflowerBlue;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardSpeedAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardAttackAmountLabel.BackColor = Color.RoyalBlue;
						ProfileCardDefenseAmountLabel.BackColor = Color.RoyalBlue;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;

				}
				void SquirtleSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				// Zuabt Selected 
				private void ZubatSelectionButton_Click(object sender, EventArgs e)
				{
						ResetStatBars();
						pokemonPicked = "zubat";
						SoundPlayer ZubatCry = new SoundPlayer(pokemonBattleImproved.Properties.Resources.ZubatCry);
						ZubatCry.Play();

						// changes Zubat choice color
						ZubatSelectionButton.BackColor = Color.LightYellow;

						// changes other button colors back to midnight blue
						ZubatSelectedChangeOthersColorBack();

						CardHP = 40;
						CardSpeed = 53;
						CardAttack = 45;
						CardDefense = 35;



						// this section changes the card information to selected pokemon

						// profile picture change
						PokemonProfilePicture.Image = PokemonProfileImageList.Images[10];
						ProfileCardBackground.Image = ProfileCardBackgroundImageList.Images[10];


						// name label change
						PokemonProfileName.Text = "Zubat";
						PokemonProfileName1.Text = " ズバット ";



						// card stat label change
						ProfileCardHPAmountLabel.Text = "40/100";
						ProfileCardSpeedAmountLabel.Text = "53/100";
						ProfileCardAttackAmountLabel.Text = "45/100";
						ProfileCardDefenseAmountLabel.Text = "35/100";


						// this section changes the colors of the card to selected pokemon

						// profile picture color change
						PokemonProfilePicture.BackColor = Color.MediumPurple;

						// name label color change
						PokemonProfileName.BackColor = Color.MediumPurple;
						PokemonProfileName1.BackColor = Color.MediumPurple;

						// stat label color change
						ProfileCardHPLabel.BackColor = Color.CornflowerBlue;
						ProfileCardSpeedLabel.BackColor = Color.CornflowerBlue;
						ProfileCardAttackLabel.BackColor = Color.CornflowerBlue;
						ProfileCardDefenseLabel.BackColor = Color.CornflowerBlue;

						// changes stat amount label color
						ProfileCardHPAmountLabel.BackColor = Color.MediumPurple;
						ProfileCardSpeedAmountLabel.BackColor = Color.MediumPurple;
						ProfileCardAttackAmountLabel.BackColor = Color.MediumPurple;
						ProfileCardDefenseAmountLabel.BackColor = Color.MediumPurple;

						// changes Zubat choice color
						ZubatSelectionButton.BackColor = Color.MediumPurple;


						// incrementing the stats progress bars
						ProfileCardHPBar.Increment(CardHP);
						ProfileCardSpeedBar.Increment(CardSpeed);
						ProfileCardAttackBar.Increment(CardAttack);
						ProfileCardDefenseBar.Increment(CardDefense);

						PokemonSelectionButton.Enabled = true;

				}
				void ZubatSelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
				}

				// resets stats bar to zero so that they're not incremtning up every time a
				// pokemon is selected/ button is clicked
				private void ResetStatBars()
				{

						ProfileCardHPBar.Value = 0;
						ProfileCardSpeedBar.Value = 0;
						ProfileCardAttackBar.Value = 0;
						ProfileCardDefenseBar.Value = 0;
				}
				void SelectedChangeOthersColorBack()
				{
						CharmanderSelectionButton.BackColor = Color.Transparent;
						ElgyemSelectionButton.BackColor = Color.Transparent;
						EveeSelectionButton.BackColor = Color.Transparent;
						FroakieSelectionButton.BackColor = Color.Transparent;
						PikachuSelectionButton.BackColor = Color.Transparent;
						RowletSelectionButton.BackColor = Color.Transparent;
						SandshrewSelectionButton.BackColor = Color.Transparent;
						ShinxSelectionButton.BackColor = Color.Transparent;
						SpinarakSelectionButton.BackColor = Color.Transparent;
						SquirtleSelectionButton.BackColor = Color.Transparent;
						ZubatSelectionButton.BackColor = Color.Transparent;
				}
				private void PokemonSelectionButton_Click(object sender, EventArgs e)
				{
						// needs to be disabled until pokemon is selected

						this.Hide();

						//BattlePage battle = new BattlePage(pokemonPicked);
						BackgroundPickPage BG = new BackgroundPickPage(pokemonPicked);
						//battle.ShowDialog();
						//battle.SetPokemon(pokemonPicked);

						BG.Show();

				}

				private void PokemonProfilePicture_Click(object sender, EventArgs e)
				{
						pokemonPicked = "Zekrom";
						PokemonProfilePicture.Image = pokemonBattleImproved.Properties.Resources.zekrom;
						SoundPlayer zek = new SoundPlayer(pokemonBattleImproved.Properties.Resources.ZekromCry);
						zek.Play();
						PokemonSelectionButton.Enabled = true;
				}
		}
}
