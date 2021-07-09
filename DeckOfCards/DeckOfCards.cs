using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class DeckOfCards
    {
            Cards[] cards;
            string[] suit = { "Club", "Diamond", "Heart", "Spade" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King", "Ace" };

            //initializing the cards
            public DeckOfCards()
            {
                cards = InitializeCards();
            }
        //initialization of method cards
        public Cards[] InitializeCards()
        {
            Cards[] cards = new Cards[52];
            int CardsIndex= 0;
            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    cards[CardsIndex] = new Cards(suit[i], ranks[j]);
                    CardsIndex++;
                }
            }
            return cards;
        }
        //method for shuffling  
        public void shuffle(Cards[] cards)
        {
            Random random = new Random();
            Cards Cards;
            for (int i = 0; i < 52; i++)
            {
                //creating two random indexes to swap
                int index = random.Next(52);
                int temp = random.Next(52);
                Cards = cards[index];
                cards[index] = cards[temp];
                cards[temp] = Cards;

            }
        }
        //method for allocating the cards for the players 
        public Cards[,] alotCards(Cards[,] players)
        {
            int playersIndex = 0;
            shuffle(this.cards);
            for (int i = 0; i < players.GetLength(0); i++)
            {
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    //distribute the cards to each player in shuffled order
                    players[i, j] = cards[playersIndex];
                    playersIndex++;
                }
            }
            return players;
        }

        //display the cards 
        public void display(Cards[,] players)
        {
            for (int i = 0; i < players.GetLength(0); i++)
            {
                Console.WriteLine("Player" + (i + 1) + " Cards: ");
                for (int j = 0; j < players.GetLength(1); j++)
                {
                    Console.WriteLine(players[i, j].suit + "     " + players[i, j].rank + " ");
                }

            }
        }

    }

}

