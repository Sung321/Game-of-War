using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Deck
    {
           
        List<Card> Cards { get; set; }
        public int NumCards { get => Cards.Count; }// like an array, a container object,  we dont get the lngth, but the count

        public Deck()
        {
            Cards = new List<Card>();
        }


        public void AddCard(Card newCard) // remove card from the deck and put it back on the bottom
        {
            Cards.Add(newCard);
        }

        public Card RemoveTopCard()
        {
            Card cardToRemove = Cards[0]; 
            Cards.RemoveAt(0);
            return cardToRemove;
        }
        
        public void PrintDeck()
        {
            foreach(Card c in Cards)
            {
                System.Console.WriteLine(c);
            }
        }

        public void ShuffleDeck()
        {
            Random r = new Random();

     

            for (int Counter = 0; Counter < 10000; Counter++)
            {
                var RandomIndex = r.Next(0, Cards.Count);
                Card cardrandom = Cards[RandomIndex];
                Cards.RemoveAt(RandomIndex);
                Cards.Add(cardrandom);
            }


        }

      
        public void Deal(List<Card> Hand1, List<Card> Hand2)
        {

            for (int i = 0; i < 52; i++)
            {
                if (i % 2 == 0)
                {
                    Hand1.Add(RemoveTopCard());
                }
                else
                {
                    Hand2.Add(RemoveTopCard());
                }
            
            }
           
            
           /* foreach(Card h in Hand1)
            {
                Console.WriteLine($"Player 1 has: {h} ");
            }

          

            foreach(Card h in Hand2)
            {
                Console.WriteLine($"Player 2 has: {h} ");
            }

             //-------------------------------------------------------------------------------------------------------------------------------------*/
        
        
        
        }
   
       

    
    
    
    
    
    
    
    
    }
}