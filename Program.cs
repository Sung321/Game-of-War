
using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Program
    {


        static void Main(string[] args)
        {
            Deck d = new Deck();
            List<Card> Hand1 = new List<Card>();
            List<Card> Hand2 = new List<Card>();
            List<Card> Pile = new List<Card>();



            foreach (CardSuit cs in Enum.GetValues(typeof(CardSuit))) // add a card to the deck that is a new card with the same suit and value 
            {
                foreach (CardValue cv in Enum.GetValues(typeof(CardValue)))   //4 suits 13 card values and 52 cards overall
                {
                    d.AddCard(new Card(cs, cv));
                }
            }

            //d.PrintDeck();    
            //This will display the entire deck
            d.ShuffleDeck();
            d.Deal(Hand1, Hand2);


            //d.SortDeck();
            int NUMROUNDS = 0;
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------Game of WAR-------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            string Player1;
            string Player2;
            Console.WriteLine("Please Enter Name of Player1");
            Player1 = Console.ReadLine();
            Console.WriteLine("Please Enter Name of Player2");
            Player2 = Console.ReadLine();
            


            while (Hand1.Count > 0 && Hand2.Count > 0)
            {
                Card Hand1Card = Hand1[0];
                Card Hand2Card = Hand2[0];
                Hand2.RemoveAt(0);
                Hand1.RemoveAt(0);
                Pile.Add(Hand1Card);
                Pile.Add(Hand2Card);


                while (Hand2Card == Hand1Card)
                {
                    Hand1Card = Hand1[0];
                    Hand1.RemoveAt(0);
                    Pile.Add(Hand1Card);
                    Hand2Card = Hand2[0];
                    Hand2.RemoveAt(0);
                    Pile.Add(Hand2Card);
                    Hand1Card = Hand1[0];
                    Hand1.RemoveAt(0);
                    Pile.Add(Hand1Card);
                    Hand2Card = Hand2[0];
                    Hand2.RemoveAt(0);
                    Pile.Add(Hand2Card);
                }
                if (Hand1Card > Hand2Card)
                {
                    Hand1.AddRange(Pile);
                    Pile.Clear();
                }
                if (Hand2Card > Hand1Card)
                {
                    Hand2.AddRange(Pile);
                    Pile.Clear();
                }

                NUMROUNDS++;

                


                {

                    Console.WriteLine("Press ENTER to PLAY!");
                    Console.WriteLine("Hold ENTER to Automate");
                    Console.ReadLine();
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine($"{Player1} has: {Hand1Card}");
                    Console.WriteLine($"{Player1} has: {Hand2Card}");
                    Console.WriteLine($"{Player1} Number of cards: {Hand1.Count}");
                    Console.WriteLine($"{Player2} Number of cards: {Hand2.Count}");
                    Console.WriteLine($"Number of rounds played : {NUMROUNDS}");
                    Console.WriteLine("---------------------------------");
                }









            }
        }
    }

}