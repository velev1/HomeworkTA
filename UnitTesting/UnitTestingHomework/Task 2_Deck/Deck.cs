namespace Task_2_Deck
{
    using System.Collections.Generic;
    using System.Linq;

    using Task_2_Deck.Contracts;
    using Enums;
    using System;

    public class Deck : IDeck
    {
        private static readonly IList<Card> AllCards = new List<Card>();
        private static readonly IEnumerable<CardType> AllCardTypes = new List<CardType>
                                                                         {
                                                                             CardType.Nine,
                                                                             CardType.Ten,
                                                                             CardType.Jack,
                                                                             CardType.Queen,
                                                                             CardType.King,
                                                                             CardType.Ace,
                                                                         };

        private static readonly IEnumerable<CardSuit> AllCardSuits = new List<CardSuit>
                                                                         {
                                                                             CardSuit.Club,
                                                                             CardSuit.Diamond,
                                                                             CardSuit.Heart,
                                                                             CardSuit.Spade,
                                                                         };

        private readonly IList<Card> listOfCards;

        static Deck()
        {
            foreach (var cardSuit in AllCardSuits)
            {
                foreach (var cardType in AllCardTypes)
                {
                    AllCards.Add(Card.GetCard(cardSuit, cardType));
                }
            }
        }

        //implement Shuffle() and ToList extension method in the class CardDealer
        public Deck()
        {
            this.listOfCards = AllCards.Shuffle().ToList();
            this.TrumpCard = this.listOfCards[0];
        }

        //Added geter to expose list in the cardDealer
        public IList<Card> GetAllCards
        {
            get
            {
                //maybe it better idea to return new list but I'm not sure
                //return new List<Card>(Deck.AllCards);
                return Deck.AllCards;
            }
        }

        public Card TrumpCard { get; private set; }

        public int CardsLeft => this.listOfCards.Count;

        //change the exeption if not have to implement the custom exeption which is thrown
        public Card GetNextCard()
        {
            if (this.listOfCards.Count == 0)
            {
                //throw new InternalGameException("Deck is empty!");
                throw new ArgumentNullException();
            }

            var card = this.listOfCards[this.listOfCards.Count - 1];
            this.listOfCards.RemoveAt(this.listOfCards.Count - 1);
            return card;
        }

        public void ChangeTrumpCard(Card newCard)
        {
            this.TrumpCard = newCard;
            if (this.listOfCards.Count > 0)
            {
                this.listOfCards[0] = newCard;
            }
        }
    }
}
