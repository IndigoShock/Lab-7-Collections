using System;
using System.Collections.Generic;
using System.Text;

namespace CardApp
{
    public class Card
    {
        public CardValue ThisCardValue { get; set; }

        public Suit ThisSuit { get; set; }
    }

    public enum CardValue : int
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten = 10,
        Jack,
        Queen,
        King
    }

    public enum Suit : int
    {
        Diamonds = 1,
        Clubs,
        Hearts,
        Spades = 4
    }
}
