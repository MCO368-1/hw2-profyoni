using System.Text;
using Humanizer;

namespace HumanizeMultTables
{

    // extension method
    public static class ExtMethods // multiple public classes in same file
    {
        public static string ToKidnapCase(this string s)
        {
            return "hEnDeRsOn";
        }
    }

    // static tags this class a s a utiulity non-instantiable class
    /// <summary>
    /// 
    /// </summary>
    public static class MultTables // Note: no static outer class in Java
    {
        /// <summary>
        /// Computes blah
        /// </summary>
        /// <param name="row"></param>
        /// <param name="colStart"></param>
        /// <param name="colEnd"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static string MultiplierRow(int row, int colStart, int colEnd, bool header = true)
        {
            StringBuilder sb = new StringBuilder(header ? $"{row.ToWords(),10} | " : "");
            for (int i = colStart; i <= colEnd; i++)
            {
                sb.Append($"{(row * i).ToWords(),10} | ");
            }
            return sb.ToString();
        }
    }
}
