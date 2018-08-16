using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int SuccessCoEfficient { get; set }

        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
            this.SuccessCoEfficient = 20;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("Score", this.Score);
            info.AddValue("SuccessCoEfficient", this.SuccessCoEfficient);
        }
    }
}
