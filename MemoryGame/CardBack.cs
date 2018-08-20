using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public class CardBack : Card, IPrintable
    {
        const int cardWidth = 8;
        const int cardHeight = 10;
        public int Height { get; protected set; }
        public int Width { get; protected set; }
        public CardPosition TopLeft { get; protected set; }

        public CardBack()
        {
            this.IsVisible = true;
            this.Height = cardHeight;
            this.Width = cardWidth;
            this.TopLeft = new CardPosition();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("IsVisible", this.IsVisible);
            info.AddValue("Height", this.Height);
            info.AddValue("Weight", this.Width);
            info.AddValue("TopLeft", this.TopLeft);
        }

        public override void DrawSelf(int row, int column)
        {
            if (IsVisible)
            {
                CardPosition position = CardPosition.GeneratePosition(row, column);
                this.TopLeft = position;
                Print(position);
            }
        }

        public void Print(CardPosition topLeft)
        {
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("##=##=##");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#**");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("/\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("**#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//\\\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("??");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("??");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\\\//");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("*#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.Write("#**");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\\/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("**#");
            Console.SetCursorPosition(topLeft.X, topLeft.Y);
            topLeft.Y++;
            Console.WriteLine("##=##=##");
            Console.ResetColor();
        }
    }
}
