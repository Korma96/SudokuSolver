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
            PossibleValues = HelperMethods.GetAllPossibleValues();
            if (!string.IsNullOrWhiteSpace(value))
            {
                Value = int.Parse(value);
                RemovePossibleValue(Value.Value);
            }
        }

        public int? Value { get; set; }

        public bool IsEmpty { get => Value is null; }

        public List<int> PossibleValues { get; set; }

        public void RemovePossibleValue(int value)
        {
            PossibleValues.Remove(value);
            HelperMethods.Log(PossibleValues.Count);
            if (PossibleValues.Count == 1)
            {
                Value = PossibleValues[0];
                System.Console.WriteLine("seeeeeeeeet");
            }
        }

        public void RemovePossibleValue(Field field)
        {
            RemovePossibleValue(field.Value.Value);
        }

        public override string ToString()
        {
            return IsEmpty ? $" {Constants.Space} " : $" {Value.ToString()} ";
        }
    }
}
