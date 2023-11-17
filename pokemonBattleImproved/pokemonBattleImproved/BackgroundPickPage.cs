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
    public partial class BackgroundPickPage : Form
    {
        private string BackgroundPicked;
        private string pickedpokemon;

        public BackgroundPickPage()
        {
            InitializeComponent();
            
        }
        public BackgroundPickPage(string getpkname)
        {
            InitializeComponent();
            pickedpokemon = getpkname;
            label13.Text = "Selected:";
            

        }
        private void button1_Click(object sender, EventArgs e)//deseert
        {
            BackgroundPicked = "desert";
            label13.Text = "Selected: Desert";
        }

        private void button2_Click(object sender, EventArgs e)//field
        {
            BackgroundPicked = "field";
            label13.Text = "Selected: Field";

        }

        private void button3_Click(object sender, EventArgs e)//forest
        {
            BackgroundPicked = "forest";
            label13.Text = "Selected: Forest";

        }

        private void button4_Click(object sender, EventArgs e)//grassland
        {
            BackgroundPicked = "grassland";
            label13.Text = "Selected: Grassland";

        }

        private void button5_Click(object sender, EventArgs e)//plains
        {
            BackgroundPicked = "plains";
            label13.Text = "Selected: Plains";

        }

        private void button6_Click(object sender, EventArgs e)//mudland
        {
            BackgroundPicked = "mudland";
            label13.Text = "Selected: Mudland";

        }

        private void button7_Click(object sender, EventArgs e)//tundra
        {
            BackgroundPicked = "tundra";
            label13.Text = "Selected: Tundra";

        }

        private void button8_Click(object sender, EventArgs e)//void field
        {
            BackgroundPicked = "voidfield";
            label13.Text = "Selected: Void Field";

        }

        private void button11_Click(object sender, EventArgs e)//space
        {
            BackgroundPicked = "space";
            label13.Text = "Selected: Space";

        }

        private void button10_Click(object sender, EventArgs e)//underground
        {
            BackgroundPicked = "underground";
            label13.Text = "Selected: Underground";

        }

        private void button9_Click(object sender, EventArgs e)//water
        {
            BackgroundPicked = "water";
            label13.Text = "Selected: Water";

        }

        private void button12_Click(object sender, EventArgs e)//final select
        {
            this.Hide();
            BattlePage battle = new BattlePage(pickedpokemon, BackgroundPicked);
            battle.Show();
        }
    }
}
