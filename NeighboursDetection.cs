using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_of_Life
{
    class NeighboursDetection
    {
        private List<Cell> YourNeighbor(Cell cell, int size)
        {
            List<Cell> neighbours = new List<Cell>();

            //north-west
            if(cell != null)
            {
                if (cell.Row > 0 && cell.Column > 0)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row - 1,
                        Column = cell.Column - 1
                    });
                //north
                if (cell.Row > 0)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row - 1,
                        Column = cell.Column
                    });
                //north-east
                if (cell.Row > 0 && cell.Column < size - 1)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row - 1,
                        Column = cell.Column + 1
                    });
                //west
                if (cell.Column > 0)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row,
                        Column = cell.Column - 1
                    });
                //east
                if (cell.Column < size - 1)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row,
                        Column = cell.Column + 1
                    });
                //south-west
                if (cell.Row < size - 1 && cell.Column > 0)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row + 1,
                        Column = cell.Column - 1
                    });
                //south
                if (cell.Row < size - 1)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row + 1,
                        Column = cell.Column
                    });
                //south-east
                if (cell.Row < size - 1 && cell.Column < size - 1)
                    neighbours.Add(new Cell
                    {
                        Row = cell.Row + 1,
                        Column = cell.Column + 1
                    });
            }
            else
                Console.WriteLine("Error");

            return neighbours;
        }

        public Cell AliveNeighboursCounter(List<Cell> cellList, Cell cell, int size)
        {

            List<Cell> neighbours = YourNeighbor(cell, size);

            int counter = 0;
            foreach (var item in neighbours)
            {
                var res = cellList.Where(x => x.Row == item.Row && x.Column == item.Column).Select(x => x.IsAlive).FirstOrDefault();
                if (res == true)
                    counter++;
            }
            cell.AliveNeighbours = counter;

            return cell;
        }
    }
}
