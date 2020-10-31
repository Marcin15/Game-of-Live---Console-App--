using System;
using System.Collections.Generic;
using System.Threading;

namespace Game_of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfObjects listobj = new ListOfObjects();
            LaunchParameters launchParameters = new LaunchParameters();
            ShowMeThisGame showMeThisGame = new ShowMeThisGame();
            Rules rules = new Rules();

            Console.WriteLine("Wielkość siatki: ");
            string rc = Console.ReadLine();
            int size = Convert.ToInt32(rc);

            List<Cell> cellList = listobj.GenerateObjects(size);

            //parametry startowe
            launchParameters.Launch(cellList, size);

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMilliseconds(300);

            //okresowe wywoływanie metody
            var timer = new Timer((e) =>
                {
                    showMeThisGame.View(cellList, size);
                    rules.DeadOrAlive(cellList);

                }, null, startTimeSpan, periodTimeSpan);

            Console.ReadLine();
        }
    }
}
