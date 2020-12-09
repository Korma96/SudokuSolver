using SudokuSolver.Helper;
using SudokuSolver.Model;
using System;

namespace SudokuSolver.Service
{
    public class SolverService
    {
        public static Table Solve(Table table)
        {
            for (int iteration=0; iteration < Settings.NumberOfIterations; iteration++)
            {
                Console.WriteLine("ITERATION: " + iteration);
                HelperMethods.Log("ITERATION: " + iteration);
                table.Rows = SolveBy(table.Rows);
                table.Columns = SolveBy(table.Columns);
                table.Squares = SolveBy(table.Squares);
            }
            return table;
        }

        private static Field[][] SolveBy(Field[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                var array = arrays[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (!array[j].IsEmpty)
                    {
                        for (int k = 0; k < array.Length; k++)
                        {
                            if (array[k].IsEmpty)
                            {
                                array[k].RemovePossibleValue(array[j]);
                                //Console.WriteLine("removed");
                            }
                        }
                    }
                }
            }
            return arrays;
        }
    }
}
