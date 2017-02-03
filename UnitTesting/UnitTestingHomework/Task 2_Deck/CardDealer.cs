using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Deck
{
    public static class CardDealer
    {
        private static IList<Card> AllCards;

        static CardDealer()
        {
            Deck d = new Deck();
            AllCards = d.GetAllCards;
        }


        
        public static IList<Card> Shuffle(this IList<Card> list)
        {
            var newCardOrder = new List<Card>();


            int cardscount = AllCards.Count;
            Random r = new Random();
            int randomIndex = 0;

            while (AllCards.Count > 0)
            {
                randomIndex = r.Next(0, AllCards.Count - 1);
                newCardOrder.Add(AllCards[randomIndex]);
                AllCards.RemoveAt(randomIndex);
            }

            return newCardOrder;
        }

        public static IList<Card> ToList(this IList<Card> list)
        {
            var newCardOrder = new List<Card>();
            foreach (var card in newCardOrder)
            {
                AllCards.Add(card);
            }


            return AllCards;
        }



    }
}
