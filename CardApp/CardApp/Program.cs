using System;
using System.Collections.Generic;
using CardApp;
using CardApp.Classes;

namespace Class08Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Deal();

        }

        public static void Deal()
        {
            //instantiating cards
            Card card1 = new Card
            {
                ThisCardValue = (CardValue)1,
                ThisSuit = (Suit)1,
            };

            Card card2 = new Card
            {
                ThisCardValue = (CardValue)2,
                ThisSuit = (Suit)1,
            };

            Card card3 = new Card
            {
                ThisCardValue = (CardValue)3,
                ThisSuit = (Suit)1,
            };

            Card card4 = new Card
            {
                ThisCardValue = (CardValue)4,
                ThisSuit = (Suit)1,
            };

            Card card5 = new Card
            {
                ThisCardValue = (CardValue)5,
                ThisSuit = (Suit)1,
            };

            Card card6 = new Card
            {
                ThisCardValue = (CardValue)6,
                ThisSuit = (Suit)1,
            };

            Card card7 = new Card
            {
                ThisCardValue = (CardValue)7,
                ThisSuit = (Suit)1,
            };


            Card card8 = new Card
            {
                ThisCardValue = (CardValue)8,
                ThisSuit = (Suit)1,
            };

            Card card9 = new Card
            {
                ThisCardValue = (CardValue)9,
                ThisSuit = (Suit)1,
            };

            Card card10 = new Card
            {
                ThisCardValue = (CardValue)10,
                ThisSuit = (Suit)1,
            };

            Card card11 = new Card
            {
                ThisCardValue = (CardValue)11,
                ThisSuit = (Suit)1,
            };

            Card card12 = new Card
            {
                ThisCardValue = (CardValue)12,
                ThisSuit = (Suit)1,
            };

            Card card13 = new Card
            {
                ThisCardValue = (CardValue)13,
                ThisSuit = (Suit)1,
            };

            Card card14 = new Card
            {
                ThisCardValue = (CardValue)1,
                ThisSuit = (Suit)2,
            };

            Card card15 = new Card
            {
                ThisCardValue = (CardValue)2,
                ThisSuit = (Suit)2,
            };

            Card card16 = new Card
            {
                ThisCardValue = (CardValue)3,
                ThisSuit = (Suit)2,
            };

            Card card17 = new Card
            {
                ThisCardValue = (CardValue)4,
                ThisSuit = (Suit)2,
            };

            Card card18 = new Card
            {
                ThisCardValue = (CardValue)5,
                ThisSuit = (Suit)2,
            };

            Card card19 = new Card
            {
                ThisCardValue = (CardValue)6,
                ThisSuit = (Suit)2,
            };

            Card card20 = new Card
            {
                ThisCardValue = (CardValue)7,
                ThisSuit = (Suit)2,
            };

            Card card21 = new Card
            {
                ThisCardValue = (CardValue)8,
                ThisSuit = (Suit)2,
            };

            Card card22 = new Card
            {
                ThisCardValue = (CardValue)9,
                ThisSuit = (Suit)2,
            };

            Card card23 = new Card
            {
                ThisCardValue = (CardValue)10,
                ThisSuit = (Suit)2,
            };

            Card card24 = new Card
            {
                ThisCardValue = (CardValue)11,
                ThisSuit = (Suit)2,
            };

            Card card25 = new Card
            {
                ThisCardValue = (CardValue)12,
                ThisSuit = (Suit)2,
            };

            Card card26 = new Card
            {
                ThisCardValue = (CardValue)13,
                ThisSuit = (Suit)2,
            };

            Deck<Card> thisDeck = new Deck<Card>
            {
                card1,
                card2,
                card3,
                card4,
                card5,
                card6,
                card7,
                card8,
                card9,
                card10,
                card11,
                card12,
                card13,
                card14,
                card15,
                card16,
                card17,
                card18,
                card19,
                card20,
                card21,
                card22,
                card23,
                card24,
                card25,
                card26
            };

            foreach (Card princess in thisDeck)
            {
                Console.WriteLine(princess);
            }

        }



        //static void GenericExample()
        //{
        //    // "dynamic" array. Can add things to list. With collection, use foreach. 
        //    List<string> princesses = new List<string>
        //    {
        //        "Snow White",
        //        "Cinderella",
        //        "Rapunzel",
        //        "Elsa",
        //        "Merida",
        //        "Ariel"
        //    };

        //    foreach (string princess in princesses)
        //    {
        //        Console.WriteLine(princess);
        //    }

        //    string name = princesses[3];

        //    Console.WriteLine();
        //    Console.WriteLine(name);

        //    List<string> princes = new List<string>
        //    {
        //        "Aladdin",
        //        "Rogers Nelson",
        //        "Charming",
        //        "Eric",
        //        "Harry",
        //        "Charles"
        //    };

        //    foreach (var i in princes)
        //    {
        //        Console.WriteLine(i);
        //    }

        //    princes.Remove("Eric");

        //    Console.WriteLine();
        //    foreach (var i in princes)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        IEnumerable<string> myEnumerable = new List<string>();

    }

}
