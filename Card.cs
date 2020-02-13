using System;

namespace CardDeck
{
    public struct Card : IComparable<Card>  //this will allow us to overload the operators
    {
        CardSuit Suit { get; set; } //just a variable called "suit"
        CardValue Value { get; set; }

        public Card(CardSuit suit, CardValue value) // Constructor 
        {
            this.Suit = suit; // Parameter "suit"
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}"; // this will print the value of the card
        }

        public int CompareTo(Card otherCard) //this will compare the card. If they are the same return 0, if 1 is greater return 1
        {
            if(this.Value == otherCard.Value) // doesnt compare the suits only the card value
                return 0;
            return (this.Value > otherCard.Value) ? 1 : -1;
        }

        public override bool Equals(object otherCard) // .Parse but with functions
        {
            if(otherCard == null)
                return false;
            return ((Card)otherCard).Value == this.Value;
        }

        public override int GetHashCode()// this is to get rid of the warning message, so we over road it 
        {
            return base.GetHashCode();
        }                                                                                       // change it once in a "compareto" method and it will propigate to the rest

        public static bool operator >  (Card operand1, Card operand2) //this will allow us to take a card card variavble and see if a card is greater/less than or equal to another card
        {
            return operand1.CompareTo(operand2) == 1;
        }
        
        public static bool operator <  (Card operand1, Card operand2)// cha
        {
            return operand1.CompareTo(operand2) == -1;
        }

        public static bool operator >=  (Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }
        
        public static bool operator <=  (Card operand1, Card operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
        
        public static bool operator ==  (Card operand1, Card operand2)
        {
            return operand1.Equals(operand2);
        }

        public static bool operator !=  (Card operand1, Card operand2)
        {
            return !operand1.Equals(operand2);
        }
    }
}