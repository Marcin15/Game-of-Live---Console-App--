using System.Collections.Generic;

namespace Game_of_Life
{
    class Cell
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int AliveNeighbours { get; set; }

        public bool IsAlive { get; set; }

        public string State
        {
            get 
            { 
                if (IsAlive)
                    return "¤";
                else
                    return " ";
            }
        }
        public Cell()
        {
            AliveNeighbours = 0;
            IsAlive = false;
        }
    }
}
