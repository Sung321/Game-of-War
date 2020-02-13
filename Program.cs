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

            System.Console.WriteLine($"The number of cards in deck is {d.NumCards}"); //remove the top card from the deck and priint it out
            //d.SortDeck();
            int NUMROUNDS = 0;

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

                Console.WriteLine($"Player 1 Number of cards: {Hand1.Count}");
                Console.WriteLine($"Player 2 Number of cards: {Hand2.Count}");
                Console.WriteLine($"Number of rounds played : {NUMROUNDS}");
            }
            Console.WriteLine($"Player 1 Number of cards: {Hand1.Count}");
            Console.WriteLine($"Player 2 Number of cards: {Hand2.Count}");
            Console.WriteLine($"Number of rounds played : {NUMROUNDS}");


            //test
            /* Card c1 = new Card(CardSuit.Clubs, CardValue.Five);
             Card c2 = new Card(CardSuit.Clubs, CardValue.Ten);
             Card c3 = new Card(CardSuit.Hearts, CardValue.Five);

             Console.WriteLine($"Is {c1} > {c2}: {c1 > c2}");
             Console.WriteLine($"Is {c1} < {c2}: {c1 < c2}");
             Console.WriteLine($"Is {c1} >= {c2}: {c1 >= c2}");
             Console.WriteLine($"Is {c1} <= {c2}: {c1 <= c2}");
             Console.WriteLine($"Is {c1} == {c2}: {c1 == c2}");
             Console.WriteLine($"Is {c1} != {c2}: {c1 != c2}");

             Console.WriteLine($"Is {c1} > {c3}: {c1 > c3}");
             Console.WriteLine($"Is {c1} < {c3}: {c1 < c3}");
             Console.WriteLine($"Is {c1} >= {c3}: {c1 >= c3}");
             Console.WriteLine($"Is {c1} <= {c3}: {c1 <= c3}");
             Console.WriteLine($"Is {c1} == {c3}: {c1 == c3}");
             Console.WriteLine($"Is {c1} != {c3}: {c1 != c3}"); 
             */








            /*string[] cards = {
            "H1", "H2","H3","H4","H5","H6","H7","H8","H9","HT","HJ","HQ","HK", 
            "D1", "D2","D3","D4","D5","D6","D7","D8","D9","DT","DJ","DQ","DK", 
            "C1", "C2","C3","C4","C5","C6","C7","C8","C9","CT","CJ","CQ","CK", 
            "S1", "S2","S3","S4","S5","S6","S7","S8","S9","ST","SJ","SQ","SK"
        };*

        var r = new Random();
        var shuffle = cards.OrderBy(card => r.Next());

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine("Player {0} has been dealt:",i+1);
            Console.WriteLine(string.Join(", ", shuffle.Skip(13 * i).Take(13)));

            Console.WriteLine();
        }
        Console.ReadLine();*/






        }
    }
}
