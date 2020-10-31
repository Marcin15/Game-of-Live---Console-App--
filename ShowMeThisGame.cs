using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_of_Life
{
    class ShowMeThisGame
    {/// <summary>
    /// Wyswietla widok w konsoli
    /// </summary>
    /// <param name="cellList"></param>
    /// <param name="size"></param>
        public void View(List<Cell> cellList, int size)
        {
            NeighboursDetection NeighboursDetection = new NeighboursDetection();

            Console.CursorVisible = false;
            Console.Clear();

            Console.WriteLine("\n\n\n");
            //generowanie widoku
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    NeighboursDetection.AliveNeighboursCounter(cellList, cellList.Where(x => x.Row == i && x.Column == j).FirstOrDefault(), size);

                    Console.Write("{0} ", cellList.Where(x => x.Row == i && x.Column == j).Select(x => x.State).FirstOrDefault());
                }
                Console.WriteLine();
            }
        }
    }
}
