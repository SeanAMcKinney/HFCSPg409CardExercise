using System;
using System.Collections.Generic;
using System.Text;

namespace HFCSPg409CardExercise
{
    public class Card
    {
        //Properties
        public Suits Suit { get; private set; }
        public Values Value { get; private set; }
        public string Name { get { return $"{Value} of {Suit}"; } }

        //Constructor
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
