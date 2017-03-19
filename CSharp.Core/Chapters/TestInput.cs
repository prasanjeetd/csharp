using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters
{
    public class TextInput
    {
        protected List<char> words =new List<char>();

        public virtual void Add(char c)
        {
            words.Add(c);
        }

        public string GetValue() {

            return new string(words.ToArray());
        }
    }

    public class NumericInput:TextInput
    {
        public override void Add(char c)
        {
            if (Char.IsNumber(c))
                words.Add(c);
        }

    }
}
