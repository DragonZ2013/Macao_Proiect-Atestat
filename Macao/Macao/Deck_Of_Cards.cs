using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macao
{
    class Deck_Of_Cards
    {
        /// <summary>
        /// Rank: 0-13: Joker,A,2,3...10,J,Q,K
        /// Suit: 0-4: Hearts, Diamonds, Clubs, Spades, Misc;
        /// </summary>
        public class Card
        {
            public int Rank, Suit;
            public Card(int rank, int suit)
            {
                Rank = rank;
                Suit = suit;
            }
        }
        Card[] InitializeArray<Card>(int length) where Card : new()
        {
            Card[] array = new Card[length];
            for (int i = 0; i < length; ++i)
            {
                array[i] = new Card();
            }

            return array;
        }
        public Card[] deck = new Card[160];
        public Card[] hand = new Card[160];
        public Card[] ai = new Card[160];
        public Card table;
        public int rankTable, suitTable;
        public int handSize=0,aiSize=0,drawTable=0,waitTable=0,deckPos, aiWait;
        public void NewDeck()
        {
            deckPos = 0;
            for(int i=0;i<52;i++)
            {
                deck[i] = new Card((i % 13)+1, i / 13);
            }
            deck[52] = new Card(0, 5);
            deck[53] = new Card(0, 5);
            var rand = new Random();
            ///shuffle
            for (int i=0;i<=52;i++)
            {
                Card temp = deck[i];
                int c = rand.Next(0,53);
                deck[i] = deck[Convert.ToInt32(c)];
                deck[Convert.ToInt32(c)] = temp;

            }
        }

        public void TableDraw()
        {
            Card table = deck[deckPos++];
            rankTable = table.Rank;
            suitTable = table.Suit;
        }
        public void PlayerDraw(int x)
        {
            if (deckPos + x > 52)
            { NewDeck();
                deckPos = 0;
            }
            for (int i = 0; i < x; i++)
                hand[++handSize] = deck[deckPos++];
        }
        public void AiDraw(int x)
        {
            if (deckPos + x > 52)
            {
                NewDeck();
                deckPos = 0;
            }
            for (int i = 0; i < x; i++)
                ai[++aiSize] = deck[deckPos++];
        }
        public Boolean Playable(Card x)
        {
            if (waitTable != 0 && (x.Rank == 1 || x.Rank == 4))
                return true;
            else
            if (waitTable != 0)
                return false;
            if (drawTable != 0)
            { if (x.Rank == 2 || x.Rank == 3 || x.Rank == 0 || x.Rank == 4)
                    return true;
                else
                    return false;
            }
            if (suitTable == 4 || rankTable==0 || rankTable==x.Rank || suitTable==x.Suit||x.Suit==4||x.Rank==0 )
                return true;
            return false;

        }

        public void PlayPlayer(int x)
        {
            table = hand[x];
            if (hand[x].Rank == 2)
                drawTable += 2;
            if (hand[x].Rank == 3)
                drawTable += 3;
            if (hand[x].Rank == 0)
                drawTable += 5;
            if (hand[x].Rank == 4)
            {
                drawTable = 0;
                waitTable = 0;
            }
            if (hand[x].Rank == 1)
                waitTable += 1;
            rankTable = table.Rank;
            suitTable = table.Suit;
            for (int i = x; i < handSize; i++)
                hand[i] = hand[i + 1];
            handSize--;
        }

        private int AiCheck()
        {
            int s0=0, s1=0, s2=0, s3=0;

            for (int i = 1; i <= aiSize; i++)
            {
                if (ai[i].Suit == 0)
                    s0++;
                else
                  if (ai[i].Suit == 1)
                    s1++;
                else
                  if (ai[i].Suit == 2)
                    s2++;
                else
                  if (ai[i].Suit == 3)
                    s3++;
            }
            if ((s0 >= s1) && (s0 >= s2) && (s0 >= s3))
                return 0;
            if ((s1 >= s0) && (s1 >= s2) && (s1 >= s3))
                return 1;
            if ((s2 >= s1) && (s2 >= s0) && (s2 >= s3))
                return 2;
            else
                return 3;


        }

        public void PlayAI(int x)
        {
            table = ai[x];
            for (int i = x; i < aiSize; i++)
                ai[i] = ai[i + 1];
            aiSize--;
            if (table.Rank == 2)
                drawTable += 2;
            if (table.Rank == 3)
                drawTable += 3;
            if (table.Rank == 0)
                drawTable += 5;
            if (table.Rank == 4)
            {
                drawTable = 0;
                waitTable = 0;
            }
            if (table.Rank == 1)
                waitTable += 1;
            if (table.Rank == 7)
                table.Suit = AiCheck();
            rankTable = table.Rank;
            suitTable = table.Suit;
        }

        public void AIRound()
        {
            for (int i = 1; i <= aiSize; i++)
                if (Playable(ai[i]))
                { PlayAI(i);
                    return;
                }
            if (waitTable != 0)
            {
                aiWait = waitTable-1;
                waitTable = 0;
            }
            else
            if (drawTable == 0)
                AiDraw(1);
            else
            {
                AiDraw(drawTable);
                drawTable = 0;
            }

        }





    }
}
