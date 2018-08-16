using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    public class Serializer
    {
        public Serializer()
        {
        }

        public void SerializeObject(string fileName, SerializeObject serializeObject)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    binaryFormatter.Serialize(stream, serializeObject);
                }
            }
            catch (Exception)
            {
                GameBackground.CleanBackground();
                Console.SetCursorPosition(16, 10);
                Console.WriteLine("Error occured while trying to write to file.");
                System.Threading.Thread.Sleep(1000);
                GameBackground.CleanBackground();
                GameManager.Menu();
            }
        }

        public SerializeObject Deserializeobject(string fileName)
        {
            SerializeObject serializeObject;
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                serializeObject = (SerializeObject)binaryFormatter.Deserialize(stream);
            }
            return serializeObject;
        }
    }
}
