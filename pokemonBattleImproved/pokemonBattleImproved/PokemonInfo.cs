using MoveClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonBattleImproved
{
    public class PokemonInfo
    {
        private string name;
        private int hp;
        private int maxHP;
        private int atk;
        private int def;
        private int speed;
        private Move move1 = new Move();
        private Move move2 = new Move();
        private Move move3 = new Move();
        private Move move4 = new Move();
        private Image frontImage;
        private Image backImage;
        private Image frontShiny;
        private Image backShiny;

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
                move1.setMove("Scratch", this);
                move2.setMove("Ember", this);
                move3.setMove("Dragon breath", this);
                move4.setMove("Fire fang", this);
                frontImage = Properties.Resources.charmanderfront;
                backImage = Properties.Resources.charmanderback;
                frontShiny = Properties.Resources.charmanderfrontshiny;
                backShiny = Properties.Resources.charmanderbackshiny;
            }
            else if (pokemonPicked == "elgyem") 
            {
                name = "Elgyem";
                hp = 55;
                maxHP= 55;
                atk = 55;
                def = 55;
                speed = 30;
                move1.setMove("Confusion", this);
                move2.setMove("Psybeam", this);
                move3.setMove("Headbutt", this);
                move4.setMove("Recover", this);
                frontImage = Properties.Resources.elgyemfront;
                backImage = Properties.Resources.elgyemback;
                frontShiny = Properties.Resources.elgyemfrontshiny;
                backShiny = Properties.Resources.elgyembackshiny;
            }
            else if (pokemonPicked == "eevee") 
            {
                name = "Eevee";
                hp = 55;
                maxHP = 55;
                atk = 55;
                def = 50;
                speed = 55;
                move1.setMove("Covet", this);
                move2.setMove("Take down", this);
                move3.setMove("Quick attack", this);
                move4.setMove("Swift", this);
                frontImage = Properties.Resources.eeveefront;
                backImage = Properties.Resources.eeveeback;
                frontShiny = Properties.Resources.eeveefrontshiny;
                backShiny = Properties.Resources.eeveebackshiny;
            }
            else if (pokemonPicked == "froakie") 
            {
                name = "Froakie";
                hp = 41;
                maxHP = 41;
                atk = 56;
                def = 40;
                speed = 71;
                move1.setMove("Pound", this);
                move2.setMove("Bubble", this);
                move3.setMove("Quick attack", this);
                move4.setMove("Lick", this);
                frontImage = Properties.Resources.froakiefront;
                backImage = Properties.Resources.froakieback;
                frontShiny = Properties.Resources.froakiefrontshiny;
                backShiny = Properties.Resources.froakiebackshiny;
            }
            else if (pokemonPicked == "pikachu") 
            {
                name = "Pikachu";
                hp = 35;
                maxHP = 35;
                atk = 55;
                def = 40;
                speed = 43;
                move1.setMove("Thunder shock", this);
                move2.setMove("Quick attack", this);
                move3.setMove("Electro ball", this);
                move4.setMove("Slam", this);
                frontImage = Properties.Resources.pikachufront;
                backImage = Properties.Resources.pikachuback;
                frontShiny = Properties.Resources.pikachufronthat;
                backShiny = Properties.Resources.pikachubackhat;
            }
            else if (pokemonPicked == "rowlet") 
            {
                name = "Rowlet";
                hp = 68;
                maxHP = 68;
                def = 55;
                speed = 42;
                move1.setMove("Leafage", this);
                move2.setMove("Peck", this);
                move3.setMove("Astonish", this);
                move4.setMove("Synthesis", this);
                frontImage = Properties.Resources.rowletfront;
                backImage = Properties.Resources.rowletback;
                frontShiny = Properties.Resources.rowletfrontshiny;
                backShiny = Properties.Resources.rowletbackshiny;

            }
            else if (pokemonPicked == "sandshrew") 
            {
                name = "Sandshrew";
                hp = 50;
                maxHP= 50;
                atk= 75;
                def = 75;
                speed = 40;
                move1.setMove("scratch", this);
                move2.setMove("Defence curl", this);
                move3.setMove("Rapid spin", this);
                move4.setMove("Fury cutter", this);
                frontImage = Properties.Resources.sandshrewfront;
                backImage = Properties.Resources.sandshrewback;
                frontShiny = Properties.Resources.sandshrewfrontalolan;
                backShiny = Properties.Resources.sandshrewbackalolan;

            }
            else if (pokemonPicked == "shinx") 
            {
                name = "Shinx";
                hp = 45;
                maxHP = 45;
                atk = 65;
                def = 34;
                speed = 45;
                move1.setMove("Tackle", this);
                move2.setMove("thunder shock", this);
                move3.setMove("Bite", this);
                move4.setMove("Spark", this);
                frontImage = Properties.Resources.shinxfront;
                backImage = Properties.Resources.shinxback;
                frontShiny = Properties.Resources.shinxfrontshiny;
                backShiny = Properties.Resources.shinxbackshiny;
            }
            else if (pokemonPicked == "spinarak") 
            {
                name = "Spinarak";
                hp = 40;
                maxHP = 40;
                atk = 60;
                def = 40;
                speed = 30;
                move1.setMove("Poison sting", this);
                move2.setMove("Absorb", this);
                move3.setMove("Infestation", this);
                move4.setMove("Sucker Punch", this);
                frontImage = Properties.Resources.spinarakfront;
                backImage = Properties.Resources.spinarakback;
                frontShiny = Properties.Resources.spinarakfrontshiny;
                backShiny = Properties.Resources.spinarakbackshiny;
            }
            else if (pokemonPicked == "squirtle") 
            {
                name = "Squirtle";
                hp = 44;
                maxHP = 44;
                atk = 48;
                def = 65;
                speed = 43;
                move1.setMove("Water gun", this);
                move2.setMove("Withdraw", this);
                move3.setMove("Rapid spin", this);
                move4.setMove("Bite", this);
                frontImage = Properties.Resources.squirtlefront;
                backImage = Properties.Resources.squirtleback;
                frontShiny = Properties.Resources.squirtlefrontshiny;
                backShiny = Properties.Resources.squirtlebackshiny;
            }
            else if (pokemonPicked == "zubat") 
            {
                name = "Zubat";
                hp = 40;
                maxHP = 40;
                atk = 45;
                def = 35;
                speed = 55;
                move1.setMove("Leech life", this);
                move2.setMove("Astonish", this);
                move3.setMove("Bite", this);
                move4.setMove("Wing attack", this);
                frontImage = Properties.Resources.zubatfront;
                backImage = Properties.Resources.zubatback;
                frontShiny = Properties.Resources.zubatfrontshiny;
                backShiny = Properties.Resources.zubatbackshiny;
            }

            

        }
        public Image getFrontImage()
        {
            return frontImage;
        }

        public Image getBackImage()
        {
            return backImage;
        }

        public Image getFrontShiny()
        {
            return frontShiny;
        }

        public Image getBackShiny()
        {
            return backShiny;
        }

        public int getMaxHP()
        {
            return maxHP;
        }

        public int getHP()
        {
            return hp;
        }

        public void setHP(int HP)
        {
            hp = HP;
        }

        public string getName()
        {
            return name;
        }

        public void setDef(int Def)
        {
            def = Def;
        }

        public int getDef()
        {
            return def;
        }

        public int getSpeed()
        {
            return speed;
        }

        public int getAtk()
        {
            return atk;
        }

        public string getMove1Name()
        {
            return move1.getName();
        }

        public string getMove2Name()
        {
            return move2.getName();
        }

        public string getMove3Name()
        {
            return move3.getName();
        }

        public string getMove4Name()
        {
            return move4.getName();
        }

        public Move getMove1()
        {
            return move1;
        }

        public Move getMove2()
        {
            return move2;
        }

        public Move getMove3()
        {
            return move3;
        }

        public Move getMove4()
        {
            return move4;
        }

        public void setPokemon(string pokemonPicked)
        {
            if (pokemonPicked == "charmander")
            {
                name = "Charmander";
                hp = 39;
                maxHP = 39;
                atk = 52;
                def = 43;
                speed = 65;
                move1.setMove("Scratch", this);
                move2.setMove("Ember", this);
                move3.setMove("Dragon breath", this);
                move4.setMove("Fire fang", this);
                frontImage = Properties.Resources.charmanderfront;
                backImage = Properties.Resources.charmanderback;
                frontShiny = Properties.Resources.charmanderfrontshiny;
                backShiny = Properties.Resources.charmanderbackshiny;
            }
            else if (pokemonPicked == "elgyem")
            {
                name = "Elgyem";
                hp = 55;
                maxHP = 55;
                atk = 55;
                def = 55;
                speed = 30;
                move1.setMove("Confusion", this);
                move2.setMove("Psybeam", this);
                move3.setMove("Headbutt", this);
                move4.setMove("Recover", this);
                frontImage = Properties.Resources.elgyemfront;
                backImage = Properties.Resources.elgyemback;
                frontShiny = Properties.Resources.elgyemfrontshiny;
                backShiny = Properties.Resources.elgyembackshiny;
            }
            else if (pokemonPicked == "eevee")
            {
                name = "Eevee";
                hp = 55;
                maxHP = 55;
                atk = 55;
                def = 50;
                speed = 55;
                move1.setMove("Covet", this);
                move2.setMove("Take down", this);
                move3.setMove("Quick attack", this);
                move4.setMove("Swift", this);
                frontImage = Properties.Resources.eeveefront;
                backImage = Properties.Resources.eeveeback;
                frontShiny = Properties.Resources.eeveefrontshiny;
                backShiny = Properties.Resources.eeveebackshiny;
            }
            else if (pokemonPicked == "froakie")
            {
                name = "Froakie";
                hp = 41;
                maxHP = 41;
                atk = 56;
                def = 40;
                speed = 71;
                move1.setMove("Pound", this);
                move2.setMove("Bubble", this);
                move3.setMove("Quick attack", this);
                move4.setMove("Lick", this);
                frontImage = Properties.Resources.froakiefront;
                backImage = Properties.Resources.froakieback;
                frontShiny = Properties.Resources.froakiefrontshiny;
                backShiny = Properties.Resources.froakiebackshiny;
            }
            else if (pokemonPicked == "pikachu")
            {
                name = "Pikachu";
                hp = 35;
                maxHP = 35;
                atk = 55;
                def = 40;
                speed = 43;
                move1.setMove("Thunder shock", this);
                move2.setMove("Quick attack", this);
                move3.setMove("Electro ball", this);
                move4.setMove("Slam", this);
                frontImage = Properties.Resources.pikachufront;
                backImage = Properties.Resources.pikachuback;
                frontShiny = Properties.Resources.pikachufronthat;
                backShiny = Properties.Resources.pikachubackhat;
            }
            else if (pokemonPicked == "rowlet")
            {
                name = "Rowlet";
                hp = 68;
                maxHP = 68;
                atk = 55;
                def = 55;
                speed = 42;
                move1.setMove("Leafage", this);
                move2.setMove("Peck", this);
                move3.setMove("Astonish", this);
                move4.setMove("Synthesis", this);
                frontImage = Properties.Resources.rowletfront;
                backImage = Properties.Resources.rowletback;
                frontShiny = Properties.Resources.rowletfrontshiny;
                backShiny = Properties.Resources.rowletbackshiny;

            }
            else if (pokemonPicked == "sandshrew")
            {
                name = "Sandshrew";
                hp = 50;
                maxHP = 50;
                atk = 75;
                def = 75;
                speed = 40;
                move1.setMove("Scratch", this);
                move2.setMove("Defence curl", this);
                move3.setMove("Rapid spin", this);
                move4.setMove("Fury cutter", this);
                frontImage = Properties.Resources.sandshrewfront;
                backImage = Properties.Resources.sandshrewback;
                frontShiny = Properties.Resources.sandshrewfrontalolan;
                backShiny = Properties.Resources.sandshrewbackalolan;

            }
            else if (pokemonPicked == "shinx")
            {
                name = "Shinx";
                hp = 45;
                maxHP = 45;
                atk = 65;
                def = 34;
                speed = 45;
                move1.setMove("Tackle", this);
                move2.setMove("Thunder shock", this);
                move3.setMove("Bite", this);
                move4.setMove("Spark", this);
                frontImage = Properties.Resources.shinxfront;
                backImage = Properties.Resources.shinxback;
                frontShiny = Properties.Resources.shinxfrontshiny;
                backShiny = Properties.Resources.shinxbackshiny;
            }
            else if (pokemonPicked == "spinarak")
            {
                name = "Spinarak";
                hp = 40;
                maxHP = 40;
                atk = 60;
                def = 40;
                speed = 30;
                move1.setMove("Poison sting", this);
                move2.setMove("Absorb", this);
                move3.setMove("Infestation", this);
                move4.setMove("Sucker Punch", this);
                frontImage = Properties.Resources.spinarakfront;
                backImage = Properties.Resources.spinarakback;
                frontShiny = Properties.Resources.spinarakfrontshiny;
                backShiny = Properties.Resources.spinarakbackshiny;
            }
            else if (pokemonPicked == "squirtle")
            {
                name = "Squirtle";
                hp = 44;
                maxHP = 44;
                atk = 48;
                def = 65;
                speed = 43;
                move1.setMove("Water gun", this);
                move2.setMove("Withdraw", this);
                move3.setMove("Rapid spin", this);
                move4.setMove("Bite", this);
                frontImage = Properties.Resources.squirtlefront;
                backImage = Properties.Resources.squirtleback;
                frontShiny = Properties.Resources.squirtlefrontshiny;
                backShiny = Properties.Resources.squirtlebackshiny;
            }
            else if (pokemonPicked == "zubat")
            {
                name = "Zubat";
                hp = 40;
                maxHP = 40;
                atk = 45;
                def = 35;
                speed = 55;
                move1.setMove("Leech life", this);
                move2.setMove("Astonish", this);
                move3.setMove("Bite", this);
                move4.setMove("Wing attack", this);
                frontImage = Properties.Resources.zubatfront;
                backImage = Properties.Resources.zubatback;
                frontShiny = Properties.Resources.zubatfrontshiny;
                backShiny = Properties.Resources.zubatbackshiny;
            }
        }
    }
}
