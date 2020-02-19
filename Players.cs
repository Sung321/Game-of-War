using CardDeck;
using System;
using System.Collections.Generic;

namespace Players
{
    class Player
    {
        public List<Card> Cards { get; set; }

        public string Name { get; set; }
        public bool Active { get; set; }

        public Player()
        {
            Cards = new List<Card>();


            Name = "";
            Active = true;
        }

        public Player(string name) : this()
        {
            Name = name;
        }







        public string GetHandDescription()
        {
            string output = "";
            foreach (Card c in Cards)
            {
                output += c + ", ";
            }
            return output;
        }

        }
    }
