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
        public int Level { get; set; }

        public GameEngine(CardBack[,] cardBack, CardFace[,] cardFace, Player player, int level)
        {
            this.CardBack = cardBack;
            this.CardFace = CardFace;
            this.Player = player;
            this.Check = new List<CardPosition>();
            this.Level = level;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("CardBack", this.CardBack);
            info.AddValue("CardFace", this.CardFace);
            info.AddValue("Player", this.Player);
            info.AddValue("Check", this.Check);
            info.AddValue("Level", this.Level);
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
                        GameManager.SaveGame(this.CardBack, this.CardFace, this.Player, this.Check, this.Level);
                        GameManager.ExitGame();
                    }
                }
                dimentionZero %= CardFace.GetLength(0);
                dimentionOne %= CardFace.GetLength(1);
                PointerVisualiation(ConsoleColor.Yellow, dimentionZero, dimentionOne);

                if (Check.Count >= 1)
                {
                    CheckForEquals();
                }
                System.Threading.Thread.Sleep(200);
            }
        }

        private void CheckForEquals()
        {
            if (Check.Count == 1)
            {
                CardPosition firstCard = Check[0];
                this.CardFace[firstCard.X, firstCard.Y].IsVisible = true;
                this.CardBack[firstCard.X, firstCard.Y].IsVisible = false;
            }
            if (Check.Count == 2)
            {
                CardPosition firstCard = Check[0];
                this.CardFace[firstCard.X, firstCard.Y].IsVisible = true;
                this.CardBack[firstCard.X, firstCard.Y].IsVisible = false;
                CardPosition secondCard = Check[1];
                this.CardFace[secondCard.X, secondCard.Y].IsVisible = true;
                this.CardBack[secondCard.X, secondCard.Y].IsVisible = false;

                Refresh();

                if (this.CardFace[firstCard.X, firstCard.Y] != this.CardFace[secondCard.X, secondCard.Y])
                {
                    this.CardFace[firstCard.X, firstCard.Y].IsVisible = false;
                    this.CardFace[firstCard.X, firstCard.Y].IsVisible = true;
                    this.CardFace[secondCard.X, secondCard.Y].IsVisible = false;
                    this.CardFace[secondCard.X, secondCard.Y].IsVisible = true;
                    this.Player.SuccessCoEfficient--;
                    PrintPlayerInfo("Fail");
                }
                else
                {
                    this.Player.Score += this.Player.SuccessCoEfficient > 0 ? point * this.Player.SuccessCoEfficient : point;
                    PrintPlayerInfo("Success");

                    if (CheckForGameEnd())
                    {
                        if (this.Level < maxLevel)
                        {
                            NextLevel();
                            GameBackground.CleanBackground();
                            Refresh();
                            Grid();
                        }
                        else
                        {
                            GameBackground.CleanBackground();
                            GameManager.SaveScore(this.Player);
                            GameManager.WinGame();
                        }
                    }
                }
                Check.Clear();
                System.Threading.Thread.Sleep(800);
            }
            Refresh();
        }

        private void NextLevel()
        {
            this.Level++;
            this.CardBack = CardRandomPosition.GetCardBack(Level);
            this.CardFace = CardRandomPosition.GetRandomCardFace(this.CardBack.GetLength(0), this.CardBack.GetLength(1));
        }

        private bool CheckForGameEnd()
        {
            int sumOfVisibleCard = 0;
            foreach (var element in CardFace)
            {
                if (element.IsVisible == true)
                {
                    sumOfVisibleCard++;
                }
            }

            if (sumOfVisibleCard == CardFace.GetLength(0) * CardFace.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PrintPlayerInfo(string message)
        {
            const int half = 2;
            Console.SetCursorPosition(Console.WindowWidth / half - this.Player.Name.Length / half, 8);
            Console.WriteLine(this.Player.Name);
            Console.SetCursorPosition(Console.WindowWidth / half - this.Player.Score.ToString().Length / half - "score ".Length / half, 10);
            Console.WriteLine("Score: {0}", this.Player.Score);
            Console.SetCursorPosition(Console.WindowWidth / half - message.Length / half, 12);
        }

        private void PointerVisualiation(ConsoleColor consoleColour, int dimentionZero, int dimentionOne)
        {
            CardPosition position = CardPosition.GeneratePosition(dimentionZero, dimentionOne);
            PrintPointer(position, consoleColour);
        }

        private void PrintPointer(CardPosition position, ConsoleColor consoleColour)
        {
            Console.SetCursorPosition(position.X - 1, position.Y -1);
            Console.ForegroundColor = consoleColour;
            Console.Write(new string(' ', 10));

            for (int i = 0; i < 9; i++)
            {
                position.Y++;
                Console.SetCursorPosition(position.X - 1, position.Y - 1);
                Console.Write("|");
                Console.SetCursorPosition(position.X - 1 + 9, position.Y - 1 + 9);
                Console.Write("|");
            }
            Console.SetCursorPosition(position.X - 1, position.Y - 1);
            Console.Write(new string('-', 10));
            Console.ResetColor();
        }

        void Refresh()
        {
            for (int row = 0; row < this.CardBack.GetLength(0); row++)
            {
                for (int column = 0; column < this.CardBack.GetLength(1); column++)
                {
                    this.CardBack[row, column].DrawSelf(row, column);
                    this.CardFace[row, column].DrawSelf(row, column);
                }
            }
        }

        private void Grid()
        {
            const int gridRightWhiteSpace = 2;
            const int gridDownWhiteSpace = 1;
            Console.ForegroundColor = ConsoleColor.Red;

            for (int element = 0; element < this.CardBack.GetLength(1) - 1; element++)
            {
                int column = this.CardBack[0, element].TopLeft.X + this.CardBack[0, element].Width + gridRightWhiteSpace;
                int startOfGrid = this.CardBack[0, element].TopLeft.Y - this.CardBack[0, element].Width;
                int endOfGrid = this.CardBack[this.CardBack.GetLength(0) - 1, element].TopLeft.Y;

                for (int row = startOfGrid; row < endOfGrid; row++)
                {
                    Console.SetCursorPosition(column, row);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|");
                }
            }

            for (int element = 0; element < this.CardBack.GetLength(0) - 1; element++)
            {
                int row = this.CardBack[element, 0].TopLeft.Y + gridDownWhiteSpace;
                int startOfGrid = this.CardBack[element, 0].TopLeft.X;
                int endOfGrid = this.CardBack[element, this.CardBack.GetLength(1) - 1].TopLeft.X + this.CardBack[element, this.CardBack.GetLength(1) - 1].Width;

                for (int column = startOfGrid; column < endOfGrid; column++)
                {
                    Console.SetCursorPosition(column, row);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("-");
                }
            }    
        }
    }
}
