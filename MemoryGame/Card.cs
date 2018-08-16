using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    [Serializable]
    public abstract class Card
    {
        public bool IsVisible { get; set; }

        public Card()
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

        }

        public abstract void DrawSelf(int positionX, int positionY);
    }
}
