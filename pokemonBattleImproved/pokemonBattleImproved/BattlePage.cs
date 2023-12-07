using MoveClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemonBattleImproved
{
    public partial class BattlePage : Form
    {

        bool shiny;
        PokemonInfo player = new PokemonInfo();
        PokemonInfo enemy = new PokemonInfo();
        
        public BattlePage()
        {
            InitializeComponent();
        }
        public BattlePage(string getpkname, string getbgname)
        {
            shiny = shinyChance();
            Random rand = new Random();

            InitializeComponent();

            int enemyChoice = rand.Next(1, 12);

            if (enemyChoice == 1)
            {
                enemy.setPokemon("charmander");
            } else if(enemyChoice == 2)
            {
                enemy.setPokemon("elgyem"); 
            } else if(enemyChoice == 3)
            {
                enemy.setPokemon("eevee");
            } else if(enemyChoice == 4)
            {
                enemy.setPokemon("froakie");
            } else if(enemyChoice == 5)
            {
                enemy.setPokemon("pikachu");
            } else if (enemyChoice == 6)
            {
                enemy.setPokemon("rowlet");
            } else if (enemyChoice == 7)
            {
                enemy.setPokemon("sandshrew");
            } else if (enemyChoice == 8)
            {
                enemy.setPokemon("shinx");
            } else if (enemyChoice == 9)
            {
                enemy.setPokemon("spinarak");
            } else if (enemyChoice == 10)
            {
                enemy.setPokemon("squirtle");
            } else if (enemyChoice == 11)
            {
                enemy.setPokemon("zubat");
            }

            BackgroundImage = Properties.Resources.desert;
            if (getbgname == "desert") { 
            BackgroundImage = Properties.Resources.desert; 
            SoundPlayer dessertb = new SoundPlayer(pokemonBattleImproved.Properties.Resources.desertbattle);
            dessertb.Play();
            }
            else if (getbgname == "field") { BackgroundImage = Properties.Resources.field; }
            else if (getbgname == "forest") {
            BackgroundImage = Properties.Resources.forest;
            SoundPlayer forrestb = new SoundPlayer(pokemonBattleImproved.Properties.Resources.forestbattle);
            forrestb.Play();
            }
            else if (getbgname == "grassland") {
            BackgroundImage = Properties.Resources.grass;
            SoundPlayer grasslandsb = new SoundPlayer(pokemonBattleImproved.Properties.Resources.grasslandbattle);
            grasslandsb.Play();
            }
            else if (getbgname == "plains") 
            { 
            BackgroundImage = Properties.Resources.ground;
            SoundPlayer plainsb = new SoundPlayer(pokemonBattleImproved.Properties.Resources.plainsbattle);
            plainsb.Play();
            }
            else if (getbgname == "mudland") { BackgroundImage = Properties.Resources.Rocky; }
            else if (getbgname == "tundra") { BackgroundImage = Properties.Resources.Snow; }
            else if (getbgname == "voidfield") {
            BackgroundImage = Properties.Resources.space_field;
            SoundPlayer vf = new SoundPlayer(pokemonBattleImproved.Properties.Resources.voidfield);
            vf.Play();
            }
            else if (getbgname == "space") { BackgroundImage = Properties.Resources.space_void; }
            else if (getbgname == "underground") { BackgroundImage = Properties.Resources.underground; }
            else if (getbgname == "water") { BackgroundImage = Properties.Resources.water; }

            player.setPokemon(getpkname);
            PlayerNameLabel.Text = player.getName();
            PlayerHealthBar.Maximum = player.getMaxHP();
            PlayerHealthBar.Value = player.getHP();
            EnemyNameLabel.Text = enemy.getName();
            EnemyHealthBar.Maximum = enemy.getMaxHP();
            EnemyHealthBar.Value = enemy.getHP();
            enemyImage.Image = enemy.getFrontImage();
            MoveButton1.Text = player.getMove1Name();
            MoveButton2.Text = player.getMove2Name();
            MoveButton3.Text = player.getMove3Name();
            MoveButton4.Text = player.getMove4Name();
            Wait();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //AttackPokeballPicture.Hide();
      
            
        }

        private async void PokeballAttackButton_Click(object sender, EventArgs e)
        {
           MoveButton1.Enabled = false;
           MoveButton2.Enabled = false;
           MoveButton3.Enabled = false;
           MoveButton4.Enabled = false;
           damageCalc(player.getMove1(), player, enemy);
           statusBox.Text = player.getName() + " used " + player.getMove1Name();
           await Task.Delay(1000);
           EnemyHealthBar.Value = enemy.getHP();
           winstate();
           await Task.Delay(1000);
           enemyMove();
           statusBox.Text = enemy.getName() + " attacked back";
           await Task.Delay(1000);
           PlayerHealthBar.Value = player.getHP();
           await Task.Delay(1000);
           MoveButton1.Enabled = true;
           MoveButton2.Enabled = true;
           MoveButton3.Enabled = true;
           MoveButton4.Enabled = true;
           winstate();
        }

        private void winstate()
        {
            if (player.getHP() == 0)
            {
                MessageBox.Show(enemy.getName() + " beat you, you lose!");
            }
            else if (enemy.getHP() == 0)
            {
                MessageBox.Show(enemy.getName() + " beaten, you win!");
            }
        }
        

        public async void Wait()
        {
            if (shiny == true)
            {
                playerBox1.Image = player.getFrontShiny();
                await Task.Delay(2000);
                playerBox1.Image = player.getBackShiny();
            }
            else
            {
                playerBox1.Image = player.getFrontImage();
                await Task.Delay(2000);
                playerBox1.Image = player.getBackImage();
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

        public void damageCalc(Move usedMove, PokemonInfo attacker, PokemonInfo defender)
        {
            if (usedMove.getType() == 1)
            {
                if ((defender.getHP() - ((usedMove.getPower() + attacker.getAtk()) / defender.getDef()) * 5) <= 0)
                {
                    defender.setHP(0);
                } else
                {
                    defender.setHP(defender.getHP() - ((usedMove.getPower() + attacker.getAtk()) / defender.getDef()) * 5);
                }
            } else if (usedMove.getType() == 2)
            {
                if ((attacker.getHP() + usedMove.getHealAmt()) >= attacker.getMaxHP())
                {
                    attacker.setHP(attacker.getMaxHP());
                } else
                {
                    attacker.setHP(attacker.getHP() + usedMove.getHealAmt());
                }
            } else if (usedMove.getType() == 3)
            {
                attacker.setDef(attacker.getDef() + usedMove.getDefIncrease());
            }
        }

        public void enemyMove()
        {
            Random rand = new Random();
            int enemyMove = rand.Next(1, 5);
            if (enemyMove == 1)
            {
                damageCalc(enemy.getMove1(), enemy, player);
            }
            else if (enemyMove == 2)
            {
                damageCalc(enemy.getMove2(), enemy, player);
            } else if (enemyMove == 3)
            {
                damageCalc(enemy.getMove3(), enemy, player);
            } else if (enemyMove == 4)
            {
                damageCalc(enemy.getMove4(), enemy, player);
            }
        }

        private async void MoveButton2_Click(object sender, EventArgs e)
        {
            winstate();
            MoveButton1.Enabled = false;
            MoveButton2.Enabled = false;
            MoveButton3.Enabled = false;
            MoveButton4.Enabled = false;
            damageCalc(player.getMove2(), player, enemy);
            statusBox.Text = player.getName() + " used " + player.getMove2Name();
            await Task.Delay(1000);
            EnemyHealthBar.Value = enemy.getHP();
            await Task.Delay(1000);
            enemyMove();
            statusBox.Text = enemy.getName() + " attacked back";
            await Task.Delay(1000);
            PlayerHealthBar.Value = player.getHP();
            await Task.Delay(1000);
            MoveButton1.Enabled = true;
            MoveButton2.Enabled = true;
            MoveButton3.Enabled = true;
            MoveButton4.Enabled = true;
            winstate();
        }

        private async void MoveButton3_Click(object sender, EventArgs e)
        {
            winstate();
            MoveButton1.Enabled = false;
            MoveButton2.Enabled = false;
            MoveButton3.Enabled = false;
            MoveButton4.Enabled = false;
            damageCalc(player.getMove3(), player, enemy);
            statusBox.Text = player.getName() + " used " + player.getMove3Name();
            await Task.Delay(1000);
            EnemyHealthBar.Value = enemy.getHP();
            await Task.Delay(1000);
            enemyMove();
            statusBox.Text = enemy.getName() + " attacked back";
            await Task.Delay(1000);
            PlayerHealthBar.Value = player.getHP();
            await Task.Delay(1000);
            MoveButton1.Enabled = true;
            MoveButton2.Enabled = true;
            MoveButton3.Enabled = true;
            MoveButton4.Enabled = true;
            winstate();
        }

        private async void MoveButton4_Click(object sender, EventArgs e)
        {
            winstate();
            MoveButton1.Enabled = false;
            MoveButton2.Enabled = false;
            MoveButton3.Enabled = false;
            MoveButton4.Enabled = false;
            damageCalc(player.getMove4(), player, enemy);
            statusBox.Text = player.getName() + " used " + player.getMove4Name();
            await Task.Delay(1000);
            EnemyHealthBar.Value = enemy.getHP();
            await Task.Delay(1000);
            enemyMove();
            statusBox.Text = enemy.getName() + " attacked back";
            await Task.Delay(1000);
            PlayerHealthBar.Value = player.getHP();
            await Task.Delay(1000);
            MoveButton1.Enabled = true;
            MoveButton2.Enabled = true;
            MoveButton3.Enabled = true;
            MoveButton4.Enabled = true;
            winstate();
        }
    }
}
