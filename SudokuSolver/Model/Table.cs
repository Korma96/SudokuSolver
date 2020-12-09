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
            for (int k = 0; k < 39; k++)
                sb.Append(Constants.HorizontalLine);
            sb.AppendLine();

            for (int i=0; i < Rows.Length; i++)
            {
                for (int j = 0; j < Rows[i].Length; j++)
                {
                    if (j == 0)
                        sb.Append(Constants.VerticalLine);
                    sb.Append(Rows[i][j].ToString());
                    sb.Append(Constants.VerticalLine);
                    if (j == 2 || j == 5)
                        sb.Append(Constants.VerticalLine);
                }

                sb.AppendLine();
                if (i == 2 || i == 5)
                {
                    for (int k = 0; k < 39; k++)
                        sb.Append(Constants.Equality);
                }
                else
                {
                    for (int k = 0; k < 39; k++)
                        sb.Append(Constants.HorizontalLine);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
