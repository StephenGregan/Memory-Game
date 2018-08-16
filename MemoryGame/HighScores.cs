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

                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void GradeScores(List<string> content)
        {

        }
    }
}
