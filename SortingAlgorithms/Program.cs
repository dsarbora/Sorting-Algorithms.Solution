using System;
using SortingAlgorithms.Models;

namespace SortingAlgorithms
{
    class Program
    {
        public static void Main()
        {
            Sorter sorter = new Sorter();
            //Console.WriteLine("Give me the integers you'd like to sort. Enter Q to run program.");
            sorter.RunList(sorter.GetList());
        }
    }
}