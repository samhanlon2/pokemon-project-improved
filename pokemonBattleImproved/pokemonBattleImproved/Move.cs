using pokemonBattleImproved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoveClass
{
    public class Move
    {

        private string name="";
        private int type;
        private int power;
        private int healAmt;
        private int defIncrease;

        public Move()
        {

        }
        public Move(string Name)
        {
            name = Name;
        }

        public void setMove(string Name, PokemonInfo user)
        {
            name = Name;
            if (name == "Leafage")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Peck")
            {
                type = 1;
                power = 35;
            }
            else if (name == "Astonish")
            {
                type = 1;
                power = 30;
            }
            else if (name == "Synthesis")
            {
                type = 2;
                healAmt = (user.getMaxHP()/2);
            }
            else if (name == "Confusion")
            {
                type = 1;
                power = 50;
            }
            else if (name == "Psybeam")
            {
                type = 1;
                power = 65;
            }
            else if (name == "Headbutt")
            {
                type = 1;
                power = 70;
            }
            else if (name == "Recover")
            {
                type = 2;
                healAmt = (user.getMaxHP() / 2);
            }
            else if (name == "Scratch")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Rapid Spin")
            {
                type = 1;
                power = 20;
            }
            else if (name == "Fury Cutter")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Defense Curl")
            {
                type = 3;
                defIncrease = 10;
            }
            else if (name == "Pound")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Bubble")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Quick Attack")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Lick")
            {
                type = 1;
                power = 30;
            }
           // else if (name == "Scratch")
            //{
              //  type = 1;
               // power = 40;
            //}
            else if (name == "Ember")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Dragon Breath")
            {
                type = 1;
                power = 60;
            }
            else if (name == "Fire Fang")
            {
                type = 1;
                power = 65;
            }
            else if (name == "Tackle")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Thunder Shock")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Bite")
            {
                type = 1;
                power = 60;
            }
            else if (name == "Spark")
            {
                type = 1;
                power = 65;
            }
            else if (name == "Leech Life")
            {
                type = 1;
                power = 50;
            }
            else if (name == "Astonish")
            {
                type = 1;
                power = 65;
            }
            else if (name == "Wing Attack")
            {
                type = 1;
                power = 60;
            }
            else if (name == "Covet")
            {
                type = 1;
                power = 60;
            }
            else if (name == "Take Down")
            {
                type = 1;
                power = 90;
            }
            else if (name == "Swift")
            {
                type = 1;
                power = 60;
            }
            else if (name == "Poison Sting")
            {
                type = 1;
                power = 30; //was 15
            }
            else if (name == "Absorb")
            {
                type = 1;
                power = 20;
            }
            else if (name == "Infestation")
            {
                type = 1;
                power = 20;
            }
            else if (name == "Sucker Punch")
            {
                type = 1;
                power = 70;
            }
            else if (name == "Water Gun")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Rapid Spin")
            {
                type = 1;
                power = 50;
            }
            else if (name == "Withdraw")
            {
                type = 3;
                defIncrease = 10;
            }
            else if (name == "Thunder Shock")
            {
                type = 1;
                power = 40;
            }
            else if (name == "Electro Ball")
            {
                type = 1;
                power = 45;
            }
            else if (name == "Slam")
            {
                type = 1;
                power = 80;
            }
            else if (name == "☢")
            { type = 1;
              power = 999;
            }

        }

        public int getPower() { return power; }
        
        public int getType() { return type; }

        public int getHealAmt() { return healAmt; }

        public int getDefIncrease() { return defIncrease; }

        public string getName() { return name; }


    }
}
