﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class GameManager
    {
        static int level = 1;

        public static void Menu()
        {
            const int menuItemCount = 3;
            int menuSwitchPosition = 0;
            int position = 0;

            for (int row = 0; row < menuItemCount; row++)
            {
                GameBackground.MenuBackGround(row, ConsoleColor.Black, ConsoleColor.Red);
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
                    {
                        if (menuSwitchPosition > 0)
                        {
                            menuSwitchPosition--;
                        }
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
                    {
                        menuSwitchPosition++;
                    }
                    if (keyInfo.Key.Equals(ConsoleKey.Enter))
                    {
                        break;
                    }
                }
                GameBackground.MenuBackGround(position, ConsoleColor.Black, ConsoleColor.Red);
                position = menuSwitchPosition % menuItemCount;
                GameBackground.MenuBackGround(position, ConsoleColor.Cyan, ConsoleColor.Blue);
                System.Threading.Thread.Sleep(400);
            }
            GameBackground.CleanBackground();
            switch (position)
            {
                case 0:
                    NewGame(level);
                    break;
                case 1:
                    LoadGame();
                    break;
                case 2:
                    Help.SomeHelp();
                    break;
            }
        }

        public static void NewGame(int level)
        {
            CardBack[,] cardBack = CardRandomPosition.GetCardBack(level);
            CardFace[,] cardFace = CardRandomPosition.GetRandomCardFace(cardBack.GetLength(0), cardBack.GetLength(1));
            GameEngine gameEngine = new GameEngine(cardBack, cardFace, new Player(ConsoleInput.GetInput()), level);
            gameEngine.Run();
        }

        public static void LoadGame()
        {
            try
            {
                string fileName = "../../../Save.memory";
                Serializer serializer = new Serializer();
                SerializeObject serializeObject = new SerializeObject();
                serializeObject = serializer.Deserializeobject(fileName);
                GameEngine gameEngine = serializeObject.GameEngine;
                gameEngine.Run();
            }
            catch (Exception)
            {
                GameBackground.CleanBackground();
                Console.SetCursorPosition(8, 10);
                Console.WriteLine("Error occureed while trying to open file, or file doesn't exist ");
                System.Threading.Thread.Sleep(1000);
                GameBackground.CleanBackground();
                GameManager.Menu();
            }
        }

        public static void ExitGame()
        {
            Environment.Exit(0);
        }

        public static void WinGame()
        {
            GameBackground.CleanBackground();
            Console.SetCursorPosition(28, 16);
            Console.WriteLine("Congradulations, You Win!");
            System.Threading.Thread.Sleep(3000);
            GameBackground.CleanBackground();
        }

        public static void SaveGame(CardBack[,] cardBack, CardFace[,] cardFace, Player player, List<CardPosition> list, int level)
        {
            string fileName = "../../../Save.memory";
            GameEngine saveGame = new GameEngine(cardBack, cardFace, player, level);
            SerializeObject serializeObject = new SerializeObject();
            serializeObject.GameEngine = saveGame;
            Serializer serializer = new Serializer();
            serializer.SerializeObject(fileName, serializeObject);
        }

        public static void SaveScore(Player player)
        {
            string playerToWrite = player.Name;
            string scoreToWrite = player.Score.ToString();

            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append(playerToWrite);
            builder.Append(" ");
            builder.Append(scoreToWrite);

            string playerAndScore = builder.ToString();
            HighScores.Write(playerAndScore);
        }
    }
}
