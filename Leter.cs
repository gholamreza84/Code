using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Leter : ICode
    {
        public string Code(string text, int value)
        {
            return new string(text.Select(c => char.IsLetter(c) ? NumChar(c, value) : c).ToArray());
        }
        private char NumChar(char c, int value)
        {
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c - offset) + value) % 26) + offset);
        }
    }
}
