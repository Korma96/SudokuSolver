using SudokuSolver.Helper;
using System.Collections.Generic;

namespace SudokuSolver.Model
{
    public class Field
    {
        public Field()
        {
            PossibleValues = HelperMethods.GetAllPossibleValues();
        }

        public Field(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Value = int.Parse(value);
            }
            PossibleValues = HelperMethods.GetAllPossibleValues();
        }

        public int? Value { get; set; }

        public bool IsEmpty { get => Value is null; }

        public List<int> PossibleValues { get; set; }

        public override string ToString()
        {
            return IsEmpty ? Constants.Space : Value.ToString();
        }
    }
}
