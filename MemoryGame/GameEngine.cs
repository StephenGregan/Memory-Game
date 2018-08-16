using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public class GameEngine
    {
        const int maxLevel = 3;
        const int point = 2;
        public CardBack[,] CardBack { get; set; }
        public CardFace[,] CardFace { get; set; }
        public Player Player { get; set; }
        public List<CardPosition> Check { get; set; }
        public int level { get; set; }

        public GameEngine(CardBack[,] cardBack, CardFace[,] cardFace, Player player, int level)
        {
            this.CardBack = cardBack;
            this.CardFace = CardFace;
            this.Player = player;
            this.Check = new List<CardPosition>();
            this.level = level;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CardBack", this.CardBack);
            info.AddValue("CardFace", this.CardFace);
            info.AddValue("Player", this.Player);
            info.AddValue("Check", this.Check);
            info.AddValue("Level", this.level);
        }

        public void Run()
        {
            int dimentionZero = 0;
            int dimentionOne = 0;

            Refresh();
            Grid();

            while (true)
            {
                PrintPlayerInfo("           ");
                PointerVisualiation(ConsoleColor.Black, dimentionZero, dimentionOne);
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
                    {
                        if (dimentionZero > 0)
                        {
                            dimentionZero--;
                        }
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
                    {
                        dimentionZero++;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.LeftArrow))
                    {
                        dimentionOne--;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.RightArrow))
                    {
                        dimentionOne++;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.Spacebar))
                    {
                        if (!CardFace[dimentionZero, dimentionOne].IsVisible)
                        {
                            Check.Add(new CardPosition(dimentionZero, dimentionOne));
                        }
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.Escape))
                    {
                        foreach (var position in this.Check)
                        {
                            this.CardBack[position.X, position.Y].IsVisible = true;
                            this.CardFace[position.X, position.Y].IsVisible = false;
                        }
                        GameManager
                    }

                }
            }
        }

        private void CheckForEquals()
        {

        }

        private void NextLevel()
        {

        }

        private bool CheckForGameEnd()
        {
            return false;
        }

        private void PrintPlayerInfo(string message)
        {

        }

        private void PointerVisualiation(ConsoleColor consoleColour, int dimentionZero, int dimentionOne)
        {

        }

        private void PrintPointer(CardPosition position, ConsoleColor consoleColour)
        {

        }

        private void Grid()
        {

        }
    }
}
