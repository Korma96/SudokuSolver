using SudokuSolver.Model;

namespace SudokuSolver.Helper
{
    public static class ExtensionMethods
    {
        public static bool Contains(this Field[] array, Field field)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Value == field.Value)
                    return true;
            }
            return false;
        }
    }
}
