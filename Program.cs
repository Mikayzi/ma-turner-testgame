using System;

namespace BlackJack
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /**
     * Each deck will contain 52 cards.
     */
    class Deck
    {
        private int[] cards;
        public Deck()
        {
            this.cards = initDeckOfCards();
        }

        public int[] getDeckOfCards()
        {
            return this.cards;
        }

        private int[] initDeckOfCards()
        {
            //52 cards in a deck
            int[] cards = new int[52];

            int cardsCount = 0;

            //4 suits per deck
            for (int suit = 1; suit <= 4; suit++)
            {
                //13 cards per suit
                for (int cardValue = 1; cardValue <= 13; cardValue++)
                {

                    if (cardValue >= 11)
                    {
                        //Jack, Queen, King uses value of 10
                        cards[cardsCount++] = 10;

                    }
                    else if (cardValue == 1)
                    {
                        //Ace uses value of 11
                        cards[cardsCount++] = 11;

                    }
                    else
                    {
                        //Cards 2-10 are assigned a face value
                        cards[cardsCount++] = cardValue;

                    }
                }

            }

            return cards;

        }
    }
    /**
     * A hand will consist of 2 to many cards. Each BlackJack player will be dealt one hand.
    */
    class Hand
    {
        private int[] cards;
        public Hand()
        {

        }

        public int[] getCards()
        {
            return this.cards;
        }

        public void AddCard(int cardValue)
        {
            //Dummy array to preserve original value of cards
            int[] tempCards = this.cards;

            //If hand has 0 cards
            if (tempCards == null)
            {
                tempCards = new int[1];
            }
            //If hand has more than 0 cards
            else
            {
                //Increase array size by one for the next card
                tempCards = new int[this.cards.Length + 1];

                //Populate temp cards array with original cards
                for (int i = 0; i < this.cards.Length - 1; i++)
                {
                    tempCards[i] = this.cards[i];
                }
            }
            //Assign new card value to last index of array
            tempCards[tempCards.Length - 1] = cardValue;
            //Assign hand cards to temp cards array
            this.cards = tempCards;
        }

        class BlackJackGame
        {
            //Dealer's hand to be used for each game.  
            //First card of dealer's hand will be visible to player.
            private Hand dealerHand;

            private Hand[] playerHands;


            public BlackJackGame()
            {
            }
            //TODO getters and setters
        }
        static class Dealer
        {

            public static BlackJackGame InitBlackJackGame()
            {
                //TODO implement the stuffs
                return new BlackJackGame();
            }

            public static BlackJackGame Deal(BlackJackGame game)
            {

                return game;
            }
            public static Boolean IsWinner(Hand hand)
            {
                return false;
            }
            public static Boolean IsBust(Hand hand)
            {
                //total sum of hand's cards. return true if hand's sum is > 21.
                int[]
                return true;
            }
            /**
            * Shuffle the given array of cards.
            * Sorts the given array of ints in random order and returns the sorted array.
            */
            public static int[] ShuffleCards(int[] cards)
            {
                Random rand = new Random();

                // For each spot in the array, picka random item to swap into that spot.
                for (int i = 0; i < cards.Length - 1; i++)
                {
                    int j = rand.Next(i, cards.Length);
                    //We need temp value to store current value at index i.
                    int temp = cards[i];
                    //Replace value at index i with value from index j.
                    cards[i] = cards[j];
                    //Replace value at index j with value that was stored at index i.
                    cards[j] = temp;
                }

                return cards;
            }
        }
    }
}