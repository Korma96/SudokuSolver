using System;
using System.Collections.Generic;
using System.IO;

namespace SudokuSolver.Helper
{
    public static class HelperMethods
    {
        public static List<int> GetAllPossibleValues() => new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static T[][] ConvertRowsToColumns<T>(T[][] rows)
        {
            var columns = InitializeEmtpyMatrix<T>(rows.Length, rows[0].Length);
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    columns[j][i] = rows[i][j];
                }
            }
            return columns;
        }

        public static T[][] ConvertRowsToSquares<T>(T[][] rows)
        {
            var squares = InitializeEmtpyMatrix<T>(rows.Length, rows[0].Length);
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[i].Length; j++)
                {
                    var Is = (i / 3) * 3 + j / 3;
                    var Js = (i % 3) * 3 + j % 3;
                    squares[Is][Js] = rows[i][j];
                }
            }
            return squares;
        }

        /// <param name="dim1">Number of arrays</param>
        /// <param name="dim2">Inner array dimension</param>
        public static T[][] InitializeEmtpyMatrix<T>(int dim1, int dim2)
        {
            var matrix = new List<T[]>();
            for (int i=0; i<dim1; i++)
            {
                matrix.Add(new T[dim2]);
            }
            return matrix.ToArray();
        }

        public static void Log(string text)
        {
            File.AppendAllText(Settings.LogFilePath, text + Environment.NewLine);
        }

        public static void Log(int value)
        {
            Log(value.ToString());
        }
    }
}
