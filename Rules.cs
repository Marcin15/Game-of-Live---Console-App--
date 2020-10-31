using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Life
{
    class Rules
    {
        public void DeadOrAlive(List<Cell> cellList)
        {
            foreach (var item in cellList)
            {
                if (item.IsAlive == false && item.AliveNeighbours == 3)
                    item.IsAlive = true;
                else if (item.IsAlive == true && item.AliveNeighbours == 2 || item.IsAlive == true && item.AliveNeighbours == 3)
                    item.IsAlive = true;
                else
                    item.IsAlive = false;
            }
        }
    }
}
