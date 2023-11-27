using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleImproved
{
    internal class PokemonInfo
    {
        private string name;
        private int hp;
        private int maxHP;
        private int atk;
        private int def;
        private int speed;
        private string move1Name;
        private string move2Name;
        private string move3Name;
        private string move4Name;
        private string frontImage;
        private string backImage;
        private string frontShiny;
        private string backShiny;

        public PokemonInfo() { }
        public PokemonInfo(string pokemonPicked)
        {
            if (pokemonPicked == "charmander") 
            {
                name = "Charmander";
                hp = 39;
                maxHP = 39;
                atk = 52;
                def = 43;
                speed = 65;
                move1Name = "Scratch";
                move2Name = "Ember";
                move3Name = "Dragon breath";
                move4Name = "Smoke screen";
                frontImage = "Properties.Resources.charmanderfront";
                backImage = "Properties.Resources.charmanderback";
                frontShiny = "Properties.Resources.charmanderfrontshiny";
                backShiny = "Properties.Resources.charmanderbackshiny";
            }
            else if (pokemonPicked == "elgyem") 
            {
                name = "elgyem";
                hp = 55;
                maxHP= 55;
                atk = 55;
                def = 55;
                speed = 30;
                move1Name = "Confusion";
                move2Name = "Psybeam";
                move3Name = "Headbutt";
                move4Name = "Recover";
                frontImage = "Properties.Resources.elgyemfront";
                backImage = "Properties.Resources.elgyemback";
                frontShiny = "Properties.Resources.elgyemfrontshiny";
                backShiny = "Properties.Resources.elgyembackshiny";
            }
            else if (pokemonPicked == "eevee") 
            {
                name = "eevee";
                hp = 55;
                maxHP = 55;
                atk = 55;
                def = 50;
                speed = 55;
                move1Name = "Growl";
                move2Name = "Take down";
                move3Name = "Quick attack";
                move4Name = "Swift";
                frontImage = "Properties.Resources.eeveefront";
                backImage = "Properties.Resources.eeveeback";
                frontShiny = "Properties.Resources.eeveefrontshiny";
                backShiny = "Properties.Resources.eeveebackshiny";
            }
            else if (pokemonPicked == "froakie") 
            {
                name = "froakie";
                hp = 41;
                maxHP = 41;
                atk = 56;
                def = 40;
                speed = 71;
                move1Name = "Pound";
                move2Name = "Bubble";
                move3Name = "Quick attack";
                move4Name = "Lick";
                frontImage = "Properties.Resources.froakiefront";
                backImage = "Properties.Resources.froakieback";
                frontShiny = "Properties.Resources.froakiefrontshiny";
                backShiny = "Properties.Resources.froakiebackshiny";
            }
            else if (pokemonPicked == "pikachu") 
            {
                name = "pikachu";
                hp = 35;
                maxHP = 35;
                atk = 55;
                def = 40;
                speed = 43;
                move1Name = "Thunder shock";
                move2Name = "Quick attack";
                move3Name = "Electro ball";
                move4Name = "Slam";
                frontImage = "Properties.Resources.pikachufront";
                backImage = "Properties.Resources.pikachuback";
                frontShiny = "Properties.Resources.pikachufrontshiny";
                backShiny = "Properties.Resources.pikachubackshiny";
            }
            else if (pokemonPicked == "rowlet") 
            {
                name = "rowlet";
                hp = 68;
                maxHP = 68;
                def = 55;
                speed = 42;
                move1Name = "Leafage";
                move2Name = "Peck";
                move3Name = "Astonish";
                move4Name = "Synthesis";
                frontImage = "Properties.Resources.rowletfront";
                backImage = "Properties.Resources.rowletback";
                frontShiny = "Properties.Resources.rowletfrontshiny";
                backShiny = "Properties.Resources.rowletbackshiny";

            }
            else if (pokemonPicked == "sandshrew") 
            {
                name = "sandrew";
                hp = 50;
                maxHP= 50;
                atk= 75;
                def = 75;
                speed = 40;
                move1Name = "Scratch";
                move2Name = "Defence curl";
                move3Name = "Rapid spin";
                move4Name = "Fury cutter";
                frontImage = "Properties.Resources.sandshrewfront";
                backImage = "Properties.Resources.sandshrewback";
                frontShiny = "Properties.Resources.sandshrewfrontshiny";
                backShiny = "Properties.Resources.sandshrewbackshiny";

            }
            else if (pokemonPicked == "shinx") 
            {
                name = "shinx";
                hp = 45;
                maxHP = 45;
                atk = 65;
                def = 34;
                speed = 45;
                move1Name = "Tackle";
                move2Name = "thunder shock";
                move3Name = "Bite";
                move4Name = "Spark";
                frontImage = "Properties.Resources.shinxfront";
                backImage = "Properties.Resources.shinxback";
                frontShiny = "Properties.Resources.shinxfrontshiny";
                backShiny = "Properties.Resources.shinxbackshiny";
            }
            else if (pokemonPicked == "spinarak") 
            {
                name = "spinarak";
                hp = 40;
                maxHP = 40;
                atk = 60;
                def = 40;
                speed = 30;
                move1Name = "Poison sting";
                move2Name = "Absorb";
                move3Name = "Infestation";
                move4Name = "Sucker Punch";
                frontImage = "Properties.Resources.spinarakfront";
                backImage = "Properties.Resources.spinarakback";
                frontShiny = "Properties.Resources.spinarakfrontshiny";
                backShiny = "Properties.Resources.spinarakbackshiny";
            }
            else if (pokemonPicked == "squirtle") 
            {
                name = "squirtle";
                hp = 44;
                maxHP = 44;
                atk = 48;
                def = 65;
                speed = 43;
                move1Name = "Water gun";
                move2Name = "Withdraw";
                move3Name = "Rapid spin";
                move4Name = "Bite";
                frontImage = "Properties.Resources.squirtlefront";
                backImage = "Properties.Resources.squirtleback";
                frontShiny = "Properties.Resources.squirtlefrontshiny";
                backShiny = "Properties.Resources.squirtlebackshiny";
            }
            else if (pokemonPicked == "zubat") 
            {
                name = "zubat";
                hp = 40;
                maxHP = 40;
                atk = 45;
                def = 35;
                speed = 55;
                move1Name = "Leech life";
                move2Name = "Astonish";
                move3Name = "Bite";
                move4Name = "Wing attack";
                frontImage = "Properties.Resources.zubatfront";
                backImage = "Properties.Resources.zubatback";
                frontShiny = "Properties.Resources.zubatfrontshiny";
                backShiny = "Properties.Resources.zubatbackshiny";
            }

            

        }
        public string getFrontImage()
        {
            return frontImage;
        }

        public string getBackImage()
        {
            return backImage;
        }

        public string getFrontShiny()
        {
            return frontShiny;
        }

        public string getBackShiny()
        {
            return backShiny;
        }

    }
}
