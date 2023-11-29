using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemonBattleImproved
{
    public partial class BattlePage : Form
    {

        bool shiny;
        
        public BattlePage()
        {
            InitializeComponent();
        }
        public BattlePage(string getpkname, string getbgname)
        {
            shiny = shinyChance();

            InitializeComponent();

            BackgroundImage = Properties.Resources.desert;
            if (getbgname == "desert") { BackgroundImage = Properties.Resources.desert; }
            else if (getbgname == "field") { BackgroundImage = Properties.Resources.field; }
            else if (getbgname == "forest") { BackgroundImage = Properties.Resources.forest; }
            else if (getbgname == "grassland") { BackgroundImage = Properties.Resources.grass; }
            else if (getbgname == "plains") { BackgroundImage = Properties.Resources.ground; }
            else if (getbgname == "mudland") { BackgroundImage = Properties.Resources.Rocky; }
            else if (getbgname == "tundra") { BackgroundImage = Properties.Resources.Snow; }
            else if (getbgname == "voidfield") { BackgroundImage = Properties.Resources.space_field; }
            else if (getbgname == "space") { BackgroundImage = Properties.Resources.space_void; }
            else if (getbgname == "underground") { BackgroundImage = Properties.Resources.underground; }
            else if (getbgname == "water") { BackgroundImage = Properties.Resources.water; }

            PokemonInfo player = new PokemonInfo(getpkname);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //AttackPokeballPicture.Hide();
            
        }

        private async void PokeballAttackButton_Click(object sender, EventArgs e)
        {
            winstate();
           AttackButton.Enabled = false;
           HealButton.Enabled = false;
           DialogueBox.Text = "Player used attack 1 and it dealt 20 damage";
           await Task.Delay(1000);
           EnemyHealthBar.Increment(-30);
           await Task.Delay(1000);
           DialogueBox.Text = "Binacle attacked back";
           await Task.Delay(1000);
           PlayerHealthBar.Increment(-20);
           await Task.Delay(1000);
           AttackButton.Enabled = true;
           HealButton.Enabled = true;
           winstate();


        }

        private async void PokeballHealButton_Click(object sender, EventArgs e)
        {
            winstate();
            AttackButton.Enabled = false;
            HealButton.Enabled = false;
            DialogueBox.Text = "you healed your pokemon for 25 HP";
            await Task.Delay(1000);
            PlayerHealthBar.Increment(+15);
            await Task.Delay(1000);
            DialogueBox.Text = "Binacle attacked";
            PlayerHealthBar.Increment(-10);
            AttackButton.Enabled = true;
            HealButton.Enabled = true;
            winstate();

        }
        private void winstate()
        {
            if (PlayerHealthBar.Value == 0)
            {
                MessageBox.Show("Binacle beat you, you lose!");
            }
            else if (EnemyHealthBar.Value == 0)
            {
                MessageBox.Show("Binacle beaten, you win!");
            }
        }
        /*public void SetPokemon(string imputPlayerStuff)
        {
            if (imputPlayerStuff == "sandyrew") 
            {
               playerBox1.Image = Properties.Resources.sandshrewback;
                
            }
            else
            {
                
            }
        }*/
        

        public async void charmanderWait()
        {
            if (shiny == true)
            {
                playerBox1.Image = player.getFrontShiny();
                await Task.Delay(2000);
                playerBox1.Image = Properties.Resources.charmanderbackshiny;
            }
            else
            {
                playerBox1.Image = Properties.Resources.charmanderfront;
                await Task.Delay(2000);
                playerBox1.Image = Properties.Resources.charmanderback;
            }
        }

        
        
        public bool shinyChance() //chance of shiny       
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3); //random chance between 1-2
            bool isShiny;

            if (randomNumber == 2) 
            { 
             isShiny = true;
             return isShiny;   
            }
            else 
            {
                isShiny= false;
                return isShiny; 
            }
        }
    }
}
