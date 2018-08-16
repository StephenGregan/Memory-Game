using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class CardRandomPosition
    {
        public static CardFace[,] GetRandomCardFace(int dimentionZero, int dimentionOne)
        {
            const int pair = 2;
            const int pairCount = 9;
            CardFace[,] cardFace = new CardFace[dimentionZero, dimentionOne];
            Random randomGeneator = new Random();
            List<CardFace> gameCard = new List<CardFace>();
            int allCard = dimentionZero * dimentionOne;
            int currentDameCardPair = allCard / pair;
            string[] cardName = new string[pairCount] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            for (int element = 0, j = 0; element < allCard; element++, j++)
            {
                if (j == currentDameCardPair)
                {
                    j = 0;
                }
                gameCard.Add(new CardFace(cardName[j]));
            }
            for (int row = 0; row < dimentionZero; row++)
            {
                for (int column = 0; column < dimentionOne; column++)
                {
                    int randomElement = randomGeneator.Next(0, gameCard.Count);
                    cardFace[column, row] = gameCard[randomElement];
                    gameCard.RemoveAt(randomElement);
                }
            }
            return cardFace;
        }

        public static CardBack[,] GetCardBack(int level)
        {
            const int columnEnd = 6;
            CardBack[,] cardBack = new CardBack[level, columnEnd];
            for (int row = 0; row < cardBack.GetLength(0); row++)
            {
                for (int column = 0; column < cardBack.GetLength(1); column++)
                {
                    cardBack[column, row] = new CardBack();
                }
            }
            return cardBack;
        }
    }
}
