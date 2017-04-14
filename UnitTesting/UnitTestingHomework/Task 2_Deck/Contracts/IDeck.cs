namespace Task_2_Deck.Contracts
{

    using System.Collections.Generic;

    public interface IDeck
    {
        Card TrumpCard { get; }

        int CardsLeft { get; }

        IList<Card> GetAllCards { get; }

        Card GetNextCard();

        void ChangeTrumpCard(Card newCard);
    }
}
