using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public class SerializeObject
    {
        private GameEngine gameEngine;

        public GameEngine GameEngine
        {
            get
            {
                return this.gameEngine;
            }
            set
            {
                this.GameEngine = value;
            }
        }
        public SerializeObject()
        {
        }

        public void getobjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("GameEngine", this.GameEngine);
        }
    }
}
