/*using System;
using System.Collections.Generic;
using System.Text;

namespace Консольный_калькулятор
{
    public class counting_words
    {
        public static string Counter(string SomeText)
        {
            SomeText = "";
            int countWords = SomeText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return SomeText;
        }
    }
}
