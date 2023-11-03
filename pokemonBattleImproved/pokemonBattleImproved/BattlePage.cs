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

        int HP = 10;
        public BattlePage()
        {
            InitializeComponent();
        }
        public BattlePage(string getpkname)
        {
            InitializeComponent();

            
            if (getpkname == "charmander") { charmanderWait(); }
            else if (getpkname == "elgyem") { elgyemWait(); }
            else if (getpkname == "eevee") { eeveeWait(); }
            else if (getpkname == "froakie") { froakieWait(); }
            else if (getpkname == "pikechu") { pikaWait(); }
            else if (getpkname == "rowlet") { rowletWait(); }
            else if (getpkname == "sandshrew") { sandshrewWait(); }
            else if (getpkname == "spinarak") { spinarakwWait(); }
            else if (getpkname == "squirtle") { squirtleWait(); }
            else if (getpkname == "zubat") { zubatWait(); }
            else if (getpkname == "shinx") { shinxWait(); }
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
        public void SetPokemon(string imputPlayerStuff)
        {
            if (imputPlayerStuff == "sandyrew") 
            {
                playerBox1.Image = Properties.Resources.sandshrewback;
                
            }
            else
            {
                
            }
        }
        

        public async void charmanderWait()
        {
            playerBox1.Image = Properties.Resources.charmanderfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.charmanderback;
        }

        public async void elgyemWait()
        {
            playerBox1.Image = Properties.Resources.Elgyemfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.Elgyemback;
        }

        public async void eeveeWait()
        {
            playerBox1.Image = Properties.Resources.eeveefront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.eeveeback;
        }
        public async void froakieWait()
        {
            playerBox1.Image = Properties.Resources.froakiefront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.froakieback;
        }
        public async void pikaWait()
        {
            playerBox1.Image = Properties.Resources.pikachufront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.pikachuback;
        }
        public async void rowletWait()
        {
            playerBox1.Image = Properties.Resources.rowletfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.rowletback;
        }
        public async void sandshrewWait()
        {
            playerBox1.Image = Properties.Resources.sandshrewfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.sandshrewback;
        }
        public async void shinxWait()
        {
            playerBox1.Image = Properties.Resources.shinxfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.shinxback;
        }
        public async void spinarakwWait()
        {
            playerBox1.Image = Properties.Resources.Spinarakfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.Spinarakback;
        }
        public async void squirtleWait()
        {
            playerBox1.Image = Properties.Resources.squirtlefront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.squirtleback;
        }
        public async void zubatWait()
        {
            playerBox1.Image = Properties.Resources.zubatfront;
            await Task.Delay(2000);
            playerBox1.Image = Properties.Resources.zubatback;
        }
    }
}
