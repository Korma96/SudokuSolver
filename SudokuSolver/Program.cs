using SudokuSolver.Helper;
using SudokuSolver.Service;
using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = FileService.ReadTable(Settings.ReadPath);
            Console.WriteLine(table.ToString());
            Console.ReadKey();
        }
    }
}
