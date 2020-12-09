using SudokuSolver.Helper;
using SudokuSolver.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SudokuSolver.Service
{
    public static class FileService
    {
        public static Table ReadTable(string path)
        {
            var lines = File.ReadAllLines(path);
            var rows = new List<Field[]>();
            foreach (var line in lines)
            {
                var splitedLine = line.Split(',');
                var fields = splitedLine.Select(x => new Field(x));
                rows.Add(fields.ToArray());
            }

            return new Table
            {
                Rows = rows.ToArray(),
                Columns = HelperMethods.ConvertRowsToColumns(rows.ToArray()),
                Squares = HelperMethods.ConvertRowsToSquares(rows.ToArray())
            };
        }
    }
}
