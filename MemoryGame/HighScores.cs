using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class HighScores
    {
        public static void Write(string playerAndScore)
        {
            string fileName = "../../../HighScores.txt";

            try
            {
                if (File.Exists(fileName) == false)
                {
                    StreamWriter streamWriter = new StreamWriter("../../../HighScores.txt");
                    using (streamWriter)
                    {
                        streamWriter.WriteLine(playerAndScore);
                    }
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter("../../../HighScores.txt", true);
                    using (streamWriter)
                    {
                        streamWriter.WriteLine(playerAndScore);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.SetCursorPosition(30, 16);
                Console.WriteLine("Error occured while trying to write to {0}", fileName);
            }
        }

        public static void Read()
        {
            string fileName = "../../../HighScores.txt";

            if (File.Exists(fileName) == false)
            {
                return;
            }
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    int lineNumber = 0;
                    string line = streamReader.ReadLine();

                    List<string> content = new List<string>();
                    while (line != null)
                    {
                        lineNumber++;
                        content.Add(line);
                        line = streamReader.ReadLine();
                    }
                    GradeScores(content);
                }
            }
            catch (Exception)
            {
                Console.SetCursorPosition(30, 29);
                Console.WriteLine("HighScore.txt has been corrupted.");
                System.Threading.Thread.Sleep(1000);

                if (File.Exists(fileName) == true)
                {
                    File.Delete(fileName);
                }
            }
        }

        public static void GradeScores(List<string> content)
        {
            Dictionary<int, string> unOrdered = new Dictionary<int, string>();
            for (int i = 0; i < content.Count; i++)
            {
                char[] remove = { ' ', '\n' };
                content[i] = content[i].TrimEnd(remove);
            }

            for (int i = 0; i < content.Count; i++)
            {
                int upToIndex = content.LastIndexOf(" ");
                string[] twoItems = content[i].Split(' ').ToArray();
                unOrdered.Add(int.Parse(twoItems[1]), twoItems[0]);
            }

            SortedDictionary<int, string> sorted = new SortedDictionary<int, string>();
            var keys = unOrdered.Keys.ToArray();
            Array.Sort(keys);
            Array.Sort(keys);

            for (int i = 0; i < unOrdered.Count; i++)
            {
                sorted.Add(keys[i], unOrdered[keys[i]]);
            }

            int currentRow = 29;

            for (int i = 0; i < sorted.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(36, currentRow);
                    Console.WriteLine("{0} {1}", keys[i], sorted[keys[i]]);
                    currentRow++;
                }
            }
        }
    }
}
