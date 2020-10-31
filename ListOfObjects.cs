using System.Collections.Generic;

namespace Game_of_Life
{
    class ListOfObjects
    {
        private List<Cell> CellList = new List<Cell>();

        public List<Cell> GenerateObjects(int size)
        {
            //Tworze liste obiektow
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    CellList.Add(new Cell
                    {
                        Row = j,
                        Column = i
                    });
                }
            }
            return CellList;
        }
    }
}
