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

        public override void DrawSelf(int row, int column)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(row, column);
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
                PrintCardSeven(topLeft);
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Card One
        public static void PrintCardOne(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.Write("  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.ResetColor();
        }
        #endregion

        #region Card Two
        public static void PrintCardTwo(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("--");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("--");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/**\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\/\\/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("/**\\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\**/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("--");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("--");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.ResetColor();
        }
        #endregion

        #region Card Three
        public static void PrintCardThree(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("__");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.ResetColor();
        }
        #endregion

        #region Card Four
        public static void PrintCardFour(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|~~~~|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("| ## |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("| ## |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("| ## |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("| ## |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("|~~~~|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.ResetColor();
        }
        #endregion

        #region Card Five
        public static void PrintCardFive(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("/ \\/ \\");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\    /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\  /");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("%%%%%%");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.ResetColor();
        }
        #endregion

        #region Card Six
        public static void PrintCardSix(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("______");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\\____/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\\__/");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("______");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\\____/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\\__/");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.ResetColor();
        }
        #endregion

        #region Card Seven
        public static void PrintCardSeven(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("(((");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(")))");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.ResetColor();
        }
        #endregion

        #region Card Eight
        public static void PrintCardEight(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|\\/|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("|/\\|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
            Console.ResetColor();
        }
        #endregion

        #region Card Nine
        public static void PrintCardNine(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\\/\\/\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("******");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("TEAM");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("DEAGON");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("******");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\\/\\/\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§");

            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("§§§§§§§§");
        }
        #endregion
    }
}
