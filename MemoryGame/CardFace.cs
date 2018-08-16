using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public class CardFace : Card, IPrintable
    {
        public string CardName { get; set; }

        public CardFace(string cardName)
        {
            this.CardName = cardName;
            this.IsVisible = false;
        }

        public override void DrawSelf(int column, int row)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(column, row);
                Print(position);
            }
        }

            public void Print(CardPosition topLeft)
            {
                if (this.CardName == "One")
                {
                PrintCardOne(topLeft);
                }
                else if (this.CardName == "Two")
                {
                PrintCardTwo(topLeft);
                }
                else if (this.CardName == "Three")
                {
                PrintCardThree(topLeft);
                }
                else if (this.CardName == "Four")
                {
                PrintCardFour(topLeft);
                }
                else if (this.CardName == "Five")
                {
                PrintCardFive(topLeft);
                }
                else if (this.CardName == "Six")
                {
                PrintCardSix(topLeft);
                }
                else if (this.CardName == "Seven")
                {
                PrintcardSeven(topLeft);
                }
                else if (this.CardName == "Eight")
                {
                PrintCardEight(topLeft);
                }
                else
                {
                PrintCardNine(topLeft);
                }
            }

        public static bool operator ==(CardFace firstCardFace, CardFace secondCardFace)
        {
            if (firstCardFace.CardName == secondCardFace.CardName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(CardFace firstCardFace, CardFace secondCardFace)
        {
            return !(firstCardFace == secondCardFace);
        }

        #region Card One
        public static void PrintCardOne(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Two
        public static void PrintCardTwo(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Three
        public static void PrintCardThree(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Four
        public static void PrintCardFour(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Five
        public static void PrintCardFive(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Six
        public static void PrintCardSix(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Seven
        public static void PrintcardSeven(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Eight
        public static void PrintCardEight(CardPosition topLeft)
        {

        }
        #endregion

        #region Card Nine
        public static void PrintCardNine(CardPosition topLeft)
        {

        }
        #endregion
    }
}
