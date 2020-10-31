using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Game_of_Life
{
    class LaunchParameters
    {
        public void Launch(List<Cell> CellList, int size)
        {
            NeighboursDetection neighboursDetection = new NeighboursDetection();

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;

            CellList.Where(x => x.Row == 0  && x.Column == 24).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 1  && x.Column == 22).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 1  && x.Column == 24).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 2 && x.Column == 12).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 2 && x.Column == 13).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 2 && x.Column == 20).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 2 && x.Column == 21).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 2 && x.Column == 34).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 2 && x.Column == 35).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 3 && x.Column == 11).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 3 && x.Column == 15).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 3 && x.Column == 20).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 3 && x.Column == 21).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 3 && x.Column == 34).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 3 && x.Column == 35).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 4 && x.Column == 0).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 4 && x.Column == 1).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 4 && x.Column == 10).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 4 && x.Column == 16).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 4 && x.Column == 20).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 4 && x.Column == 21).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 5 && x.Column == 0).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 1).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 10).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 14).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 16).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 17).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 22).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 5 && x.Column == 24).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 6 && x.Column == 10).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 6 && x.Column == 16).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 6 && x.Column == 24).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 7 && x.Column == 11).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 7 && x.Column == 15).Select(x => x.IsAlive = true).FirstOrDefault();

            CellList.Where(x => x.Row == 8 && x.Column == 12).Select(x => x.IsAlive = true).FirstOrDefault();
            CellList.Where(x => x.Row == 8 && x.Column == 13).Select(x => x.IsAlive = true).FirstOrDefault();

            foreach (var item in CellList)
            {
                neighboursDetection.AliveNeighboursCounter(CellList, item, size);
            }
        }
    }
}
