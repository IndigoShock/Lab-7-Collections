using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardApp.Classes
{
    class Deck<C> : IEnumerable
    {
        C[] cards = new C[26];

        public int count;
        /// <summary>
        ///must have Add or else it will not have collection initializer. Another magic. Don't change.
        /// </summary>
        /// <param name="someCard"></param>
        public void Add(C someCard)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);

            }

            cards[count++] = someCard;
        }

        //public int RemoveCard(C someCard)
        //{
        //    cards.Remove(cards);
        //    return Convert.ToInt32(someCard);
        //}


        //public static string Shuffle(C someCard)
        //{
        // Add a randomizer in here.
        //}

        public IEnumerator<C> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }
        
        //Magic. Don't Touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return cards.GetEnumerator();
        }
    }
}
