using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Utils
{
    public enum WindowType
    {
        Find,
        Replace
    }

    public class SelectedText
    {
        public string Text { get; set; }
        public int Index { get; set; }

    }

    public static class Extensions
    {
        public static IEnumerable<int> AllIndeciesOf(this string aString, string value, bool isCaseSensitive)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("Строка для поиска не должна быть пустой", nameof(value));

            var indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                if (isCaseSensitive)
                {
                    index = aString.IndexOf(value, index, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    index = aString.IndexOf(value, index);
                }
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}
