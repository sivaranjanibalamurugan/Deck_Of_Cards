using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Cards
    {
        public string suit;
        public string rank;
        public Cards(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}
