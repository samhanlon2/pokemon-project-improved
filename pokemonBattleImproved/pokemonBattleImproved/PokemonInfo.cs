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
            }

            

        }
        public string getFrontImage(string get)
        {
            return get;
        }

    }
}
