using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2_Deck.Enums;

namespace Task_2_Deck
{
    public interface ICard
    {

         Card GetCard(CardSuit cardSuit, CardType cardType);
       
    }
}
