using SudokuSolver.Helper;
using System.Text;

namespace SudokuSolver.Model
{
    public class Table
    {
        public Field[][] Rows { get; set; }
        public Field[][] Columns { get; set; }
        public Field[][] Squares { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i=0; i < Rows.Length; i++)
            {
                for (int j = 0; j < Rows[i].Length; j++)
                {
                    if (j == 0)
                        sb.Append(Constants.VerticalLine);
                    sb.Append(Rows[i][j].ToString());
                    sb.Append(Constants.VerticalLine);
                }

                sb.AppendLine();
                for (int k = 0; k < 19; k++)
                    sb.Append(Constants.HorizontalLine);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
